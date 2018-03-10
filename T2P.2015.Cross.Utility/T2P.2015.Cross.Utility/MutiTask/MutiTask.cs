using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.MutiTask
{
    public class MutiTask
    {
        int taskNumber;

        public int TaskNumber
        {
            get { return taskNumber; }
            set { taskNumber = value; }
        }
        int takeNumer;

        public int TakeNumer
        {
            get { return takeNumer; }
            set { takeNumer = value; }
        }

        public MutiTask(int taskNumber, int takeNumer)
        {
            this.TaskNumber = taskNumber;
            this.TakeNumer = takeNumer;
        }

        public List<TResult> RunMutiTaskList<T, TResult>(List<T> listT, long userID, Func<List<T>, long, TResult> func)
        {
            List<TResult> result = new List<TResult>();
            while (listT.Count > 0)
            {
                List<Task> listTask = new List<Task>();
                for (int i = 0; i < taskNumber; i++)
                {
                    List<T> itemProcess = TakeItem<T>(listT, takeNumer);
                    Task itemTask = new Task(() => result.Add(func.Invoke(itemProcess, userID)));
                    listTask.Add(itemTask);
                    itemTask.Start();
                }
                listTask.ForEach(x => { x.Wait(); });
            }
            return result;
        }
        private List<T> TakeItem<T>(List<T> listT, int takeNumer)
        {
            List<T> result = new List<T>();
            if (listT.Count > 0)
            {
                result = listT.Take(takeNumer).ToList();
                result.ForEach(x => listT.Remove(x));
            }
            return result;
        }
    }


}
