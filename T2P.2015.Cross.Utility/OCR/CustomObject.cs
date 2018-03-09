using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Utility.OCR
{
    [Serializable]
    public class CustomChar
    {
        public int Index { get; set; }
        public int ParentIndex { get; set; }
        public string Value { get; set; }
        public string ValueWithoutSpace { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public CustomChar()
        {
            Index = 0;
            X = 0;
            Y = 0;
            Width = 0;
            Height = 0;
            Value = string.Empty;
            ValueWithoutSpace = string.Empty;
        }
    }

    [Serializable]
    public class CustomWord : CustomChar
    {
        public int IndexDestiny { get; set; }

        public List<CustomChar> CharItems { get; set; }
        public CustomWord()
        {
            IndexDestiny = Index;
            CharItems = new List<CustomChar>();
        }
        public CustomWord(System.Drawing.Rectangle rectangle)
        {
            IndexDestiny = Index;
            CharItems = new List<CustomChar>();
            this.X = rectangle.X;
            this.Y = rectangle.Y;
            this.Width = rectangle.Width;
            this.Height = rectangle.Height;
        }

        public System.Drawing.Rectangle GetCoordinates()
        {
            return new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);
        }
    }

    public enum OcrType
    {
        Original,
        BW,
        PP,
        PDF,
        Abby
    }

    [Serializable]
    public class CustomLine : CustomWord
    {
        public OcrType OcrType { get; set; }
        public List<CustomWord> WordItems { get; set; }
        public CustomLine()
        {
            WordItems = new List<CustomWord>();
            OcrType = OcrType.Original;
        }
    }

    [Serializable]
    public class CustomBlock : CustomWord
    {
        public List<CustomLine> LineItems { get; set; }
        public CustomBlock()
        {
            LineItems = new List<CustomLine>();
        }
    }

    [Serializable]
    public class CustomRow : CustomWord
    {
        public List<CustomBlock> BlockItems { get; set; }
        public CustomRow()
        {
            BlockItems = new List<CustomBlock>();
        }
    }

    [Serializable]
    public class CustomTable : CustomWord
    {
        public List<CustomRow> RowItems { get; set; }
        public CustomTable()
        {
            RowItems = new List<CustomRow>();
        }
    }

    [Serializable]
    public class CustomPage
    {
        public int Index { get; set; }
        public string Value { get; set; }

        public List<CustomLine> LineItems { get; set; }
        public List<CustomBlock> BlockItems { get; set; }
        public List<CustomTable> TableItems { get; set; }

        public CustomPage()
        {
            Index = 0;
            LineItems = new List<CustomLine>();
            BlockItems = new List<CustomBlock>();
            TableItems = new List<CustomTable>();
        }
    }

    [Serializable]
    public class CustomFile
    {
        public List<CustomPage> PageItems { get; set; }

        public CustomFile()
        {
            PageItems = new List<CustomPage>();
        }
    }
}
