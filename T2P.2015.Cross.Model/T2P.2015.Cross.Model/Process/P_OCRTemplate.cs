using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_OCRTemplate : O_Page
    {
        private List<P_OCRZone> listZone;

        public List<P_OCRZone> ListZone
        {
            get { return listZone; }
            set { listZone = value; }
        }

        private List<P_Suggestion> listSuggestion;

        public List<P_Suggestion> ListSuggestion
        {
            get { return listSuggestion; }
            set { listSuggestion = value; }
        }

        List<DateTime> listDateOCR;

        public List<DateTime> ListDateOCR
        {
            get { return listDateOCR; }
            set { listDateOCR = value; }
        }


        public P_OCRTemplate()
        {
            ListZone = new List<P_OCRZone>();
            ListSuggestion = new List<P_Suggestion>();
            ListDateOCR = new List<DateTime>();
        }
    }

    public class P_OCRZone : O_PageDetail
    {
        private List<P_RowPage> listRow;

        public List<P_RowPage> ListRow
        {
            get { return listRow; }
            set { listRow = value; }
        }

        public P_OCRZone()
        {
            ListRow = new List<P_RowPage>();
        }
    }

    public class P_Suggestion : O_Suggestion
    {

        private O_SuggestHeader header;

        public O_SuggestHeader Header
        {
            get { return header; }
            set { header = value; }
        }

        private List<O_SuggestPosition> listPostition;

        public List<O_SuggestPosition> ListPostition
        {
            get { return listPostition; }
            set { listPostition = value; }
        }

        private List<O_SuggestTax> listTax;

        public List<O_SuggestTax> ListTax
        {
            get { return listTax; }
            set { listTax = value; }
        }

            public P_Suggestion()
        {
            ListPostition = new List<O_SuggestPosition>();
            ListTax = new List<O_SuggestTax>();
        }
    }

    public class P_Template : M_HotelTemplate
    {

        private List<M_HotelTemplateZone> listZone;

        public List<M_HotelTemplateZone> ListZone
        {
            get { return listZone; }
            set { listZone = value; }
        }

        public P_Template()
        {
            ListZone = new List<M_HotelTemplateZone>();
        }
    }
}
