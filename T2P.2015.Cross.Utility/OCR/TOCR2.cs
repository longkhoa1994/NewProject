//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Drawing.Imaging;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using T2P._2015.Cross.Utility.FileType;

//namespace T2P._2015.Cross.Utility.OCR
//{
//    public partial class TOCR2:t2
//    {
//        #region SDK Declares
//        private const int DIB_PAL_COLORS = 1;
//        private static uint DIB_RGB_COLORS = 0;
//        private static uint BI_RGB = 0;
//        private const int BI_BITFIELDS = 3;
//        private const int PAGE_READWRITE = 4;
//        private const int FILE_MAP_WRITE = 2;
//        private const int CBM_INIT = 4;
//        private const int SRCCOPY = 0x00CC0020;

//        [StructLayout(LayoutKind.Sequential, Pack = 4)]
//        struct RGBQUAD
//        {
//            public byte rgbBlue;
//            public byte rgbGreen;
//            public byte rgbRed;
//            public byte rgbReserved;
//        }

//        [StructLayout(LayoutKind.Sequential, Pack = 4)]
//        public struct BITMAPINFOHEADER
//        {
//            public uint biSize;
//            public int biWidth;
//            public int biHeight;
//            public short biPlanes;
//            public short biBitCount;
//            public uint biCompression;
//            public uint biSizeImage;
//            public int biXPelsPerMeter;
//            public int biYPelsPerMeter;
//            public uint biClrUsed;
//            public uint biClrImportant;
//        }

//        [StructLayout(LayoutKind.Sequential, Pack = 4)]
//        public struct BITMAPINFO
//        {
//            public BITMAPINFOHEADER bmih;
//            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
//            public uint[] cols;
//        }

//        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//        private static extern bool CloseHandle(IntPtr handle);

//        [DllImport("kernel32", EntryPoint = "CreateFileMappingA", CharSet = CharSet.Auto, SetLastError = true)]
//        private static extern IntPtr CreateFileMappingMy(uint hFile, uint lpFileMappingAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, int lpName);

//        [DllImport("kernel32", EntryPoint = "MapViewOfFile", CharSet = CharSet.Auto, SetLastError = true)]
//        private static extern IntPtr MapViewOfFileMy(IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);

//        [DllImport("kernel32", EntryPoint = "UnmapViewOfFile", CharSet = CharSet.Auto, SetLastError = true)]
//        private static extern int UnmapViewOfFileMy(IntPtr lpBaseAddress);

//        [DllImport("kernel32", EntryPoint = "RtlMoveMemory", CharSet = CharSet.Auto, SetLastError = true)]
//        private static extern void CopyMemory(uint lpvDest, IntPtr lpvSrc, uint cbCopy);

//        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//        private static extern System.IntPtr GlobalLock(IntPtr hMem);

//        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//        private static extern System.IntPtr GlobalUnlock(IntPtr hMem);

//        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//        private static extern int GlobalFree(IntPtr hMem);

//        [DllImport("gdi32.dll")]
//        private static extern bool DeleteObject(IntPtr hObject);

//        [DllImport("user32.dll")]
//        private static extern IntPtr GetDC(IntPtr hwnd);

//        [DllImport("gdi32.dll")]
//        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);

//        [DllImport("user32.dll")]
//        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

//        [DllImport("gdi32.dll")]
//        private static extern int DeleteDC(IntPtr hdc);

//        [DllImport("gdi32.dll")]
//        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

//        [DllImport("gdi32.dll")]
//        private static extern int BitBlt(IntPtr hdcDst, int xDst, int yDst, int w, int h, IntPtr hdcSrc, int xSrc, int ySrc, int rop);

//        [DllImport("gdi32.dll")]
//        private static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO bmi, uint Usage, out IntPtr bits, IntPtr hSection, uint dwOffset);

//        #endregion

//        // copy of TOCRRESULTSITEMEX without the Alt[] array 
//        [StructLayout(LayoutKind.Sequential, Pack = 4)]
//        struct TOCRRESULTSITEMEXHDR
//        {
//            public short StructId;
//            public short OCRCha;
//            public float Confidence;
//            public short XPos;
//            public short YPos;
//            public short XDim;
//            public short YDim;
//        }

//        public bool CheckImage(string imageFile, int width, int height)
//        {
//            Bitmap source = new Bitmap(imageFile);
//            if (source.Width == width && source.Height == height)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }

//        }

//        // Wait for the engine to complete by polling
//        private bool OCRPoll(int JobNo, TOCRJOBINFO2 JobInfo2)
//        {
//            int Status;
//            int JobStatus = 0;
//            int ErrorMode = 0;
//            float Progress = 0;
//            int AutoOrientation = 0;

//            Status = TOCRDoJob2(JobNo, ref JobInfo2);
//            if (Status == TOCR_OK)
//            {
//                do
//                {
//                    //Status = TOCRGetJobStatus(JobNo, JobStatus)
//                    Status = TOCRGetJobStatusEx(JobNo, ref JobStatus, ref Progress, ref AutoOrientation);

//                    // Do something whilst the OCR engine runs
//                    //Application.DoEvents(); System.Threading.Thread.Sleep(100); Application.DoEvents();
//                    Console.WriteLine("Progress" + Convert.ToString(Convert.ToInt32(Progress * 100)) + "%");
//                } while (Status == TOCR_OK & JobStatus == TOCRJOBSTATUS_BUSY);

//            }

//            if (Status == TOCR_OK & JobStatus == TOCRJOBSTATUS_DONE)
//            {
//                return true;
//            }
//            else
//            {
//                // If something has gone wrong display a message
//                // (Check that the OCR engine hasn't already displayed a message)
//                TOCRGetConfig(JobNo, TOCRCONFIG_DLL_ERRORMODE, ref ErrorMode);
//                if (ErrorMode == TOCRERRORMODE_NONE)
//                {
//                    StringBuilder Msg = new StringBuilder(TOCRJOBMSGLENGTH);
//                    TOCRGetJobStatusMsg(JobNo, Msg);
//                    //MessageBox.Show(Msg.ToString(), "OCRPoll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//                }
//                return false;
//            }
//        }

//        // OVERLOADED function to retrieve the results from the service process and load into 'ResultsEx'
//        // Remember the character numbers returned refer to the Windows character set.
//        private bool GetResults(int JobNo, ref TOCRRESULTSEX ResultsEx)
//        {
//            int ResultsInf = 0;
//            byte[] Bytes;
//            int Offset;
//            bool RetStatus = false;

//            TOCRRESULTSITEMEXHDR ItemHdr;
//            GCHandle BytesGC;
//            System.IntPtr AddrOfItemBytes;

//            ResultsEx.Hdr.NumItems = 0;
//            if (TOCRGetJobResultsEx(JobNo, TOCRGETRESULTS_EXTENDED, ref ResultsInf, IntPtr.Zero) == TOCR_OK)
//            {
//                if (ResultsInf > 0)
//                {
//                    Bytes = new Byte[ResultsInf - 1];
//                    // pin the Bytes array so that TOCRGetJobResultsEx can write to it
//                    BytesGC = GCHandle.Alloc(Bytes, GCHandleType.Pinned);
//                    if (TOCRGetJobResultsEx(JobNo, TOCRGETRESULTS_EXTENDED, ref ResultsInf, BytesGC.AddrOfPinnedObject()) == TOCR_OK)
//                    {
//                        ResultsEx.Hdr = ((TOCRRESULTSHEADER)(Marshal.PtrToStructure(BytesGC.AddrOfPinnedObject(), typeof(TOCRRESULTSHEADER))));
//                        if (ResultsEx.Hdr.NumItems > 0)
//                        {
//                            ResultsEx.Item = new TOCRRESULTSITEMEX[ResultsEx.Hdr.NumItems];
//                            Offset = Marshal.SizeOf(typeof(TOCRRESULTSHEADER));
//                            for (int ItemNo = 0; ItemNo <= ResultsEx.Hdr.NumItems - 1; ItemNo++)
//                            {
//                                ResultsEx.Item[ItemNo].Alt = new TOCRRESULTSITEMEXALT[5];

//                                // Cannot Marshal TOCRRESULTSITEMEX so use copy of structure header
//                                // This unfortunately means a double copy of the data
//                                AddrOfItemBytes = Marshal.UnsafeAddrOfPinnedArrayElement(Bytes, Offset);
//                                ItemHdr = ((TOCRRESULTSITEMEXHDR)(Marshal.PtrToStructure(AddrOfItemBytes, typeof(TOCRRESULTSITEMEXHDR))));
//                                ResultsEx.Item[ItemNo].StructId = ItemHdr.StructId;
//                                ResultsEx.Item[ItemNo].OCRCha = ItemHdr.OCRCha;
//                                ResultsEx.Item[ItemNo].Confidence = ItemHdr.Confidence;
//                                ResultsEx.Item[ItemNo].XPos = ItemHdr.XPos;
//                                ResultsEx.Item[ItemNo].YPos = ItemHdr.YPos;
//                                ResultsEx.Item[ItemNo].XDim = ItemHdr.XDim;
//                                ResultsEx.Item[ItemNo].YDim = ItemHdr.YDim;
//                                Offset = Offset + Marshal.SizeOf(typeof(TOCRRESULTSITEMEXHDR));

//                                for (int AltNo = 0; AltNo < 5; AltNo++)
//                                {
//                                    AddrOfItemBytes = Marshal.UnsafeAddrOfPinnedArrayElement(Bytes, Offset);
//                                    ResultsEx.Item[ItemNo].Alt[AltNo] = ((TOCRRESULTSITEMEXALT)(Marshal.PtrToStructure(AddrOfItemBytes, typeof(TOCRRESULTSITEMEXALT))));
//                                    Offset = Offset + Marshal.SizeOf(typeof(TOCRRESULTSITEMEXALT));
//                                }
//                            }
//                        }

//                        RetStatus = true;

//                        // Double check results
//                        if (ResultsEx.Hdr.StructId == 0)
//                        {
//                            if (ResultsEx.Hdr.NumItems > 0)
//                            {
//                                if (ResultsEx.Item[0].StructId != 0)
//                                {
//                                    //MessageBox.Show("Wrong results item structure Id " + ResultsEx.Item[0].StructId.ToString(), "GetResultsEx", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//                                    ResultsEx.Hdr.NumItems = 0;
//                                    RetStatus = false;
//                                }
//                            }
//                        }
//                        else
//                        {
//                            //MessageBox.Show("Wrong results header structure Id " + ResultsEx.Item[0].StructId.ToString(), "GetResults", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//                            ResultsEx.Hdr.NumItems = 0;
//                            RetStatus = false;
//                        }
//                    }
//                    BytesGC.Free();
//                }
//            }
//            return RetStatus;
//        }

//        private IntPtr ConvertBitmapToMMF(Bitmap BMPIn, bool DiscardBitmap)
//        {
//            return ConvertBitmapToMMF(BMPIn, DiscardBitmap, true);
//        }

//        private IntPtr ConvertBitmapToMMF2(Bitmap BMPIn, bool DiscardBitmap)
//        {
//            return ConvertBitmapToMMF2(BMPIn, DiscardBitmap, true);
//        }

//        private IntPtr ConvertBitmapToMMF2(Bitmap BMPIn)
//        {
//            return ConvertBitmapToMMF2(BMPIn, true, true);
//        }

//        // Convert a global memory block to a bitmap
//        private Bitmap ConvertMemoryBlockToBitmap(IntPtr hMem)
//        {
//            Bitmap BMP = null;

//            BITMAPINFOHEADER BIH = new BITMAPINFOHEADER();
//            IntPtr bihPtr;
//            IntPtr dataPtr;
//            IntPtr palPtr;
//            uint HdrSize;
//            PixelFormat PixFormat = PixelFormat.Format1bppIndexed;
//            uint PalEntries = 0;
//            RGBQUAD rgb = new RGBQUAD();

//            bihPtr = GlobalLock(hMem);

//            if (!bihPtr.Equals(IntPtr.Zero))
//            {
//                BIH = ((BITMAPINFOHEADER)(Marshal.PtrToStructure(bihPtr, typeof(BITMAPINFOHEADER))));
//                HdrSize = BIH.biSize;
//                palPtr = (IntPtr)(bihPtr.ToInt32() + HdrSize);

//                // Most of these formats are untested
//                switch (BIH.biBitCount)
//                {
//                    case 1:
//                        HdrSize += (uint)(2 * Marshal.SizeOf(rgb));
//                        PixFormat = PixelFormat.Format1bppIndexed;
//                        PalEntries = 2;
//                        break;
//                    case 4:
//                        HdrSize += (uint)(16 * Marshal.SizeOf(rgb));
//                        PixFormat = PixelFormat.Format4bppIndexed;
//                        PalEntries = BIH.biClrUsed;
//                        break;
//                    case 8:
//                        HdrSize += (uint)(256 * Marshal.SizeOf(rgb));
//                        PixFormat = PixelFormat.Format8bppIndexed;
//                        PalEntries = BIH.biClrUsed;
//                        break;
//                    case 16:
//                        // Account for the 3 DWORD colour mask
//                        if (BIH.biCompression == BI_BITFIELDS)
//                            HdrSize += 12;
//                        PixFormat = PixelFormat.Format16bppRgb555;
//                        PalEntries = 0;
//                        break;
//                    case 24:
//                        PixFormat = PixelFormat.Format24bppRgb;
//                        PalEntries = 0;
//                        break;
//                    case 32:
//                        // Account for the 3 DWORD colour mask
//                        if (BIH.biCompression == BI_BITFIELDS)
//                            HdrSize += 12;
//                        PixFormat = PixelFormat.Format32bppRgb;
//                        PalEntries = 0;
//                        break;
//                    default:
//                        break;
//                }

//                dataPtr = (IntPtr)(bihPtr.ToInt32() + HdrSize);
//                BMP = new Bitmap(BIH.biWidth, Math.Abs(BIH.biHeight), PixFormat);
//                if (PalEntries > 0)
//                {
//                    palPtr = (IntPtr)(bihPtr.ToInt32() + BIH.biSize);
//                    ColorPalette Pal = BMP.Palette;
//                    for (int PalEntry = 0; PalEntry < PalEntries; PalEntry++)
//                    {
//                        rgb = ((RGBQUAD)(Marshal.PtrToStructure(palPtr, typeof(RGBQUAD))));
//                        Pal.Entries[PalEntry] = Color.FromArgb(rgb.rgbRed, rgb.rgbGreen, rgb.rgbBlue);
//                        palPtr = (IntPtr)(palPtr.ToInt32() + Marshal.SizeOf(rgb));
//                    }
//                    BMP.Palette = Pal;
//                }
//                BitmapData BMPData = BMP.LockBits(new Rectangle(new Point(), BMP.Size), ImageLockMode.ReadWrite, PixFormat);
//                CopyMemory((uint)BMPData.Scan0.ToInt32(), dataPtr, (uint)(BMPData.Stride * BMP.Height));
//                BMP.UnlockBits(BMPData);
//                // Flip the bitmap (GDI+ bitmap scan lines are top down, GDI are bottom up)
//                BMP.RotateFlip(RotateFlipType.RotateNoneFlipY);

//                // Reset the resolutions
//                BMP.SetResolution((float)((int)(BIH.biXPelsPerMeter * 2.54 / 100 + 0.5)), (float)((int)(BIH.biYPelsPerMeter * 2.54 / 100 + 0.5)));
//                GlobalUnlock(hMem);
//            }

//            return BMP;
//        }
//    }
//    //public partial class TOCR2 : TOCRdeclares
//    //{

//    //    public string Message = string.Empty;
//    //    public int Width = 0;
//    //    public int Height = 0;

//    //    public List<CustomWord> listOCRRow = new List<CustomWord>();


//    //    public void Run(string imageFile, int JobNo = 0)
//    //    {
//    //        string Msg = "";
//    //        Bitmap BMP;
//    //        TOCRRESULTS Results = new TOCRRESULTS();
//    //        TOCRJOBINFO2 JobInfo2 = new TOCRJOBINFO2();
//    //        ImageProcessing image = new ImageProcessing();

//    //        JobInfo2.ProcessOptions.DisableCharacter = new short[256];

//    //        IntPtr MMFhandle = IntPtr.Zero;
//    //        using (FileStream stream = new FileStream(imageFile, FileMode.Open, FileAccess.Read))
//    //        {
//    //            BMP = new Bitmap(stream);

//    //        }
//    //        if (BMP.Width > 10000 || BMP.Height > 10000)
//    //        {
//    //            BMP = image.Resize(BMP, 5000, 5000, 100);
//    //        }


//    //        Width = BMP.Width;
//    //        Height = BMP.Height;
//    //        OCR(ref JobNo, ref Msg, BMP, ref Results, ref JobInfo2, ref MMFhandle);
//    //    }

//    //    private void OCR(ref int JobNo, ref string Msg, Bitmap BMP, ref TOCRRESULTS Results, ref TOCRJOBINFO2 JobInfo2, ref IntPtr MMFhandle)
//    //    {
//    //        int Status;
//    //        MMFhandle = ConvertBitmapToMMF(BMP);
//    //        //MMFhandle = ConvertBitmapToMMF2(BMP);

//    //        if (!(MMFhandle.Equals(IntPtr.Zero)))
//    //        {
//    //            TOCRSetConfig(TOCRCONFIG_DEFAULTJOB, TOCRCONFIG_DLL_ERRORMODE, TOCRERRORMODE_LOG);
//    //            JobInfo2.JobType = TOCRJOBTYPE_MMFILEHANDLE;
//    //            Status = TOCRInitialise(ref JobNo);


//    //            JobInfo2.ProcessOptions.StructId = 3;

//    //            if (Status == TOCR_OK)
//    //            {
//    //                JobInfo2.hMMF = MMFhandle;
//    //                if (OCRWait(JobNo, JobInfo2))
//    //                {
//    //                    if (GetResults(JobNo, ref Results))
//    //                    {
//    //                        if (FormatResults(Results, ref Msg))
//    //                        {
//    //                            ////MessageBox.Show(Msg, "Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    //                        }
//    //                    }
//    //                }
//    //                TOCRShutdown(JobNo);
//    //            }
//    //            CloseHandle(MMFhandle);
//    //        }
//    //    }

//    //    public int Rotate = 0;
//    //    // Wait for the engine to complete
//    //    private bool OCRWait(int JobNo, TOCRJOBINFO2 JobInfo2)
//    //    {
//    //        int Status;
//    //        int JobStatus = 0;
//    //        int ErrorMode = 0;
//    //        int Orientation = 0;
//    //        float Progress = 0;
//    //        //Status = TOCRDoJob2(JobNo, ref JobInfo2);

//    //        DateTime time = DateTime.Now;

//    //        if (TOCRDoJob2(JobNo, ref JobInfo2) == TOCR_OK)
//    //        {
//    //            do
//    //            {


//    //                Status = TOCRGetJobStatusEx(JobNo, ref JobStatus, ref Progress, ref Orientation);

//    //                if (Status == TOCR_OK)
//    //                {
//    //                    Status = TOCRWaitForJob(JobNo, ref JobStatus);
//    //                    break;
//    //                }
//    //                if ((DateTime.Now - time).Minutes == 5)
//    //                {
//    //                    break;
//    //                }

//    //            } while (Status == TOCR_OK & JobStatus == TOCRJOBSTATUS_BUSY);

//    //            if (Status == TOCR_OK && JobStatus == TOCRJOBSTATUS_DONE)
//    //            {
//    //                Status = TOCRGetJobStatusEx(JobNo, ref JobStatus, ref Progress, ref Orientation);

//    //                //Convert Orientation to degrees
//    //                switch (Orientation)
//    //                {
//    //                    case TOCRJOBORIENT_90: Rotate = 90;
//    //                        break;
//    //                    case TOCRJOBORIENT_180: Rotate = 180;
//    //                        break;
//    //                    case TOCRJOBORIENT_270: Rotate = 270;
//    //                        break;
//    //                    default:
//    //                        break;
//    //                }
//    //                return true;
//    //            }
//    //            else
//    //            {
//    //                // If something has gone wrong display a message
//    //                // (Check that the OCR engine hasn't already displayed a message)
//    //                TOCRGetConfig(JobNo, TOCRCONFIG_DLL_ERRORMODE, ref ErrorMode);
//    //                if (ErrorMode == TOCRERRORMODE_NONE)
//    //                {
//    //                    StringBuilder Msg = new StringBuilder(TOCRJOBMSGLENGTH);
//    //                    TOCRGetJobStatusMsg(JobNo, Msg);
//    //                }
//    //                return false;
//    //            }

//    //        }
//    //        else
//    //        {
//    //            return false;
//    //        }



//    //    }

//    //    // OVERLOADED function to retrieve the results from the service process and load into 'Results'
//    //    // Remember the character numbers returned refer to the Windows character set.
//    //    private bool GetResults(int JobNo, ref TOCRRESULTS Results)
//    //    {
//    //        int ResultsInf = 0; // number of bytes needed for results
//    //        byte[] Bytes;
//    //        int Offset;
//    //        bool RetStatus = false;
//    //        GCHandle BytesGC;
//    //        System.IntPtr AddrOfItemBytes;

//    //        Results.Hdr.NumItems = 0;
//    //        if (TOCRGetJobResults(JobNo, ref ResultsInf, IntPtr.Zero) == TOCR_OK)
//    //        {
//    //            if (ResultsInf > 0)
//    //            {
//    //                Bytes = new Byte[ResultsInf - 1];
//    //                // pin the Bytes array so that TOCRGetJobResults can write to it
//    //                BytesGC = GCHandle.Alloc(Bytes, GCHandleType.Pinned);
//    //                if (TOCRGetJobResults(JobNo, ref ResultsInf, BytesGC.AddrOfPinnedObject()) == TOCR_OK)
//    //                {
//    //                    Results.Hdr = ((TOCRRESULTSHEADER)(Marshal.PtrToStructure(BytesGC.AddrOfPinnedObject(), typeof(TOCRRESULTSHEADER))));
//    //                    if (Results.Hdr.NumItems > 0)
//    //                    {
//    //                        Results.Item = new TOCRRESULTSITEM[Results.Hdr.NumItems];
//    //                        Offset = Marshal.SizeOf(typeof(TOCRRESULTSHEADER));
//    //                        for (int ItemNo = 0; ItemNo <= Results.Hdr.NumItems - 1; ItemNo++)
//    //                        {
//    //                            AddrOfItemBytes = Marshal.UnsafeAddrOfPinnedArrayElement(Bytes, Offset);
//    //                            Results.Item[ItemNo] = ((TOCRRESULTSITEM)(Marshal.PtrToStructure(AddrOfItemBytes, typeof(TOCRRESULTSITEM))));
//    //                            Offset = Offset + Marshal.SizeOf(typeof(TOCRRESULTSITEM));
//    //                        }
//    //                    }

//    //                    RetStatus = true;

//    //                    // Double check results
//    //                    if (Results.Hdr.StructId == 0)
//    //                    {
//    //                        if (Results.Hdr.NumItems > 0)
//    //                        {
//    //                            if (Results.Item[0].StructId != 0)
//    //                            {
//    //                                //MessageBox.Show("Wrong results item structure Id " + Results.Item[0].StructId.ToString(), "GetResults", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//    //                                Results.Hdr.NumItems = 0;
//    //                                RetStatus = false;
//    //                            }
//    //                        }
//    //                    }
//    //                    else
//    //                    {
//    //                        //MessageBox.Show("Wrong results header structure Id " + Results.Item[0].StructId.ToString(), "GetResults", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//    //                        Results.Hdr.NumItems = 0;
//    //                        RetStatus = false;
//    //                    }
//    //                }
//    //                BytesGC.Free();
//    //            }
//    //        }
//    //        return RetStatus;
//    //    }

//    //    // OVERLOADED function to convert results to a string
//    //    private bool FormatResults(TOCRRESULTS Results, ref string Msg)
//    //    {

//    //        if (Results.Hdr.NumItems > 0)
//    //        {

//    //            List<CustomWord> listWord = new List<CustomWord>();
//    //            List<CustomChar> listCharacter = new List<CustomChar>();
//    //            int index = 1;
//    //            DateTime time = DateTime.Now;
//    //            for (int ItemNo = 0; ItemNo < Results.Hdr.NumItems; ItemNo++)
//    //            {
//    //                if (Results.Item[ItemNo].OCRCha == 13)
//    //                    Msg = Msg + Environment.NewLine;
//    //                else
//    //                    Msg = Msg + Convert.ToChar(Results.Item[ItemNo].OCRCha);


//    //                SetOCRRow(ref Results, ref listWord, ref listCharacter, ref index, ItemNo);


//    //            }



//    //            Message = Msg;
//    //            /*Encoding UNICODE = Encoding.Unicode;
//    //            Encoding ANSI = Encoding.GetEncoding(1252);
//    //            byte[] ansibytes = new Byte[Results.Hdr.NumItems];
//    //            byte[] unicodebytes = new Byte[Results.Hdr.NumItems];

//    //            for (int ItemNo = 0; ItemNo < Results.Hdr.NumItems; ItemNo++)
//    //            {
//    //                if (Results.Item[ItemNo].OCRCha == 13)
//    //                    ansibytes[ItemNo] = (byte)'\n';
//    //                else
//    //                {
//    //                    ansibytes[ItemNo] = (byte)Results.Item[ItemNo].OCRCha;
//    //                }
//    //            }
//    //            unicodebytes = Encoding.Convert(ANSI, UNICODE, ansibytes);
//    //            Msg = UNICODE.GetString(unicodebytes);
//    //            */
//    //            return true;
//    //        }
//    //        else
//    //        {
//    //            //MessageBox.Show("No results returned", "FormatResults", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    //            return false;
//    //        }
//    //    }

//    //    private void SetOCRRow(ref TOCRRESULTS Results, ref List<CustomWord> listWord, ref List<CustomChar> listCharacter, ref int index, int ItemNo)
//    //    {
//    //        int wordIndex = 1;
//    //        if (Convert.ToChar(Results.Item[ItemNo].OCRCha) != 13)
//    //        {
//    //            if (Convert.ToChar(Results.Item[ItemNo].OCRCha) != ' ')
//    //            {
//    //                CustomChar character2 = new CustomChar()
//    //                      {
//    //                          Value = Convert.ToChar(Results.Item[ItemNo].OCRCha).ToString(),
//    //                          //Confidence = Results.Item[ItemNo].Confidence,
//    //                          Width = Results.Item[ItemNo].XDim,
//    //                          X = Results.Item[ItemNo].XPos,
//    //                          Height = Results.Item[ItemNo].YDim,
//    //                          Y = Results.Item[ItemNo].YPos,
//    //                      };
//    //                listCharacter.Add(character2);
//    //            }
//    //            if (Convert.ToChar(Results.Item[ItemNo].OCRCha) == ' ')
//    //            {
//    //                CustomWord word = new CustomWord()
//    //                {
//    //                    //ListCharacter = listCharacter
//    //                    Value = string.Join("", listCharacter.Select(x => x.Value)),
//    //                    CharItems = listCharacter,
//    //                    Height = listCharacter.Max(x => x.Height),
//    //                    Width = listCharacter.Count == 1 ? listCharacter.First().Width   : listCharacter.Last().X - listCharacter.First().X + listCharacter.Last().Width,
//    //                    X = listCharacter.First().X,
//    //                    Y = listCharacter.First().Y,
//    //                    //Confidence = listCharacter.Sum(x => x.Confidence) / listCharacter.Count * 100,
//    //                    Index = wordIndex,
//    //                    //CorrectWord = string.Empty,
//    //                };
//    //                listCharacter = new List<CustomChar>();
//    //                listWord.Add(word);
//    //                wordIndex++;
//    //            }
//    //        }
//    //        else
//    //        {
//    //            CustomWord word = new CustomWord()
//    //            {
//    //                //ListCharacter = listCharacter
//    //                Word = string.Join("", listCharacter.Select(x => x.Value)),
//    //                ListCharacter = listCharacter,
//    //                Height = listCharacter.Max(x => x.YDim),
//    //                Width = listCharacter.Count == 1 ? listCharacter.First().XDim : listCharacter.Last().XPos - listCharacter.First().XPos + listCharacter.Last().XDim,
//    //                XPos = listCharacter.First().XPos,
//    //                YPos = listCharacter.First().YPos,
//    //                Confidence = listCharacter.Sum(x => x.Confidence) / listCharacter.Count * 100,
//    //                CorrectWord = string.Empty,
//    //                Position = wordIndex,
//    //            };
//    //            listCharacter = new List<CustomChar>();
//    //            listWord.Add(word);
//    //            wordIndex++;
//    //            OCRRow info = new OCRRow()
//    //            {
//    //                ListWord = listWord,
//    //                Row = string.Join(" ", listWord.Select(x => x.Word)),
//    //                Position = index,
//    //                CorrectRow = string.Empty,
//    //                Confidence = listWord.Sum(x => x.Confidence) / listWord.Count,
//    //            };
//    //            listOCRRow.Add(info);

//    //            listWord = new List<WordInfo>();
//    //            index++;
//    //        }
//    //        if (ItemNo == Results.Hdr.NumItems - 1)
//    //        {
//    //            WordInfo word = new WordInfo()
//    //            {
//    //                //ListCharacter = listCharacter
//    //                Word = string.Join("", listCharacter.Select(x => x.Value)),
//    //                ListCharacter = listCharacter,
//    //                Height = listCharacter.Max(x => x.YDim),
//    //                Width = listCharacter.Count == 1 ? listCharacter.First().XDim : listCharacter.Last().XPos - listCharacter.First().XPos + listCharacter.Last().XDim,
//    //                XPos = listCharacter.First().XPos,
//    //                YPos = listCharacter.First().YPos,
//    //                Confidence = listCharacter.Sum(x => x.Confidence) / listCharacter.Count * 100,
//    //                CorrectWord = string.Empty,
//    //                Position = wordIndex,
//    //            };
//    //            listCharacter = new List<Character>();
//    //            listWord.Add(word);
//    //            wordIndex++;
//    //            OCRRow info = new OCRRow()
//    //            {
//    //                ListWord = listWord,
//    //                Row = string.Join(" ", listWord.Select(x => x.Word)),
//    //                Position = index,
//    //                CorrectRow = string.Empty,
//    //                Confidence = listWord.Sum(x => x.Confidence) / listWord.Count,
//    //            };
//    //            listOCRRow.Add(info);

//    //            listWord = new List<WordInfo>();
//    //            index++;
//    //        }
//    //    }

//    //    // OVERLOADED function to convert results to a string
//    //    //private bool FormatResults(TOCRRESULTSEX ResultsEx, ref string Msg)
//    //    //{
//    //    //    Msg = "";

//    //    //    if (ResultsEx.Hdr.NumItems > 0)
//    //    //    {
//    //    //        List<WordInfo> listWord = new List<WordInfo>();
//    //    //        List<Character> listCharacter = new List<Character>();
//    //    //        for (int ItemNo = 0; ItemNo < ResultsEx.Hdr.NumItems; ItemNo++)
//    //    //        {
//    //    //            if (ResultsEx.Item[ItemNo].OCRCha == 13)
//    //    //                Msg = Msg + Environment.NewLine;
//    //    //            else
//    //    //                Msg = Msg + Convert.ToChar(ResultsEx.Item[ItemNo].OCRCha);

//    //    //        }



//    //    //        return true;
//    //    //    }
//    //    //    else
//    //    //    {
//    //    //        //MessageBox.Show("No results returned", "FormatResults", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    //    //        return false;
//    //    //    }
//    //    //}

//    //    // Convert a bitmap to 1bpp
//    //    private Bitmap ConvertTo1bpp(Bitmap BMPIn)
//    //    {

//    //        T2P._2015.Cross.Utility.OCR.TOCR.BITMAPINFO bmi = new T2P._2015.Cross.Utility.OCR.TOCR.BITMAPINFO();
//    //        IntPtr hbmIn = BMPIn.GetHbitmap();

//    //        bmi.bmih.biSize = (uint)Marshal.SizeOf(bmi.bmih);
//    //        bmi.bmih.biWidth = BMPIn.Width;
//    //        bmi.bmih.biHeight = BMPIn.Height;
//    //        bmi.bmih.biPlanes = 1;
//    //        bmi.bmih.biBitCount = 1;
//    //        bmi.bmih.biCompression = BI_RGB;
//    //        bmi.bmih.biSizeImage = (uint)((((BMPIn.Width + 7) & 0xFFFFFFF8) >> 3) * BMPIn.Height);
//    //        bmi.bmih.biXPelsPerMeter = System.Convert.ToInt32(BMPIn.HorizontalResolution * 100 / 2.54);
//    //        bmi.bmih.biYPelsPerMeter = System.Convert.ToInt32(BMPIn.VerticalResolution * 100 / 2.54);
//    //        bmi.bmih.biClrUsed = 2;
//    //        bmi.bmih.biClrImportant = 2;
//    //        bmi.cols = new uint[2]; // see the definition of BITMAPINFO()
//    //        bmi.cols[0] = 0;
//    //        bmi.cols[1] = ((uint)(255)) | ((uint)((255) << 8)) | ((uint)((255) << 16));

//    //        IntPtr dummy;
//    //        IntPtr hbm = CreateDIBSection(IntPtr.Zero, ref bmi, DIB_RGB_COLORS, out dummy, IntPtr.Zero, 0);

//    //        IntPtr scrnDC = GetDC(IntPtr.Zero);
//    //        IntPtr hDCIn = CreateCompatibleDC(scrnDC);

//    //        SelectObject(hDCIn, hbmIn);
//    //        IntPtr hDC = CreateCompatibleDC(scrnDC);
//    //        SelectObject(hDC, hbm);

//    //        BitBlt(hDC, 0, 0, BMPIn.Width, BMPIn.Height, hDCIn, 0, 0, SRCCOPY);

//    //        Bitmap BMP = Bitmap.FromHbitmap(hbm);

//    //        DeleteDC(hDCIn);
//    //        DeleteDC(hDC);
//    //        ReleaseDC(IntPtr.Zero, scrnDC);
//    //        DeleteObject(hbmIn);
//    //        DeleteObject(hbm);

//    //        return BMP;
//    //    }

//    //    // Convert a bitmap to a memory mapped file.
//    //    // It does this by constructing a GDI bitmap in a byte array and copying this to a memory mapped file.
//    //    private IntPtr ConvertBitmapToMMF(Bitmap BMPIn, bool DiscardBitmap, bool ConvertTo1Bit)
//    //    {
//    //        Bitmap BMP;
//    //        BITMAPINFOHEADER BIH;
//    //        BitmapData BMPData;
//    //        int ImageSize;
//    //        byte[] Bytes;
//    //        GCHandle BytesGC;
//    //        int MMFsize;
//    //        int PalEntries;
//    //        RGBQUAD rgb;
//    //        int Offset;
//    //        IntPtr MMFhandle = IntPtr.Zero;
//    //        IntPtr MMFview = IntPtr.Zero;
//    //        IntPtr RetPtr = IntPtr.Zero;

//    //        if (DiscardBitmap) // can destroy input bitmap
//    //        {
//    //            if (ConvertTo1Bit && BMPIn.PixelFormat != PixelFormat.Format1bppIndexed)
//    //            {
//    //                BMP = ConvertTo1bpp(BMPIn);
//    //                BMPIn.Dispose();
//    //                BMPIn = null;
//    //            }
//    //            else
//    //            {
//    //                BMP = BMPIn;
//    //            }
//    //        }
//    //        else			  // must keep input bitmap unchanged 
//    //        {
//    //            if (ConvertTo1Bit && BMPIn.PixelFormat != PixelFormat.Format1bppIndexed)
//    //            {
//    //                BMP = ConvertTo1bpp(BMPIn);
//    //            }
//    //            else
//    //            {
//    //                BMP = BMPIn.Clone(new Rectangle(new Point(), BMPIn.Size), BMPIn.PixelFormat);
//    //            }
//    //        }

//    //        // Flip the bitmap (GDI+ bitmap scan lines are top down, GDI are bottom up)
//    //        BMP.RotateFlip(RotateFlipType.RotateNoneFlipY);
//    //        BMPData = BMP.LockBits(new Rectangle(new Point(), BMP.Size), ImageLockMode.ReadOnly, BMP.PixelFormat);
//    //        ImageSize = BMPData.Stride * BMP.Height;

//    //        PalEntries = BMP.Palette.Entries.Length;

//    //        BIH.biWidth = BMP.Width;
//    //        BIH.biHeight = BMP.Height;
//    //        BIH.biPlanes = 1;
//    //        BIH.biClrImportant = 0;
//    //        BIH.biCompression = BI_RGB;
//    //        BIH.biSizeImage = (uint)ImageSize;
//    //        BIH.biXPelsPerMeter = System.Convert.ToInt32(BMP.HorizontalResolution * 100 / 2.54);
//    //        BIH.biYPelsPerMeter = System.Convert.ToInt32(BMP.VerticalResolution * 100 / 2.54);
//    //        BIH.biBitCount = 0;	// to avoid "Use of unassigned local variable 'BIH'"
//    //        BIH.biSize = 0;	// to avoid "Use of unassigned local variable 'BIH'"
//    //        BIH.biClrImportant = 0;	// to avoid "Use of unassigned local variable 'BIH'"

//    //        // Most of these formats are untested and the alpha channel is ignored
//    //        switch (BMP.PixelFormat)
//    //        {
//    //            case PixelFormat.Format1bppIndexed:
//    //                BIH.biBitCount = 1;
//    //                break;
//    //            case PixelFormat.Format4bppIndexed:
//    //                BIH.biBitCount = 4;
//    //                break;
//    //            case PixelFormat.Format8bppIndexed:
//    //                BIH.biBitCount = 8;
//    //                break;
//    //            case PixelFormat.Format16bppArgb1555:
//    //            case PixelFormat.Format16bppGrayScale:
//    //            case PixelFormat.Format16bppRgb555:
//    //            case PixelFormat.Format16bppRgb565:
//    //                BIH.biBitCount = 16;
//    //                PalEntries = 0;
//    //                break;
//    //            case PixelFormat.Format24bppRgb:
//    //                BIH.biBitCount = 24;
//    //                PalEntries = 0;
//    //                break;
//    //            case PixelFormat.Format32bppArgb:
//    //            case PixelFormat.Format32bppPArgb:
//    //            case PixelFormat.Format32bppRgb:
//    //                BIH.biBitCount = 32;
//    //                PalEntries = 0;
//    //                break;
//    //        }
//    //        BIH.biClrUsed = (uint)PalEntries;
//    //        BIH.biSize = (uint)Marshal.SizeOf(BIH);

//    //        MMFsize = Marshal.SizeOf(BIH) + PalEntries * Marshal.SizeOf(typeof(RGBQUAD)) + ImageSize;
//    //        Bytes = new byte[MMFsize];

//    //        BytesGC = GCHandle.Alloc(Bytes, GCHandleType.Pinned);
//    //        Marshal.StructureToPtr(BIH, BytesGC.AddrOfPinnedObject(), true);
//    //        Offset = Marshal.SizeOf(BIH);
//    //        rgb.rgbReserved = 0;
//    //        for (int PalEntry = 0; PalEntry <= PalEntries - 1; PalEntry++)
//    //        {
//    //            rgb.rgbRed = BMP.Palette.Entries[PalEntry].R;
//    //            rgb.rgbGreen = BMP.Palette.Entries[PalEntry].G;
//    //            rgb.rgbBlue = BMP.Palette.Entries[PalEntry].B;

//    //            Marshal.StructureToPtr(rgb, Marshal.UnsafeAddrOfPinnedArrayElement(Bytes, Offset), false);
//    //            Offset = Offset + Marshal.SizeOf(rgb);
//    //        }
//    //        BytesGC.Free();
//    //        Marshal.Copy(BMPData.Scan0, Bytes, Offset, ImageSize);
//    //        BMP.UnlockBits(BMPData);
//    //        BMPData = null;
//    //        BMP.Dispose();
//    //        BMP = null;
//    //        MMFhandle = CreateFileMappingMy(0xFFFFFFFF, 0, PAGE_READWRITE, 0, (uint)MMFsize, 0);
//    //        if (!(MMFhandle.Equals(IntPtr.Zero)))
//    //        {
//    //            MMFview = MapViewOfFileMy(MMFhandle, FILE_MAP_WRITE, 0, 0, 0);
//    //            if (MMFview.Equals(IntPtr.Zero))
//    //            {
//    //                CloseHandle(MMFhandle);
//    //            }
//    //            else
//    //            {
//    //                Marshal.Copy(Bytes, 0, MMFview, MMFsize);
//    //                UnmapViewOfFileMy(MMFview);
//    //                RetPtr = MMFhandle;
//    //            }
//    //        }

//    //        Bytes = null;

//    //        if (RetPtr.Equals(IntPtr.Zero))
//    //        {
//    //            //MessageBox.Show("Failed to convert bitmap", "ConvertBitmapToMMF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//    //        }
//    //        return RetPtr;
//    //    }

//    //    private IntPtr ConvertBitmapToMMF(Bitmap BMPIn)
//    //    {
//    //        return ConvertBitmapToMMF(BMPIn, true, true);
//    //    }

//    //    // Convert a bitmap to a memory mapped file
//    //    // (Same as ConvertBitmapToMMF but uses CopyMemory to avoid using a byte array)
//    //    private IntPtr ConvertBitmapToMMF2(Bitmap BMPIn, bool DiscardBitmap, bool ConvertTo1Bit)
//    //    {
//    //        Bitmap BMP;
//    //        BITMAPINFOHEADER BIH;
//    //        BitmapData BMPData;
//    //        int ImageSize;
//    //        int MMFsize;
//    //        int PalEntries;
//    //        RGBQUAD rgb;
//    //        GCHandle rgbGC;
//    //        int Offset;
//    //        IntPtr MMFhandle = IntPtr.Zero;
//    //        IntPtr MMFview = IntPtr.Zero;
//    //        IntPtr RetPtr = IntPtr.Zero;

//    //        if (DiscardBitmap) // can destroy input bitmap
//    //        {
//    //            if (ConvertTo1Bit && BMPIn.PixelFormat != PixelFormat.Format1bppIndexed)
//    //            {
//    //                BMP = ConvertTo1bpp(BMPIn);
//    //                BMPIn.Dispose();
//    //                BMPIn = null;
//    //            }
//    //            else
//    //            {
//    //                BMP = BMPIn;
//    //            }
//    //        }
//    //        else			  // must keep input bitmap unchanged 
//    //        {
//    //            if (ConvertTo1Bit && BMPIn.PixelFormat != PixelFormat.Format1bppIndexed)
//    //            {
//    //                BMP = ConvertTo1bpp(BMPIn);
//    //            }
//    //            else
//    //            {
//    //                BMP = BMPIn.Clone(new Rectangle(new Point(), BMPIn.Size), BMPIn.PixelFormat);
//    //            }
//    //        }


//    //        // Flip the bitmap (GDI+ bitmap scan lines are top down, GDI are bottom up)
//    //        BMP.RotateFlip(RotateFlipType.RotateNoneFlipY);

//    //        BMPData = BMP.LockBits(new Rectangle(new Point(), BMP.Size), ImageLockMode.ReadOnly, BMP.PixelFormat);
//    //        ImageSize = BMPData.Stride * BMP.Height;

//    //        PalEntries = BMP.Palette.Entries.Length;

//    //        BIH.biWidth = BMP.Width;
//    //        BIH.biHeight = BMP.Height;
//    //        BIH.biPlanes = 1;
//    //        BIH.biClrImportant = 0;
//    //        BIH.biCompression = BI_RGB;
//    //        BIH.biSizeImage = (uint)ImageSize;
//    //        BIH.biXPelsPerMeter = System.Convert.ToInt32(BMP.HorizontalResolution * 100 / 2.54);
//    //        BIH.biYPelsPerMeter = System.Convert.ToInt32(BMP.VerticalResolution * 100 / 2.54);
//    //        BIH.biBitCount = 0;	// to avoid "Use of unassigned local variable 'BIH'"
//    //        BIH.biSize = 0;	// to avoid "Use of unassigned local variable 'BIH'"
//    //        BIH.biClrImportant = 0;	// to avoid "Use of unassigned local variable 'BIH'"

//    //        // Most of these formats are untested and the alpha channel is ignored
//    //        switch (BMP.PixelFormat)
//    //        {
//    //            case PixelFormat.Format1bppIndexed:
//    //                BIH.biBitCount = 1;
//    //                break;
//    //            case PixelFormat.Format4bppIndexed:
//    //                BIH.biBitCount = 4;
//    //                break;
//    //            case PixelFormat.Format8bppIndexed:
//    //                BIH.biBitCount = 8;
//    //                break;
//    //            case PixelFormat.Format16bppArgb1555:
//    //            case PixelFormat.Format16bppGrayScale:
//    //            case PixelFormat.Format16bppRgb555:
//    //            case PixelFormat.Format16bppRgb565:
//    //                BIH.biBitCount = 16;
//    //                PalEntries = 0;
//    //                break;
//    //            case PixelFormat.Format24bppRgb:
//    //                BIH.biBitCount = 24;
//    //                PalEntries = 0;
//    //                break;
//    //            case PixelFormat.Format32bppArgb:
//    //            case PixelFormat.Format32bppPArgb:
//    //            case PixelFormat.Format32bppRgb:
//    //                BIH.biBitCount = 32;
//    //                PalEntries = 0;
//    //                break;
//    //        }
//    //        BIH.biClrUsed = (uint)PalEntries;
//    //        BIH.biSize = (uint)Marshal.SizeOf(BIH);

//    //        MMFsize = Marshal.SizeOf(BIH) + PalEntries * Marshal.SizeOf(typeof(RGBQUAD)) + ImageSize;

//    //        MMFhandle = CreateFileMappingMy(0xFFFFFFFF, 0, PAGE_READWRITE, 0, (uint)MMFsize, 0);
//    //        if (!(MMFhandle.Equals(IntPtr.Zero)))
//    //        {
//    //            MMFview = MapViewOfFileMy(MMFhandle, FILE_MAP_WRITE, 0, 0, 0);
//    //            if (MMFview.Equals(IntPtr.Zero))
//    //            {
//    //                CloseHandle(MMFhandle);
//    //            }
//    //            else
//    //            {
//    //                Marshal.StructureToPtr(BIH, MMFview, true);
//    //                Offset = MMFview.ToInt32() + Marshal.SizeOf(BIH);
//    //                rgb.rgbReserved = 0;
//    //                for (int PalEntry = 0; PalEntry <= PalEntries - 1; PalEntry++)
//    //                {
//    //                    rgb.rgbRed = BMP.Palette.Entries[PalEntry].R;
//    //                    rgb.rgbGreen = BMP.Palette.Entries[PalEntry].G;
//    //                    rgb.rgbBlue = BMP.Palette.Entries[PalEntry].B;

//    //                    rgbGC = GCHandle.Alloc(rgb, GCHandleType.Pinned);
//    //                    CopyMemory((uint)Offset, rgbGC.AddrOfPinnedObject(), (uint)Marshal.SizeOf(rgb));
//    //                    rgbGC.Free();
//    //                    Offset = Offset + Marshal.SizeOf(rgb);
//    //                }
//    //                CopyMemory((uint)Offset, BMPData.Scan0, (uint)ImageSize);
//    //                UnmapViewOfFileMy(MMFview);
//    //                RetPtr = MMFhandle;
//    //            }
//    //        }
//    //        BMP.UnlockBits(BMPData);
//    //        BMPData = null;
//    //        BMP.Dispose();
//    //        BMP = null;

//    //        if (RetPtr.Equals(IntPtr.Zero))
//    //        {
//    //            //MessageBox.Show("Failed to convert bitmap", "ConvertBitmapToMMF2", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//    //        }
//    //        return RetPtr;
//    //    }

//    //    public void Run(string imageFile, int x, int y, int width, int height, string zoneName = "", int JobNo = 0)
//    //    {
//    //        string Msg = "";
//    //        TOCRRESULTS Results = new TOCRRESULTS();
//    //        TOCRJOBINFO2 JobInfo2 = new TOCRJOBINFO2();
//    //        ImageProcessing image = new ImageProcessing();

//    //        JobInfo2.ProcessOptions.DisableCharacter = new short[256];

//    //        IntPtr MMFhandle = IntPtr.Zero;
//    //        Bitmap bmp = image.LoadImageFromFile(imageFile);

//    //        //crop image
//    //        Rectangle zone = new Rectangle(x, y, width, height);
//    //        Bitmap bmpZone = image.Crop(bmp, zone);

//    //        bmpZone.Save(imageFile + "zone_" + zoneName + "_" + Guid.NewGuid() + ".jpg");
//    //        //bmpZone.Save(DateTime.Now.ToString("yyyyMMddhhmmssfff") + "zone_"+ zoneName + "_"+ Guid.NewGuid() + ".jpg");
//    //        Width = bmp.Width;
//    //        Height = bmp.Height;
//    //        OCR(ref JobNo, ref Msg, bmpZone, ref Results, ref JobInfo2, ref MMFhandle);
//    //    }

//    //    public void Run(Bitmap bmp, int x, int y, int width, int height, int JobNo = 0)
//    //    {
//    //        string Msg = "";
//    //        TOCRRESULTS Results = new TOCRRESULTS();
//    //        TOCRJOBINFO2 JobInfo2 = new TOCRJOBINFO2();
//    //        ImageProcessing image = new ImageProcessing();

//    //        JobInfo2.ProcessOptions.DisableCharacter = new short[256];

//    //        IntPtr MMFhandle = IntPtr.Zero;

//    //        //crop image
//    //        Rectangle zone = new Rectangle(x, y, width, height);
//    //        Bitmap bmpZone = image.Crop(bmp, zone);



//    //        //bmpZone.Save(DateTime.Now.ToString("yyyyMMddhhmmssfff") + "zone_" + Guid.NewGuid() + ".jpg");

//    //        Width = bmp.Width;
//    //        Height = bmp.Height;
//    //        OCR(ref JobNo, ref Msg, bmpZone, ref Results, ref JobInfo2, ref MMFhandle);
//    //    }
//    //    public void Run(Bitmap bmp, int JobNo = 0)
//    //    {
//    //        string Msg = "";
//    //        TOCRRESULTS Results = new TOCRRESULTS();
//    //        TOCRJOBINFO2 JobInfo2 = new TOCRJOBINFO2();
//    //        ImageProcessing image = new ImageProcessing();

//    //        JobInfo2.ProcessOptions.DisableCharacter = new short[256];

//    //        IntPtr MMFhandle = IntPtr.Zero;



//    //        Rectangle zone = new Rectangle(0, 0, bmp.Width, bmp.Height);
//    //        Bitmap bmpZone = image.Crop(bmp, zone);

//    //        //bmpZone.Save(imageFile + "zone_" + Guid.NewGuid() + ".jpg");

//    //        Width = bmp.Width;
//    //        Height = bmp.Height;
//    //        OCR(ref JobNo, ref Msg, bmpZone, ref Results, ref JobInfo2, ref MMFhandle);
//    //    }
//    //}
//}
