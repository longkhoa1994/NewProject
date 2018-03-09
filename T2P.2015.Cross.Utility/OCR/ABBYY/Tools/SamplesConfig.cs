// (c) 2013 ABBYY Production LLC
// SAMPLES code is property of ABBYY, exclusive rights are reserved. 
//
// DEVELOPER is allowed to incorporate SAMPLES into his own APPLICATION and modify it under 
// the  terms of  License Agreement between  ABBYY and DEVELOPER.


// Auto-generated config-file for FineReader Engine C-Sharp samples

using System;
using T2P._2015.Cross.Utility.Configuration;

namespace T2P._2015.Cross.Utility.OCR
{
    class FreConfig
    {
        // Folder with FRE dll
        public static String GetDllFolder()
        {
            if (is64BitConfiguration())
            {
                return Config.GetAppSetting("ABBYYDLL");
                //return "E:\\Program Files\\ABBYY SDK\\11\\FineReader Engine\\Bin64";
            }
            else
            {
                return "Directory\\where\\x86\\dll\\resides";
            }
        }

        // Return developer serial number for FRE
        public static String GetDeveloperSN()
        {
            return "SWET11010006034549898313";
        }

        // Return full path to Samples directory
        //public static String GetSamplesFolder()
        //{
        //    return "C:\\ProgramData\\ABBYY\\SDK\\11\\FineReader Engine\\Samples";
        //}

        // Determines whether the current configuration is a 64-bit configuration
        private static bool is64BitConfiguration()
        {
            return System.IntPtr.Size == 8;
        }
    } 
}
