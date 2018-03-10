using CsQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.FileType
{
    public class Html
    {
        CQ dom;
        public Html(string htmlContent)
        {
            dom = CQ.Create(htmlContent);
        }
        public T GetByDom<T>(string element)
        {
            Type type = typeof(T);
            return Conversion.Conversion.Parse<T>(type, RemoveNewlineChar(dom[element].First().Text()));

        }
        public T GetByDom<T>(string element, int index)
        {
            Type type = typeof(T);
            return Conversion.Conversion.Parse<T>(type, dom[element][index].Cq().Text());

        }

        public T GetAttribute<T>(string element, string attribute)
        {
            Type type = typeof(T);
            return Conversion.Conversion.Parse<T>(type, dom[element].Select(attr => attr.GetAttribute(attribute)).First());
        }

        public List<string> GetServices(string element)
        {
            List<string> result = new List<string>();
            CQ serviceFees = dom[element];
            for (int i = 0; i < serviceFees.Count(); i++)
            {
                CQ item = serviceFees[i].Cq();

                if (item.Parent().HasClass("receipt-panel-body-padding"))
                {
                    result.Add(item.Text());
                }
            } 
            return result;
        }

        private string RemoveNewlineChar(string source) 
        {
            string result;
            result = source.Replace("\n", string.Empty);
            return result;
        }
    }
}
