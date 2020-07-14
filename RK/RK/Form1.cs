using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace RK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            Excel.Workbook book1 = excelApp.Workbooks.Open("D:\\1.xlsx");
            Excel.Worksheet sheet1 = (Excel.Worksheet)excelApp.Worksheets.get_Item(1);
            var lastCell1 = sheet1.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            int lastColumn1 = (int)lastCell1.Column;
            int lastRow1 = (int)lastCell1.Row;
            string[,] arr1 = new string[lastRow1, lastColumn1];

            Excel.Workbook book2 = excelApp.Workbooks.Open("D:\\2.xlsx");
            Excel.Worksheet sheet2 = (Excel.Worksheet)excelApp.Worksheets.get_Item(1);
            var lastCell2 = sheet2.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            int lastColumn2 = (int)lastCell2.Column;
            int lastRow2 = (int)lastCell2.Row;
            string[,] arr2 = new string[lastRow2, lastColumn2];

            Excel._Workbook NewBook = (Excel._Workbook)(excelApp.Workbooks.Add(Type.Missing));
            Excel._Worksheet NewSheet = (Excel._Worksheet)NewBook.ActiveSheet;
            string[,] NewArr = new string[lastRow1, 4];


            for (int i = 1; i <= lastRow1; i++)
            {
                for (int j = 1; j <= lastColumn1; j++)
                {
                    arr1[i-1, j-1] = Convert.ToString(sheet1.Cells[i, j].Value);
                }
            }

            for (int i = 1; i <= lastRow2; i++)
            {
                for (int j = 1; j <= lastColumn2; j++)
                {
                    arr2[i - 1, j - 1] = Convert.ToString(sheet2.Cells[i, j].Value);
                }
            }
            //Excel.Range range1 = sheet.get_Range(sheet.Cells[1, 1]);
            //var excelcells = sheet.get_Range("A1", Type.Missing);
            //var c = sheet.Cells[1, 1]; //строка, столбец
            //MessageBox.Show(Convert.ToString(excelcells.Value2));
            //MessageBox.Show(Convert.ToString(sheet.Cells[2, 1].Value2));
            //MessageBox.Show(Convert.ToString(sheet.Cells[2, 1].Value));


            book1.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            book2.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit(); // выйти из экселя
            GC.Collect();
        }
    }
}
