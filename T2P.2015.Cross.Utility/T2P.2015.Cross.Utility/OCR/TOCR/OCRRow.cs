using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.OCR
{
    public class OCRPage
    {
        List<OCRRow> listOCRRow;

        public List<OCRRow> ListOCRRow
        {
            get { return listOCRRow; }
            set { listOCRRow = value; }
        }
        public OCRPage()
        {
            listOCRRow = new List<OCRRow>();
        }
    }
    [Serializable]
    public class OCRRow
    {
        private int postions;

        public int Position
        {
            get { return postions; }
            set { postions = value; }
        }

        private string row;
        public string Row
        {
            get { return row; }
            set { row = value; }
        }
        private string correctRow;

        public string CorrectRow
        {
            get { return correctRow; }
            set { correctRow = value; }
        }
        private List<WordInfo> listWord;

        public List<WordInfo> ListWord
        {
            get { return listWord; }
            set { listWord = value; }
        }
        public float Confidence;

        public OCRRow()
        {
            ListWord = new List<WordInfo>();
        }

    }
    [Serializable]
    public class WordInfo
    {
        private string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }private string correctWord;

        public string CorrectWord
        {
            get { return correctWord; }
            set { correctWord = value; }
        }

        private List<Character> listCharter;

        public List<Character> ListCharacter
        {
            get { return listCharter; }
            set { listCharter = value; }
        }
        public float Confidence;
        public int XPos;
        public int YPos;
        public int Width;
        public int Height;

        public WordInfo()
        {
            Word = string.Empty;
            ListCharacter = new List<Character>();
        }
    }
    [Serializable]
    public class Character
    {
        public string Value;
        public float Confidence;
        public int XPos;
        public int YPos;
        public int XDim;
        public int YDim;
    }
}
