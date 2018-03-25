using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace WPTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\USER\Downloads\RC Claim Invoice Statistic.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;


            var xx = xlWorksheet.Name;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            int intAgain = Convert.ToInt32(colCount);
            int myInt = 2934;
            string myHex = myInt.ToString("X");  // Gives you hexadecimal
            int myNewInt = Convert.ToInt32(myHex, 16);  // Back to int again.
            xlWorkbook.Close();
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
