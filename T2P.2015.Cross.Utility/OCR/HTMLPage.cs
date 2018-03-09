using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.OCR
{
    public class HTMLPage
    {
        List<HTMLRow> listHTMLRow;

        public List<HTMLRow> ListHTMLRow
        {
            get { return listHTMLRow; }
            set { listHTMLRow = value; }
        }
        public HTMLPage()
        {
            listHTMLRow = new List<HTMLRow>();
        }
    }

    public class HTMLRow
    {
        private int _rowIndex;
        public int RowIndex
        {
            get { return _rowIndex; }
            set { _rowIndex = value; }
        }

        private decimal _rowPos;
        public decimal RowPos
        {
            get { return _rowPos; }
            set { _rowPos = value; }
        }


        private string row;
        public string RowData
        {
            get { return row; }
            set { row = value; }
        }

        private List<HTMLWord> listWord;
        public List<HTMLWord> ListWord
        {
            get { return listWord; }
            set { listWord = value; }
        }

        public HTMLRow()
        {
            ListWord = new List<HTMLWord>();
        }

    }

    public class HTMLWord : ICloneable
    {
        public decimal XPos;
        public decimal YPos;
        public decimal Width;
        public decimal Height;

        private int _wordIndex;
        public int WordIndex
        {
            get { return _wordIndex; }
            set { _wordIndex = value; }
        }

        private string _word;
        public string Word
        {
            get { return _word; }
            set { _word = value; }
        }

        public HTMLWord()
        {
            Word = string.Empty;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
