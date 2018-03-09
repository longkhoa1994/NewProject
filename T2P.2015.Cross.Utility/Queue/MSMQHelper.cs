using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using T2P._2015.Cross.Utility.ExceptionHandling;

namespace T2P._2015.Cross.Utility
{
    public class QueueManager
    {
        public static void SetThreads(int threads)
        {
            ThreadPool.SetMaxThreads(threads, threads);
            ThreadPool.SetMinThreads(threads, threads);
        }

        public static void QueueListen<T1>(Action<T1> act, string queueLinsten, string queueFail, string labelField = "", bool isCreateQueue = false)
        {
            QueueReceiver queueReceiver = new QueueReceiver(queueLinsten, isCreateQueue);
            queueReceiver.Init<T1>(act, queueFail, labelField);
            QueueManager.ListQueue.Add(queueReceiver);
        }

        public static void QueueListen<T, T2>(Func<T, T2> act, string queueLinsten, string queueNextLinsten, string queueFail, string labelField = "", bool isCreateQueue = false)
        {
            QueueReceiver queueReceiver = new QueueReceiver(queueLinsten, isCreateQueue);

            Func<T, T2> func = act;

            queueReceiver.Init<T, T2>(func, queueNextLinsten, queueFail, labelField);
            QueueManager.ListQueue.Add(queueReceiver);
        }

        public static void QueueListenLimitTime<T, T2>(Func<T, T2> act, string queueLinsten, string queueNextLinsten, string queueFail, string labelField = "", bool isCreateQueue = false)
        {
            QueueReceiver queueReceiver = new QueueReceiver(queueLinsten, isCreateQueue);

            Func<T, T2> func = act;

            queueReceiver.InitLimitTime<T, T2>(func, queueNextLinsten, queueFail, labelField);
            QueueManager.ListQueue.Add(queueReceiver);
        }

        private static List<QueueReceiver> listQueue;

        public static List<QueueReceiver> ListQueue
        {
            get
            {
                if (listQueue == null)
                {
                    listQueue = new List<QueueReceiver>();
                }
                return listQueue;
            }
        }

        public static void Start(string queueName = "")
        {
            if (string.IsNullOrWhiteSpace(queueName))
            {
                listQueue.ForEach(x =>
                {
                    if (!x.Islistener)
                    {
                        x.Islistener = true; x.Start();
                    }
                });
            }
            else
            {
                listQueue.Where(x => x.QueueName == queueName).ToList().ForEach(x =>
                {
                    if (!x.Islistener)
                    {
                        x.Islistener = true; x.Start();
                    }
                });
            }
        }

        public static void Stop(string queueName = "")
        {
            if (string.IsNullOrWhiteSpace(queueName))
            {
                listQueue.ForEach(x =>
                {
                    if (x.Islistener)
                    {
                        x.Islistener = false; x.Stop();
                    }
                });
            }
            else
            {
                listQueue.Where(x => x.QueueName == queueName).ToList().ForEach(x =>
                {
                    if (x.Islistener)
                    {
                        x.Islistener = false; x.Stop();
                    }
                });
            }
        }

        public static bool CheckConnect()
        {
            RabbitQueueCommonService rabbit = new RabbitQueueCommonService();
            return rabbit.CheckConnect();
        }
    }

    public delegate void MessageReceivedEventHandler(object sender, MessageEventArgs args);

    public class MessageEventArgs : EventArgs
    {
        private object _messageBody;

        public object MessageBody
        {
            get { return _messageBody; }
        }

        public MessageEventArgs(object body)
        {
            _messageBody = body;
        }
    }

    public class RabbitQueueCommonService
    {
        private static string _hostName = "192.168.10.21";
        private static string _userName = "root";
        private static string _password = "123456";

        public bool stopManual = false;

        public IConnection GetRabbitMqConnection(string queueName)
        {
            _hostName = Configuration.Config.GetAppSetting<string>("QueueServer");
            _userName = Configuration.Config.GetAppSetting<string>("QueueServerUserName");
            _password = Configuration.Config.GetAppSetting<string>("QueueServerPassword");

            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = _hostName;
            connectionFactory.UserName = _userName;
            connectionFactory.Password = _password;
            connectionFactory.RequestedHeartbeat = 10;

            return connectionFactory.CreateConnection(queueName);
        }

        public IConnection Connection(string queueName)
        {
            IConnection connection = GetRabbitMqConnection(queueName);
            connection.ConnectionShutdown += connection_ConnectionShutdown;
            return connection;
        }

        private void connection_ConnectionShutdown(object sender, ShutdownEventArgs e)
        {
            IConnection connection = (IConnection)sender;

            QueueReceiver queueReceiver = QueueManager.ListQueue.FirstOrDefault(x => x.QueueName + Configuration.Config.Environment() == connection.ClientProvidedName);

            if (queueReceiver != null && !queueReceiver.StopManual && !connection.IsOpen)
            {
                //T2P._2015.Cross.Utility.Log.Logging.Error(e.ToString());
                //T2P._2015.Cross.Utility.Network.Email email = new Network.Email();

                //string queueEmail = Configuration.Config.GetAppSetting<string>("QueueEmail");
                //if (string.IsNullOrWhiteSpace(queueEmail))
                //{
                //    queueEmail = "admin@travel2pay.com";
                //}

                //email.SendMailMessage("Queue " + connection.ClientProvidedName + " is stopped", e.ToString(), queueEmail);
                queueReceiver.Start();
            }
        }

        public bool CheckConnect()
        {
            try
            {
                _hostName = Configuration.Config.GetAppSetting<string>("QueueServer");
                _userName = Configuration.Config.GetAppSetting<string>("QueueServerUserName");
                _password = Configuration.Config.GetAppSetting<string>("QueueServerPassword");

                ConnectionFactory connectionFactory = new ConnectionFactory();
                connectionFactory.HostName = _hostName;
                connectionFactory.UserName = _userName;
                connectionFactory.Password = _password;
                connectionFactory.RequestedHeartbeat = 10;
                IConnection connect = connectionFactory.CreateConnection();
                connect.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class RabbitQueue
    {
        private EventingBasicConsumer consumer;
        public IConnection Connection;
        private IModel channel;
        public Type FommatType;

        public event MessageReceivedEventHandler MessageReceived;

        private RabbitQueueCommonService rabbitService;
        private string _queueName;

        public RabbitQueue(string queueName)
        {
            _queueName = queueName + Configuration.Config.Environment().ToString();
        }

        public void Listener()
        {
            if (Connection == null || !Connection.IsOpen)
            {
                Init();

                channel.QueueDeclare(queue: _queueName,
                                      durable: true,
                                      exclusive: false,
                                      autoDelete: false,
                                      arguments: null);
                channel.BasicQos(0, 1, false);
                consumer = new EventingBasicConsumer(channel);
                consumer.Received += new EventHandler<BasicDeliverEventArgs>(OnReceiveCompleted);
                channel.BasicConsume(queue: _queueName,
                                       noAck: false,
                                       consumer: consumer);
            }
        }

        public void StopListener()
        {
            consumer.Received -= new EventHandler<BasicDeliverEventArgs>(OnReceiveCompleted);

            Connection.Close();
        }

        public void SendMessage<T>(T obj)
        {
            Init();

            channel.QueueDeclare(queue: _queueName,
                                      durable: true,
                                      exclusive: false,
                                      autoDelete: false,
                                      arguments: null);

            var properties = channel.CreateBasicProperties();
            properties.SetPersistent(true);
            properties.DeliveryMode = 2;

            //String jsonified = new JavaScriptSerializer().Serialize(obj);

            String jsonified = JsonConvert.SerializeObject(obj);
            //String jsonified = FileType.XML.XMLToString(obj);

            byte[] customerBuffer = Encoding.UTF8.GetBytes(jsonified);

            channel.BasicPublish(exchange: "",
                                       routingKey: _queueName,
                                       basicProperties: properties,
                                       body: customerBuffer);
            Connection.Close();
        }

        private void Init()
        {
            //var factory = new ConnectionFactory() { HostName = "192.168.10.22", UserName = "root", Password = "123456" };
            //connection = factory.CreateConnection();
            RabbitQueueCommonService rabbitService = new RabbitQueueCommonService();
            Connection = rabbitService.Connection(_queueName);
            channel = Connection.CreateModel();
        }

        private int i = 0;

        private void OnReceiveCompleted(object sender, BasicDeliverEventArgs ea)
        {
            try
            {
                var message = Encoding.UTF8.GetString(ea.Body);
                //var obj = FileType.XML.DeserializeToXML(message, FommatType);
                //var obj = new JavaScriptSerializer().Deserialize(message, FommatType);
                var obj = JsonConvert.DeserializeObject(message, FommatType);
                FireRecieveEvent(obj);
                channel.BasicAck(ea.DeliveryTag, false);
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
            }
        }

        private void FireRecieveEvent(object body)
        {
            if (MessageReceived != null)
            {
                MessageReceived(this, new MessageEventArgs(body));
            }
        }
    }

    public class QueueReceiver
    {
        private RabbitQueue listener;
        private string _queueName;

        public string QueueName
        {
            get { return _queueName; }
        }

        public bool Islistener { get; set; }
        public bool StopManual = false;

        public QueueReceiver(string queueName, bool isCreateQueue = false)
        {
            _queueName = queueName;
            listener = new RabbitQueue(queueName);
        }

        private Action<object> action;

        public void Init<T>(Action<T> act, string pushFailQueue = "", string labelField = "")
        {
            action = new Action<object>((object obj) =>
            {
                try
                {
                    act.Invoke((T)obj);
                }
                catch (Exception ex)
                {
                    ExceptionHelper.GetDetailMessageAndLog(ex);
                    RabbitQueue sender = new RabbitQueue(pushFailQueue);
                    sender.SendMessage<T>((T)obj);
                }
            });
            listener.FommatType = typeof(T);
            listener.MessageReceived += MessageReceivedEvent;
            listener.Listener();
        }

        public void Init<T, T2>(Func<T, T2> act, string queueSuccessQueue, string queueFail, string labelField = "")
        {
            action = new Action<object>((object obj) =>
            {
                try
                {
                    T2 result = act.Invoke((T)obj);
                    RabbitQueue sender = new RabbitQueue(queueSuccessQueue);
                    sender.SendMessage<T2>((T2)result);
                }
                catch (Exception ex)
                {
                    ExceptionHelper.GetDetailMessageAndLog(ex);
                    RabbitQueue sender = new RabbitQueue(queueFail);
                    sender.SendMessage<T>((T)obj);
                }
            });

            listener.FommatType = typeof(T);
            listener.MessageReceived += MessageReceivedEvent;
            listener.Listener();
        }

        public void InitLimitTime<T, T2>(Func<T, T2> act, string queueSuccessQueue, string queueFail, string labelField = "")
        {
            action = new Action<object>((object obj) =>
            {
                try
                {
                    int LIMIT_SUGGEST_TIME = 90;

                    string errorReason = string.Empty;

                    Thread workerThread = new Thread(() =>
                    {
                        try
                        {
                            T2 result = act.Invoke((T)obj);
                            RabbitQueue sender = new RabbitQueue(queueSuccessQueue);
                            sender.SendMessage<T2>((T2)result);
                        }
                        catch (Exception ex)
                        {
                            T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                            ExceptionHelper.GetDetailMessageAndLog(ex);
                            RabbitQueue sender = new RabbitQueue(queueFail);
                            sender.SendMessage<T>((T)obj);
                        }
                        finally
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            GC.Collect();
                        }
                    });

                    workerThread.Start();
                    DateTime timeNow = DateTime.Now;
                    while (workerThread.IsAlive)
                    {
                        var countSeconds = DateTime.Now.Subtract(timeNow).TotalSeconds;
                        if (countSeconds >= LIMIT_SUGGEST_TIME)
                        {
                            T2P._2015.Cross.Utility.Log.Logging.Info("Time out:" + errorReason);
                            workerThread.Abort();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ExceptionHelper.GetDetailMessageAndLog(ex);
                    RabbitQueue sender = new RabbitQueue(queueFail);
                    sender.SendMessage<T>((T)obj);
                }
            });

            listener.FommatType = typeof(T);
            listener.MessageReceived += MessageReceivedEvent;
            listener.Listener();
        }

        private void MessageReceivedEvent(object sender, MessageEventArgs args)
        {
            action.Invoke(args.MessageBody);
        }

        public void Start()
        {
            StopManual = false;
            Thread t = new Thread(() => listener.Listener());
            t.Start();
        }

        public void Stop()
        {
            if (listener.Connection.IsOpen)
            {
                StopManual = true;
                listener.StopListener();
            }
        }

        public QueueConnectStatus ConnectStatus
        {
            get
            {
                if (listener.Connection != null)
                {
                    if (listener.Connection.IsOpen)
                    {
                        return QueueConnectStatus.Connect;
                    }
                    else
                    {
                        return QueueConnectStatus.Disconnect;
                    }
                }
                else
                {
                    return QueueConnectStatus.Ready;
                }
            }
        }
    }

    public enum QueueConnectStatus
    {
        Disconnect,
        Connect,
        Ready,
    }
}