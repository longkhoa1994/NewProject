// © 2013 ABBYY Production LLC
// SAMPLES code is property of ABBYY, exclusive rights are reserved. 
//
// DEVELOPER is allowed to incorporate SAMPLES into his own APPLICATION and modify it under 
// the  terms of  License Agreement between  ABBYY and DEVELOPER.


// ABBYY FineReader Engine 11 Sample

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;


namespace T2P._2015.Cross.Utility.OCR.ABBYY
{
    [Serializable]
    public class Character
    {
        public Character(char ch, FREngine.CharParams charParams)
        {
            _ch = ch;
            _isSuspicious = charParams.IsSuspicious;

            _rect = System.Drawing.Rectangle.FromLTRB(charParams.Left, charParams.Top,
                charParams.Right, charParams.Bottom);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public char Value { get { return _ch; } }
        public bool IsSuspicious { get { return _isSuspicious; } }
        public System.Drawing.Rectangle Rect { get { return _rect; } }

        private readonly char _ch;
        private readonly bool _isSuspicious;
        private System.Drawing.Rectangle _rect;
    }
    [Serializable]
    public class Word
    {
        // Create word of chars [startIndex..endIndex] in RecognizedText.Text 
        public Word(int startIndex, int endIndex, List<Character> Text)
        {
            StringBuilder text = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                text.Append(Text[i].Value);
            }

            _text = text.ToString();
            _startIndex = startIndex;
            _endIndex = endIndex;
        }

        public int StartIndex { get { return _startIndex; } }
        public int EndIndex { get { return _endIndex; } }

        public override string ToString()
        {
            return _text;
        }

        private readonly string _text;
        // Index of first word character in RecognizedText.Text
        private readonly int _startIndex;
        // Index of last word character in RecognizedText.Text
        private readonly int _endIndex;
    }


    // Class that contains recognized text and its geometrical data
    public class RecognizedText
    {
        public CustomPage Page { get; set; }

        public int index { get; set; }


        private List<CustomLine> lineAll;
        private List<CustomWord> listWords;

        private int tableIndex;

        // Build text using recognized layout
        public RecognizedText(FREngine.IFRPage frPage, int pageIndex)
        {
            Text = new List<Character>();
            words = new List<Word>();

            FREngine.ILayoutBlocks blocks = frPage.Layout.Blocks;

            lineAll = new List<CustomLine>();
            listWords = new List<CustomWord>();
            Page = new CustomPage();


            Page.Index = pageIndex;
            tableIndex = 0;
            for (int iBlock = 0; iBlock < blocks.Count; iBlock++)
            {
                FREngine.IBlock block = blocks[iBlock];

                CustomBlock csBlock = buildTextFromBlock(block, iBlock);
               
                if (csBlock != null)
                {
                    csBlock.ParentIndex = pageIndex;
                    Page.BlockItems.Add(csBlock);
                }

            }


            ProcessLine();




        }


        public void ProcessLine()
        {
            List<Tuple<List<CustomWord>, System.Drawing.Rectangle>> lookupList = listWords.Select(x => new Tuple<List<CustomWord>, System.Drawing.Rectangle>(new List<CustomWord>() { x }, new System.Drawing.Rectangle(0, x.Y, x.Width, x.Height))).OrderBy(x => x.Item2.Y).ToList();

            List<Tuple<List<CustomWord>, System.Drawing.Rectangle>> listLine = new List<Tuple<List<CustomWord>, System.Drawing.Rectangle>>();

            while (lookupList.Any())
            {
                Tuple<List<CustomWord>, System.Drawing.Rectangle> word = lookupList.First();

                if (!listLine.Any())
                {
                    listLine.Add(word);
                }
                else
                {
                    Tuple<List<CustomWord>, System.Drawing.Rectangle> lastLine = listLine.Last();
                    if (word.Item2.IntersectsWith(lastLine.Item2) || lastLine.Item2.Y + lastLine.Item2.Height == word.Item2.Y)
                    {
                        lastLine.Item1.AddRange(word.Item1);
                    }
                    else
                    {
                        listLine.Add(word);
                    }
                }

                lookupList.Remove(word);
            }
            int iLine = 0;
            foreach (var item in listLine)
            {
                int minX = item.Item1.Min(x => x.X);
                int minY = item.Item1.Min(x => x.Y);
                int maxX = item.Item1.Max(x => x.X);
                int MaxY = item.Item1.Max(x => x.Y);
                int maxXYZ = item.Item1.Max(x => x.Y + x.Height);
                int iWords = 0;
                CustomLine csLine = new CustomLine()
                {
                    X = minX,
                    Y = minY,
                    Width = maxX + item.Item1.Last(x => x.X == maxX).Width - minX,
                    WordItems = item.Item1.OrderBy(x => x.X).Select(x => { x.Index = iWords; x.ParentIndex = iLine; iWords++; return x; }).ToList(),
                    Height = maxXYZ - minY,
                    Index = iLine,
                    ParentIndex = Page.Index,
                    Value = string.Join(" ", item.Item1.OrderBy(x => x.X).Select(x => x.Value)),
                    ValueWithoutSpace = string.Join("", item.Item1.OrderBy(x => x.X).Select(x => x.Value)), 
                };
                Page.LineItems.Add(csLine);
                iLine++;
            }



        }


        public void WriteXML(string fileName)
        {
            WriteXML2<CustomPage>(Page, fileName);
        }

        public static T Clone<T>(T obj)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    formatter.Serialize(ms, obj);
                    ms.Position = 0;

                    return (T)formatter.Deserialize(ms);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string SerializeToString<T>(T obj, bool omitXmlDeclaration = false)
        {
            Type type = obj.GetType();
            DataContractSerializer dcSer = new DataContractSerializer(type);
            StringBuilder xmlString = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = omitXmlDeclaration;

            XmlWriter writer = XmlWriter.Create(xmlString, settings);
            dcSer.WriteObject(writer, obj);
            writer.Close();

            return xmlString.ToString();
        }

        public static void WriteXML2<T>(T obj, string fileName)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(fileName)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                }


                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
                writer.Serialize(file, obj);
                file.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static void WriteXML<T>(T obj, string fileName)
        {
            try
            {
                string xml = SerializeToString(obj);
                StreamWriter sw = new StreamWriter(fileName, false);
                sw.Write(xml);
                sw.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private CustomBlock buildTextFromBlock(FREngine.IBlock block, int iBlock)
        {
            if (block.Type == FREngine.BlockTypeEnum.BT_Table)
            {
                FREngine.ITableBlock tableBlock = block.GetAsTableBlock();

                CustomTable cstable = new CustomTable();

                cstable.X = tableBlock.Region.BoundingRectangle.Left;
                cstable.Y = tableBlock.Region.BoundingRectangle.Top;
                cstable.Width = tableBlock.Region.BoundingRectangle.Width;
                cstable.Height = tableBlock.Region.BoundingRectangle.Height;
                cstable.ParentIndex = Page.Index;
                cstable.Index = tableIndex;
                tableIndex++;

                List<CustomBlock> blockItems = new List<CustomBlock>();

                for (int iCell = 0; iCell < tableBlock.Cells.Count; iCell++)
                {
                    FREngine.ITableCell cell = tableBlock.Cells[iCell];
                    CustomBlock csBlock = buildTextFromBlock(cell.Block, iCell);
                    if (csBlock != null)
                    {
                        blockItems.Add(csBlock);
                        //blockAll.Add(csBlock);
                    }
                }
                var rowItemsGroup = blockItems.GroupBy(x => x.Y);

                int iRow = 0;
                foreach (var item in rowItemsGroup)
                {
                    CustomRow rowItem = new CustomRow()
                    {

                        Width = cstable.Width,
                        Height = item.Max(x => x.Height),
                        BlockItems = item.ToList(),
                        X = item.Min(x => x.X),
                        Y = item.Min(x => x.Y),
                        Value = string.Join("\t", item.Select(x => x.Value)),
                        Index = iRow,
                        ParentIndex = iBlock,
                    };
                    cstable.RowItems.Add(rowItem);
                    iRow++;
                }



                cstable.Value = string.Join("\n", cstable.RowItems.Select(x => x.Value)); ;//
                //string.Join("|", cstable.BlockItems.Select(x => x.Value));
                Page.TableItems.Add(cstable);
                return null;
            }

            if (block.Type != FREngine.BlockTypeEnum.BT_Text)
            {
                return null;
            }

            CustomBlock result = new CustomBlock();

            FREngine.ITextBlock textBlock = block.GetAsTextBlock();

            result.Index = iBlock;
            result.X = textBlock.Region.BoundingRectangle.Left;
            result.Y = textBlock.Region.BoundingRectangle.Top;
            result.Width = textBlock.Region.BoundingRectangle.Width;
            result.Height = textBlock.Region.BoundingRectangle.Height;


            for (int iPar = 0; iPar < textBlock.Text.Paragraphs.Count; iPar++)
            {
                FREngine.IParagraph par = textBlock.Text.Paragraphs[iPar];
                result.LineItems.AddRange(buildTextFromParagraph(par, iBlock));
            }

            result.Value = string.Join("\n", result.LineItems.Select(x => x.Value));

            return result;


        }

        private List<CustomLine> buildTextFromParagraph(FREngine.IParagraph par, int iBlock)
        {
            // CustomParagraph result = new CustomParagraph();

            List<CustomWord> wordItems = new List<CustomWord>();


            string text = par.Text;
            FREngine.CharParams charParams = par.Application.CreateCharParams();

            int wordStart = 0;
            int wordStartInText = Text.Count;
            List<Character> charaterItems = new List<Character>();
            for (int iChar = 0; iChar < text.Length; iChar++)
            {
                char ch = text[iChar];
                par.GetCharParams(iChar, charParams);

                bool isVisible = (!char.IsWhiteSpace(ch));
                if (isVisible)
                {
                    Text.Add(new Character(ch, charParams));
                    charaterItems.Add(new Character(ch, charParams));
                }

                // Splitting words by whitespaces
                // TODO: line break, hyphen
                if (char.IsWhiteSpace(ch))
                {
                    if (wordStart < iChar)
                    {
                        int wordEndInText = Text.Count - 1;
                        words.Add(new Word(wordStartInText, wordEndInText, Text));

                        CustomWord word = new CustomWord();
                        //word.Word = new Word(wordStartInText, wordEndInText, Text);
                        word.X = charaterItems.Min(x => x.Rect.X);
                        word.Y = charaterItems.Min(x => x.Rect.Y);
                        word.Value = new Word(wordStartInText, wordEndInText, Text).ToString();

                        int xMax = charaterItems.Max(x => x.Rect.X);
                        word.Width = xMax + charaterItems.First(x => x.Rect.X == xMax).Rect.Width - word.X;
                        word.Height = charaterItems.Max(x => x.Rect.Height);

                        //word.CharaterItems = charaterItems;
                        wordItems.Add(word);

                        listWords.Add(word);
                        charaterItems = new List<Character>();
                    }

                    wordStart = iChar + 1;
                    wordStartInText = Text.Count;
                }
            }

            // Add last word if necessary
            if (wordStart < text.Length)
            {
                int wordEndInText = Text.Count - 1;
                words.Add(new Word(wordStartInText, wordEndInText, Text));
                CustomWord word = new CustomWord();
                //word.Word = new Word(wordStartInText, wordEndInText, Text);
                //word.CharaterItems = charaterItems;
                word.Value = new Word(wordStartInText, wordEndInText, Text).ToString();
                word.X = charaterItems.Min(x => x.Rect.X);
                word.Y = charaterItems.Min(x => x.Rect.Y);
                int xMax = charaterItems.Max(x => x.Rect.X);
                word.Width = xMax + charaterItems.First(x => x.Rect.X == xMax).Rect.Width - word.X;
                word.Height = charaterItems.Max(x => x.Rect.Height);


                wordItems.Add(word);
                listWords.Add(word);
                charaterItems = new List<Character>();
            }
            List<CustomLine> csLineItems = new List<CustomLine>();

            //if (result.WordItems.Any())
            //{
            //    CustomLine line = new CustomLine()

            //        {
            //            X = par.Left,
            //            Y = par.Top,
            //            Width = par.Right - par.Left,
            //            Height = par.Bottom - par.Top,
            //            WordItems = result.WordItems,
            //            Index = 0,
            //            ParentBlockIndex = iBlock,
            //            Value = string.Join(" ", result.WordItems.Select(x => x.Word.ToString()).ToArray())
            //        }
            //        ;





            //    csLineItems.Add(line);
            //    lineAll.Add(line);

            //}


            FREngine.IParagraphLines lines = par.Lines;




            if (wordItems.Any())
            {

                int iLine = 0;
                foreach (FREngine.IParagraphLine item in lines)
                {
                    CustomLine lineItem = new CustomLine()
                    {
                        X = item.Left,
                        Y = item.Top,
                        Height = item.Bottom - item.Top,
                        Width = item.Right - item.Left,
                        ParentIndex = 0,
                        Index = iLine,
                    };
                    int iWords = 0;
                    lineItem.WordItems = wordItems.Where(x => IsCollucion(lineItem, x)).Select(x => { x.Index = iWords; iWords++; x.ParentIndex = iLine; return x; }).ToList();
                    lineItem.Value = string.Join(" ", lineItem.WordItems.OrderBy(x => x.X).Select(x => x.Value));
                    lineItem.ValueWithoutSpace = string.Join("", lineItem.WordItems.OrderBy(x => x.X).Select(x => x.Value));

                    csLineItems.Add(lineItem);
                    lineAll.Add(lineItem);
                    iLine++;
                }
            }




            return csLineItems.OrderBy(x => x.Index).ToList();
        }


        bool IsCollucion(CustomLine line, CustomWord word)
        {
            if (word.X >= line.X && (word.X <= line.X + line.Width) && word.Y >= line.Y && word.Y <= line.Y + line.Height)
            {
                return true;
            }
            //if (word.X >= line.X && (word.X <= line.X + line.Width) && word.Y >= line.Y && word.Y <= line.Y + line.Height && word.X + word.Width < line.X + line.Width)
            //{
            //    return true;
            //}
            return false;
        }
        // Get word by coordinates
        // If no word with given coordinates, null is returned
        public Word WordAtXY(int x, int y)
        {
            foreach (Word w in words)
            {
                for (int i = w.StartIndex; i <= w.EndIndex; i++)
                {
                    Character ch = Text[i];
                    if (ch.Rect.Contains(x, y))
                    {
                        return w;
                    }
                }
            }

            return null;
        }

        public List<Character> Text;
        private List<Word> words;
    }
}
