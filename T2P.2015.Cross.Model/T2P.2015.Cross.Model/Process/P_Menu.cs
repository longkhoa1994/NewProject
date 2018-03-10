using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Menu
    {
        private string _objectName;

        public string ObjectName
        {
            get { return _objectName; }
            set { _objectName = value; }
        }

        private string _controllerName;

        public string ControllerName
        {
            get { return _controllerName; }
            set { _controllerName = value; }
        }

        private string _actionName;

        public string ActionName
        {
            get { return _actionName; }
            set { _actionName = value; }
        }

        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        private string _parentName;

        public string ParentName
        {
            get { return _parentName; }
            set { _parentName = value; }
        }
    }

    public enum P_MenuProcedure
    {
        p_P_Menu_GetData,
    }
}
