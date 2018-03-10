using Gnostice.Graphics;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;

namespace T2P._2015.Cross.Utility.FileType
{
    public class Excel
    {

        public bool Create<T>(string inputTemplate, string outputFilename, List<ExcelSheet> listSheet)
        {
            string directory = Path.GetDirectoryName(outputFilename);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (ExcelPackage excelPkg = new ExcelPackage())
            using (FileStream stream = new FileStream(inputTemplate, FileMode.Open))
            {
                excelPkg.Load(stream);

                foreach (ExcelSheet sheet in listSheet)
                {
                    ExcelWorksheet oSheet = excelPkg.Workbook.Worksheets[sheet.SheetName];

                    foreach (ExcelAdditionData addition in sheet.ListAddition)
                    {
                        oSheet.Cells[addition.Column].Value = addition.Value;
                    }

                    int rowIndex = 0;

                    // insert rows
                    oSheet.InsertRow(sheet.BeginRow, sheet.ListData.Count);


                    var listData = new List<T>();
                    foreach (var item in sheet.ListData)
                    {
                        //add index column
                        if (sheet.IndexColum != null)
                        {
                            ExcelRange _no = oSheet.Cells[sheet.IndexColum.Column + (sheet.BeginRow + rowIndex).ToString()];
                            _no.Value = (rowIndex + 1).ToString();
                            SetStyle(sheet.IndexColum, _no);
                        }

                        Type type = typeof(T);
                        var cellData = (T)item;
                        foreach (ExcelCellData mapping in sheet.ListColumnsMapping)
                        {
                            ExcelRange currentCell = oSheet.Cells[mapping.Column + (sheet.BeginRow + rowIndex).ToString()];
                            if (mapping.FixedValue != null)
                            {
                                currentCell.Value = mapping.FixedValue;
                            }
                            else
                            {
                                currentCell.Value = type.GetProperty(mapping.DataName).GetValue(item);
                            }
                            SetStyle(mapping, currentCell);
                        }

                        listData.Add(cellData);

                        rowIndex++;
                    }

                    var listSummary = sheet.ListColumnsMapping.Where(m => m.HaveSummary);

                    foreach (var item in listSummary)
                    {
                        ExcelRange currentCell = oSheet.Cells[item.Column + (sheet.BeginRow + rowIndex)];
                        currentCell.Value = listData.Sum(c => Utility.Conversion.Conversion.ObjectToFloat(c.GetType().GetProperty(item.DataName).GetValue(c, null)));
                        currentCell.Style.Font.Bold = true;
                        currentCell.Style.Font.Size = 13f;
                    }

                }

                Byte[] content = excelPkg.GetAsByteArray();
                File.WriteAllBytes(outputFilename, content);

                return File.Exists(outputFilename);
            }
        }

        // Non-reusable
        public bool CreateExcelFileWithCombineField<T>(string inputTemplate, string outputFilename, List<ExcelSheet> listSheet)
        {
            string directory = Path.GetDirectoryName(outputFilename);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (ExcelPackage excelPkg = new ExcelPackage())
            using (FileStream stream = new FileStream(inputTemplate, FileMode.Open))
            {
                excelPkg.Load(stream);

                foreach (ExcelSheet sheet in listSheet)
                {
                    ExcelWorksheet oSheet = excelPkg.Workbook.Worksheets[sheet.SheetName];

                    foreach (ExcelAdditionData addition in sheet.ListAddition)
                    {
                        oSheet.Cells[addition.Column].Value = addition.Value;
                    }

                    int rowIndex = 0;

                    // insert rows
                    oSheet.InsertRow(sheet.BeginRow, sheet.ListData.Count);


                    var listData = new List<T>();
                    foreach (var item in sheet.ListData)
                    {
                        //add index column
                        if (sheet.IndexColum != null)
                        {
                            ExcelRange _no = oSheet.Cells[sheet.IndexColum.Column + (sheet.BeginRow + rowIndex).ToString()];
                            _no.Value = (rowIndex + 1).ToString();
                            SetStyle(sheet.IndexColum, _no);
                        }

                        Type type = typeof(T);
                        var cellData = (T)item;
                        foreach (ExcelCellData mapping in sheet.ListColumnsMapping)
                        {
                            ExcelRange currentCell = oSheet.Cells[mapping.Column + (sheet.BeginRow + rowIndex).ToString()];

                           
                            if (mapping.FixedValue != null)
                            {
                                currentCell.Value = mapping.FixedValue;
                            }
                            else
                            {   
                                var listValues = mapping.ListDataNames.Select(x => type.GetProperty(x).GetValue(item)).ToList();
                                if(listValues.Any())
                                {
                                    if(listValues.Count == 1)
                                    {
                                        var currValue = listValues.First();
                                        var currStyle = mapping.ListExcelStyle.First();
                                        var valueContent = string.Empty;
                                        if (currValue != null)
                                            valueContent = currValue.ToString();
                                        currentCell.Value = valueContent;
                                        currentCell.Style.Font.Name = currStyle.FontName;
                                        currentCell.Style.Font.Size = currStyle.FontSize;
                                        currentCell.Style.Font.Bold = currStyle.IsBold;
                                        currentCell.Style.Font.Italic = currStyle.IsItalic;
                                    }
                                    else
                                    {
                                        currentCell.IsRichText = true;
                                        var styleIndex = 0;
                                        var numOfValue = listValues.Count(x => x != null && !string.IsNullOrWhiteSpace(x.ToString()));
                                        foreach (var value in listValues)
                                        {
                                            var valueContent = string.Empty;
                                            if (value != null)
                                                valueContent = value.ToString();
                                            if (valueContent.ToString() == "0")
                                                continue;
                                            var currentRichText = currentCell.RichText.Add(valueContent);
                                            var currentStyle = mapping.ListExcelStyle[styleIndex];

                                            if (listValues.Last().ToString() != string.Empty)
                                            {
                                                currentRichText.Color = currentStyle.Color;
                                            }
                                            else
                                            {
                                                currentRichText.Color = System.Drawing.Color.Black;
                                            }
                                            currentRichText.Italic = currentStyle.IsItalic;
                                            currentRichText.Bold = currentStyle.IsBold;
                                            currentRichText.FontName = currentStyle.FontName;
                                            if (currentStyle.FontSize > 0)
                                            {
                                                currentRichText.Size = currentStyle.FontSize;
                                            }

                                            styleIndex++;
                                            if (styleIndex < numOfValue && numOfValue > 1 && listValues.Last().ToString() != "0")
                                            {
                                                var seperate = currentCell.RichText.Add(mapping.SeperateCharacter);
                                                seperate.Color = System.Drawing.Color.Black;
                                            }
                                        }
                                    }
                                }
                            }
                            switch (mapping.CellStyle.Align)
                            {
                                case AlignType.Right:
                                    currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                                    break;
                                case AlignType.Center:
                                    currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                                    break;
                                default:
                                    currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                    break;
                            }
                        }

                        listData.Add(cellData);

                        rowIndex++;
                    }
                }

                Byte[] content = excelPkg.GetAsByteArray();
                File.WriteAllBytes(outputFilename, content);

                return File.Exists(outputFilename);
            }
        }

        public bool CreateMulti(string inputTemplate, string outputFilename, List<ExcelSheet> listSheet)
        {
            try
            {
                string directory = Path.GetDirectoryName(outputFilename);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (ExcelPackage excelPkg = new ExcelPackage())
                using (FileStream stream = new FileStream(inputTemplate, FileMode.Open))
                {
                    excelPkg.Load(stream);

                    foreach (ExcelSheet sheet in listSheet)
                    {
                        ExcelWorksheet oSheet = excelPkg.Workbook.Worksheets[sheet.SheetName];

                        foreach (ExcelAdditionData addition in sheet.ListAddition)
                        {
                            oSheet.Cells[addition.Column].Value = addition.Value;
                        }

                        int rowIndex = 0;

                        // insert rows
                        oSheet.InsertRow(sheet.BeginRow, sheet.ListData.Count);


                        var listType = typeof(List<>).MakeGenericType(sheet.DataType);
                        IList listData = (IList)Activator.CreateInstance(listType);



                        foreach (var item in sheet.ListData)
                        {
                            //add index column
                            if (sheet.IndexColum != null)
                            {
                                ExcelRange _no = oSheet.Cells[sheet.IndexColum.Column + (sheet.BeginRow + rowIndex).ToString()];
                                _no.Value = (rowIndex + 1).ToString();
                                SetStyle(sheet.IndexColum, _no);
                            }

                            var cellData = Convert.ChangeType(item, sheet.DataType);
                            foreach (ExcelCellData mapping in sheet.ListColumnsMapping)
                            {
                                ExcelRange currentCell = oSheet.Cells[mapping.Column + (sheet.BeginRow + rowIndex).ToString()];
                                if (mapping.FixedValue != null)
                                {
                                    currentCell.Value = mapping.FixedValue;
                                }
                                else
                                {
                                    currentCell.Value = sheet.DataType.GetProperty(mapping.DataName).GetValue(item);
                                }
                                SetStyle(mapping, currentCell);
                            }

                            //listData.Add(cellData);

                            listData.Add(cellData);

                            rowIndex++;
                        }

                        var listSummary = sheet.ListColumnsMapping.Where(m => m.HaveSummary);

                        foreach (var item in listSummary)
                        {
                            ExcelRange currentCell = oSheet.Cells[item.Column + (sheet.BeginRow + rowIndex)];
                            //currentCell.Value = listData.Sum(c => Utility.Conversion.Conversion.ObjectToFloat(c.GetType().GetProperty(item.DataName).GetValue(c, null)));

                            float sum = 0;

                            foreach (var data in listData)
                            {
                                sum += Utility.Conversion.Conversion.ObjectToFloat(data.GetType().GetProperty(item.DataName).GetValue(data, null));
                            }

                            currentCell.Value = sum;
                            currentCell.Style.Font.Bold = true;
                            currentCell.Style.Font.Size = 13f;
                        }

                    }

                    Byte[] content = excelPkg.GetAsByteArray();
                    File.WriteAllBytes(outputFilename, content);

                    return File.Exists(outputFilename);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CreateImportDataReport(string inputFile, int rowStartRead, string outputFile, int startRowInsert, string outputTemplate, List<List<string>> listAddtions, string worksheetName)
        {
            FileStream streamTemplate = null;
            FileStream streamInput = null;
            try
            {
                string directory = Path.GetDirectoryName(outputFile);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var datasetReader = ImportExcelXLS(inputFile, true);
                var dataTableReader = datasetReader.Tables[0];
                streamTemplate = new FileStream(outputTemplate, FileMode.Open);

                var numOfRow = dataTableReader.Rows.Count;
                var numOfColumn = dataTableReader.Columns.Count;

                
                var excelPkgWriter = new ExcelPackage();
                excelPkgWriter.Load(streamTemplate);
                var worksheetWriter = excelPkgWriter.Workbook.Worksheets.FirstOrDefault();
                worksheetWriter.Name = worksheetName;
                //worksheetWriter.InsertRow(startRowInsert, numOfRow);
                var numOfInserted = 0;
                for (var iRow = rowStartRead; iRow < numOfRow; iRow ++)
                {
                    var isSkip = false;
                    for (var iAddition = 0; iAddition < listAddtions.Count; iAddition++)
                    {
                        var listLocationAddtions = listAddtions[iAddition];
                        if(iRow - rowStartRead >= listLocationAddtions.Count)
                        {
                            isSkip = true;
                            break;
                        }
                        var additionValue = listLocationAddtions[iRow - rowStartRead];
                        if(additionValue.Equals("OK", StringComparison.CurrentCultureIgnoreCase))
                        {
                            isSkip = true;
                            break;
                        }

                        worksheetWriter.SetValue(startRowInsert + numOfInserted, numOfColumn + 1 + iAddition, additionValue);
                    }
                    if (isSkip)
                        continue;
                    for (var iColumn = 1;iColumn <= numOfColumn;iColumn++)
                    {
                        var value = GetValueFromDataset(dataTableReader, iColumn - 1, iRow);
                        if(value is DateTime)
                            worksheetWriter.Cells[startRowInsert + numOfInserted, iColumn].Style.Numberformat.Format = "dd.MM.yyyy";
                        worksheetWriter.Cells[startRowInsert + numOfInserted, iColumn].Value = value;
                    }
                    numOfInserted++;
                }
                Byte[] content = excelPkgWriter.GetAsByteArray();
                File.WriteAllBytes(outputFile, content);
            }
            catch(Exception ex)
            {
                T2P._2015.Cross.Utility.Log.Logging.Error(ex.StackTrace, "DownloadEmailRentalCar");
                return false;
            }
            finally
            {
                if(streamInput != null)
                    streamInput.Close();
                if(streamTemplate != null)
                    streamTemplate.Close();
            }
            return File.Exists(outputFile);
        }

        private object GetValueFromDataset(DataTable dataset, int column, int row)
        {
            var dataRow = dataset.Rows[row];
            var val = dataRow[column];
            var valContent = val.ToString();
            //var dt = DateTime.MinValue;
            //DateTime.TryParse(valContent, out dt);
            //DateTime.TryParseExact(valContent, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
            if (val is DateTime)
                return val;
            return valContent;
        }
        private static void SetBorder(ExcelRange currentCell)
        {
            currentCell.Style.Border.Bottom.Style = currentCell.Style.Border.Top.Style = currentCell.Style.Border.Left.Style = currentCell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
        }

        public bool Export_DBISearch(string inputTemplate, ref string outputFilename, int beginRow_Header, List<dynamic> listDBI, List<ExcelSheet> listSheet)
        {
            try
            {
                string directory = Path.GetDirectoryName(outputFilename);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                int colSpan = listDBI.Count();

                using (ExcelPackage excelPkg = new ExcelPackage())
                using (FileStream stream = new FileStream(inputTemplate, FileMode.Open))
                {
                    excelPkg.Load(stream);

                    foreach (ExcelSheet sheet in listSheet)
                    {
                        ExcelWorksheet oSheet = excelPkg.Workbook.Worksheets[sheet.SheetName];

                        int dbiColumn = 0;
                        int travelerColumn = 0;
                        foreach (ExcelAdditionData addition in sheet.ListAddition)
                        {
                            ExcelRange currentCell = null;
                            if (addition.Value == "DBI")
                            {
                                dbiColumn = int.Parse(addition.Column);
                                currentCell = oSheet.Cells[beginRow_Header, int.Parse(addition.Column), beginRow_Header, int.Parse(addition.Column) + colSpan - 1];
                            }
                            else if (addition.Value == "Status")
                            {
                                currentCell = oSheet.Cells[beginRow_Header, int.Parse(addition.Column) + colSpan - 1, beginRow_Header + 1, int.Parse(addition.Column) + colSpan - 1];
                            }
                            else
                            {
                                if (addition.Value == "Traveler")
                                { 
                                    travelerColumn = int.Parse(addition.Column);
                                }
                                currentCell = oSheet.Cells[beginRow_Header, int.Parse(addition.Column), beginRow_Header + 1, int.Parse(addition.Column)];
                            }

                            currentCell.Merge = true;
                            currentCell.Value = addition.Value;
                            SetBorder(currentCell);
                        }

                        foreach(dynamic item in listDBI)
                        {
                            string value = string.Empty;
                            if (string.Equals(item.Code, item.Name))
                            {
                                value = item.Name;
                            }
                            else
                            {
                                value = item.Name + " (" + item.Code + ")";
                            }

                            oSheet.Cells[beginRow_Header + 1, dbiColumn].Value = value;
                            if (value.Length > 10)
                            {
                                oSheet.Cells[beginRow_Header + 1, dbiColumn].AutoFitColumns(value.Length + 4);
                            }
                            else 
                            {
                                oSheet.Cells[beginRow_Header + 1, dbiColumn].AutoFitColumns(10);
                            }
                            SetBorder(oSheet.Cells[beginRow_Header + 1, dbiColumn]);
                            dbiColumn += 1;
                        }

                        // insert rows
                        oSheet.InsertRow(sheet.BeginRow, sheet.ListData.Count);

                        var listType = typeof(List<>).MakeGenericType(sheet.DataType);
                        IList listData = (IList)Activator.CreateInstance(listType);

                        int rowIndex = 0;
                        foreach (dynamic item in sheet.ListData)
                        {
                            int rowSpan = item.ListTravelerDBI.Count;

                            //add index column
                            oSheet.Cells[sheet.BeginRow, int.Parse(sheet.IndexColum.Column), sheet.BeginRow + rowSpan - 1, int.Parse(sheet.IndexColum.Column)].Merge = true;
                            oSheet.Cells[sheet.BeginRow, int.Parse(sheet.IndexColum.Column)].Value = (rowIndex + 1).ToString();
                            oSheet.Cells[sheet.BeginRow, int.Parse(sheet.IndexColum.Column)].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            SetBorder(oSheet.Cells[sheet.BeginRow, int.Parse(sheet.IndexColum.Column), sheet.BeginRow + rowSpan - 1, int.Parse(sheet.IndexColum.Column)]);

                            var cellData = Convert.ChangeType(item, sheet.DataType);

                            foreach (ExcelCellData mapping in sheet.ListColumnsMapping)
                            {
                                ExcelRange currentCell = null;
                                if (mapping.DataName == "Status")
                                {
                                    currentCell = oSheet.Cells[sheet.BeginRow, travelerColumn + colSpan + 1, sheet.BeginRow + rowSpan - 1, travelerColumn + colSpan + 1];   
                                }
                                else
                                {
                                    currentCell = oSheet.Cells[sheet.BeginRow, int.Parse(mapping.Column), sheet.BeginRow + rowSpan - 1, int.Parse(mapping.Column)];
                                }

                                currentCell.Merge = true;
                                if (mapping.DataName == "CheckIn" || mapping.DataName == "CheckOut")
                                {
                                    currentCell.Value = sheet.DataType.GetProperty(mapping.DataName).GetValue(item).ToString("dd.MM.yyyy");
                                }
                                else
                                {
                                    currentCell.Value = sheet.DataType.GetProperty(mapping.DataName).GetValue(item);
                                    if (mapping.DataName == "Status")
                                    {
                                        currentCell.AutoFitColumns(15);
                                        currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                                    }
                                }
                                SetBorder(currentCell);
                            }

                            foreach (dynamic travelerDBI in item.ListTravelerDBI)
                            {
                                oSheet.Cells[sheet.BeginRow, travelerColumn].Value = travelerDBI.TravelerName;
                                SetBorder(oSheet.Cells[sheet.BeginRow, travelerColumn]);

                                int tempIndex = travelerColumn + 1;
                                foreach (dynamic dbi in listDBI)
                                {
                                    string tempDBI = Conversion.Conversion.ObjectToString(dbi.Code);
                                    SetBorder(oSheet.Cells[sheet.BeginRow, tempIndex]);
                                    oSheet.Cells[sheet.BeginRow, tempIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                                    switch (tempDBI) 
                                    {
                                        case "KS":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.KS) ? travelerDBI.KS : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "AE":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.AE) ? travelerDBI.AE : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "PR":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.PR) ? travelerDBI.PR : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "PK":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.PK) ? travelerDBI.PK : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "DS":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.DS) ? travelerDBI.DS : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "IK":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.IK) ? travelerDBI.IK : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "BD":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = travelerDBI.BD != null ? travelerDBI.BD.ToString("dd.MM.yyyy") : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "AU":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.AU) ? travelerDBI.AU : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        case "RZ":
                                            oSheet.Cells[sheet.BeginRow, tempIndex].Value = !string.IsNullOrWhiteSpace(travelerDBI.RZ) ? travelerDBI.RZ : string.Empty;
                                            tempIndex += 1;
                                            break;
                                        default:
                                            break;
                                    };
                                }
                                sheet.BeginRow += 1;
                            }

                            listData.Add(cellData);
                            rowIndex++;
                        }
                    }

                    Byte[] content = excelPkg.GetAsByteArray();
                    File.WriteAllBytes(outputFilename, content);

                    return File.Exists(outputFilename);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateMulti<T>(string inputTemplate, string outputFilename, List<ExcelSheet> listSheet, List<int> listRowBySheet)
        {
            string directory = Path.GetDirectoryName(outputFilename);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (ExcelPackage excelPkg = new ExcelPackage())
            using (FileStream stream = new FileStream(inputTemplate, FileMode.Open))
            {
                excelPkg.Load(stream);

                if (listSheet.Count != listRowBySheet.Count)
                {
                    return false;
                }

                for (int i = 0; i < listSheet.Count; i++)
                {
                    ExcelWorksheet oSheet = excelPkg.Workbook.Worksheets[listSheet[i].SheetName];

                    foreach (ExcelAdditionData addition in listSheet[i].ListAddition)
                    {
                        oSheet.Cells[addition.Column].Value = addition.Value;
                    }

                    int rowIndex = 0;

                    // insert rows
                    oSheet.InsertRow(listSheet[i].BeginRow, listRowBySheet[i]);

                    var listData = new List<T>();

                    foreach (var item in listSheet[i].ListData)
                    {
                        if (rowIndex < listRowBySheet[i])
                        {
                            //add index column
                            if (listSheet[i].IndexColum != null)
                            {
                                ExcelRange _no = oSheet.Cells[listSheet[i].IndexColum.Column + (listSheet[i].BeginRow + rowIndex).ToString()];
                                _no.Value = (rowIndex + 1).ToString();
                                SetStyle(listSheet[i].IndexColum, _no);
                            }

                            Type type = typeof(T);
                            var cellData = (T)item;
                            foreach (ExcelCellData mapping in listSheet[i].ListColumnsMapping)
                            {
                                ExcelRange currentCell = oSheet.Cells[mapping.Column + (listSheet[i].BeginRow + rowIndex).ToString()];
                                if (mapping.FixedValue != null)
                                {
                                    currentCell.Value = mapping.FixedValue;
                                }
                                else
                                {
                                    currentCell.Value = type.GetProperty(mapping.DataName).GetValue(item);
                                }

                                SetStyle(mapping, currentCell);
                            }

                            listData.Add(cellData);

                            rowIndex++;
                        }
                    }

                    var listSummary = listSheet[i].ListColumnsMapping.Where(m => m.HaveSummary);

                    foreach (var item in listSummary)
                    {
                        ExcelRange currentCell = oSheet.Cells[item.Column + (listSheet[i].BeginRow + rowIndex)];
                        currentCell.Value = listData.Sum(c => Utility.Conversion.Conversion.ObjectToFloat(c.GetType().GetProperty(item.DataName).GetValue(c, null)));
                        currentCell.Style.Font.Bold = true;
                        currentCell.Style.Font.Size = 12f;
                    }

                }

                Byte[] content = excelPkg.GetAsByteArray();
                File.WriteAllBytes(outputFilename, content);
                return File.Exists(outputFilename);
            }
        }

        private static void SetStyle(ExcelCellData mapping, ExcelRange currentCell)
        {
            if (mapping.CellStyle != null)
            {

                ExcelCellStyle style = mapping.CellStyle;
                currentCell.Style.Font.Bold = mapping.CellStyle.IsBold;
                currentCell.Style.Font.Italic = mapping.CellStyle.IsItalic;
                currentCell.Style.Font.UnderLine = mapping.CellStyle.IsUnderline;

                if (style.FontSize > 0)
                {
                    currentCell.Style.Font.Size = style.FontSize;
                }

                if (style.Align.HasValue)
                {
                    if (style.Align.Value == AlignType.Center) currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    else if (style.Align.Value == AlignType.Left) currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    else if (style.Align.Value == AlignType.Right) currentCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                }

                if (style.Border.HasValue)
                {
                    if (style.Border.Value == BorderType.Thin) currentCell.Style.Border.Bottom.Style = currentCell.Style.Border.Top.Style = currentCell.Style.Border.Left.Style = currentCell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    else if (style.Border.Value == BorderType.Dashed) currentCell.Style.Border.Bottom.Style = currentCell.Style.Border.Top.Style = currentCell.Style.Border.Left.Style = currentCell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Dashed;
                    else if (style.Border.Value == BorderType.Dotted) currentCell.Style.Border.Bottom.Style = currentCell.Style.Border.Top.Style = currentCell.Style.Border.Left.Style = currentCell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Dotted;
                }
            }
        }

        public void MappingColumn(ExcelSheet sheet, string dataName, string columnName)
        {
            sheet.ListColumnsMapping.Add
            (
                new ExcelCellData
                {
                    DataName = dataName,
                    Column = columnName,
                    CellStyle = new ExcelCellStyle
                    {
                        Border = BorderType.Thin
                    }
                }
            );
        }

        public static DataSet ImportExcelXLS(string fileName, bool hasHeaders, bool isImportBCDOffline = false)
        {
            string HDR = hasHeaders ? "Yes" : "No";
            //string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            var strConn = string.Empty;
            //ThanhPhan: Change IMEX=0 -> IMEX=1 to get data in column as text
            if (isImportBCDOffline)
            {
                if (fileName.Substring(fileName.LastIndexOf('.')).ToLower() == ".xlsx")
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=1\"";
                }
                else
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=1\"";
                }
            }
            else
            {
                if (fileName.Substring(fileName.LastIndexOf('.')).ToLower() == ".xlsx")
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
                }
                else
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
                }
            }
            

            DataSet output = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();

                DataTable schemaTable = conn.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                foreach (DataRow schemaRow in schemaTable.Rows)
                {
                    string sheet = schemaRow["TABLE_NAME"].ToString();

                    if (!sheet.EndsWith("_"))
                    {
                        try
                        {
                            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                            cmd.CommandType = CommandType.Text;

                            DataTable outputTable = new DataTable(sheet);
                            output.Tables.Add(outputTable);
                            new OleDbDataAdapter(cmd).Fill(outputTable);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message + string.Format("Sheet:{0}.File:F{1}", sheet, fileName), ex);
                        }
                    }
                }
            }
            return output;
        }

        public bool Update(string inputFilename, string outputFilename, List<ExcelSheet> listSheet)
        {
            string directory = Path.GetDirectoryName(outputFilename);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (ExcelPackage excelPkg = new ExcelPackage())
            using (FileStream stream = new FileStream(inputFilename, FileMode.Open))
            {
                excelPkg.Load(stream);

                foreach (ExcelSheet sheet in listSheet)
                {
                    ExcelWorksheet oSheet = excelPkg.Workbook.Worksheets[sheet.SheetName];

                    foreach (ExcelAdditionData addition in sheet.ListAddition)
                    {
                        oSheet.Cells[addition.Column].Value = addition.Value;
                    }

                    // insert rows
                    oSheet.InsertRow(sheet.BeginRow, sheet.ListData.Count);
                }

                Byte[] content = excelPkg.GetAsByteArray();
                File.WriteAllBytes(outputFilename, content);

                return File.Exists(outputFilename);
            }
        }
    }

    public class ExcelCellData
    {
        private string _dataName;

        public string DataName
        {
            get { return _dataName; }
            set { _dataName = value; }
        }

        private object _fixedValue;

        public object FixedValue
        {
            get { return _fixedValue; }
            set { _fixedValue = value; }
        }

        private string _column;

        public string Column
        {
            get { return _column; }
            set { _column = value; }
        }

        private bool _haveSummary;

        public bool HaveSummary
        {
            get { return _haveSummary; }
            set { _haveSummary = value; }
        }

        private ExcelCellStyle _cellStyle;

        public ExcelCellStyle CellStyle
        {
            get { return _cellStyle; }
            set { _cellStyle = value; }
        }
        public string SeperateCharacter { get; set; }
        public List<string> ListDataNames { get; set; }
        public List<ExcelCellStyle> ListExcelStyle { get; set; }
    }

    public class ExcelSheet
    {
        private string _sheetName;

        public string SheetName
        {
            get { return _sheetName; }
            set { _sheetName = value; }
        }

        private Type _dataType;

        public Type DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        private int _beginRow;

        public int BeginRow
        {
            get { return _beginRow; }
            set { _beginRow = value; }
        }

        private ExcelCellData _indexColum;

        public ExcelCellData IndexColum
        {
            get { return _indexColum; }
            set { _indexColum = value; }
        }

        private List<ExcelCellData> _listColumnsMapping;

        public List<ExcelCellData> ListColumnsMapping
        {
            get { return _listColumnsMapping; }
            set { _listColumnsMapping = value; }
        }

        private List<object> _listData;

        public List<object> ListData
        {
            get { return _listData; }
            set { _listData = value; }
        }

        private List<ExcelAdditionData> _listAddition;

        public List<ExcelAdditionData> ListAddition
        {
            get { return _listAddition; }
            set { _listAddition = value; }
        }

        public ExcelSheet()
        {
            ListAddition = new List<ExcelAdditionData>();
            ListColumnsMapping = new List<ExcelCellData>();
            ListData = new List<object>();
        }
    }

    public class ExcelAdditionData
    {
        private string _column;

        public string Column
        {
            get { return _column; }
            set { _column = value; }
        }

        private object _value;

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private ExcelCellStyle _cellStyle;

        public ExcelCellStyle CellStyle
        {
            get { return _cellStyle; }
            set { _cellStyle = value; }
        }
    }

    public class ExcelCellStyle
    {
        private float _fontSize;

        public float FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        private bool _isBold;

        public bool IsBold
        {
            get { return _isBold; }
            set { _isBold = value; }
        }

        private bool _isUnderline;

        public bool IsUnderline
        {
            get { return _isUnderline; }
            set { _isUnderline = value; }
        }

        private bool _isItalic;

        public bool IsItalic
        {
            get { return _isItalic; }
            set { _isItalic = value; }
        }

        private bool _isBorder;

        public bool IsBorder
        {
            get { return _isBorder; }
            set { _isBorder = value; }
        }

        private BorderType? _border;

        public BorderType? Border
        {
            get { return _border; }
            set { _border = value; }
        }

        private AlignType? _align;

        public AlignType? Align
        {
            get { return _align; }
            set { _align = value; }
        }
        public System.Drawing.Color Color { get; set; }
        public string FontName { get; set; }
    }

    public enum AlignType
    {
        Center,
        Right,
        Left
    }

    public enum BorderType
    {
        Thin,
        Dashed,
        Dotted
    }

}