using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class CustomChar
    {
        public int Index { get; set; }
        public int ParentIndex { get; set; }
        public string Value { get; set; }
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
        }
    }

    public class CustomWord : CustomChar
    {
        public List<CustomChar> CharItems { get; set; }
        public CustomWord()
        {
            CharItems = new List<CustomChar>();
        }
    }

    public class CustomLine : CustomWord
    {
        public List<CustomWord> WordItems { get; set; }
        public CustomLine()
        {
            WordItems = new List<CustomWord>();
        }
    }

    public class CustomBlock : CustomWord
    {
        public List<CustomLine> LineItems { get; set; }
        public CustomBlock()
        {
            LineItems = new List<CustomLine>();
        }
    }

    public class CustomRow : CustomWord
    {
        public List<CustomBlock> BlockItems { get; set; }
        public CustomRow()
        {
            BlockItems = new List<CustomBlock>();
        }
    }

    public class CustomTable : CustomWord
    {
        public List<CustomRow> RowItems { get; set; }
        public CustomTable()
        {
            RowItems = new List<CustomRow>();
        }
    }

    public class CustomPage
    {
        public int Index { get; set; }
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

    public class CustomFile
    {
        public long ImageId { get; set; }
        public List<CustomPage> PageItems { get; set; }
    }
}
