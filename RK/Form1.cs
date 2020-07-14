using System;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace RK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstFileButton.Enabled = true;
            SecondFileButton.Enabled = false;
            button1.Enabled = false;
        }

        public string FirstFileString;
        public string SecondFileString;
        public string Dir = Environment.CurrentDirectory;
        public string ShopID;
        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            Excel.Workbook book1 = excelApp.Workbooks.Open(FirstFileString);
            Excel.Worksheet sheet1 = (Excel.Worksheet)excelApp.Worksheets.get_Item(1);
            var lastCell1 = sheet1.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            int lastColumn1 = (int)lastCell1.Column;
            int lastRow1 = (int)lastCell1.Row;
            string[,] arr1 = new string[lastRow1, lastColumn1];

            Excel.Workbook book2 = excelApp.Workbooks.Open(SecondFileString);
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

            if (lastRow1 == lastRow2)
            {
                NewArr[0, 0] = "Логин";
                NewArr[0, 1] = "Идентификатор";
                NewArr[0, 2] = "Ставка";
                NewArr[0, 3] = "ShopID";
                for (int i = 1; i < lastRow1; i++)
                {
                    if (arr1[i, 1] == arr2[i, 0])
                    {
                        NewArr[i, 0] = arr1[i, 0];
                        NewArr[i, 1] = arr2[i, 22];
                        NewArr[i, 2] = arr2[i, 7];
                        NewArr[i, 3] = ShopID;
                    }
                }
            }

            for (int i = 0; i < lastRow1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    NewSheet.Cells[i+1, j+1] = NewArr[i, j];
                }
            }

            //string savepath = string.Format("F:\\RKdocs\\Admin_{0}{1}{2}.xlsx", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string savepath = string.Format("{0}\\Admin_{1}{2}{3}.xlsx", Dir, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            NewBook.SaveAs(savepath); //Сохраняем новую книгу
            MessageBox.Show("Файл сформирован");
            book1.Close(false, Type.Missing, Type.Missing); //Закрыть не сохраняя
            book2.Close(false, Type.Missing, Type.Missing);
            NewBook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit(); //Выйти из экселя
            GC.Collect(); //Убрать мусор
            Process.Start(Dir);
        }

        private void FirstFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            FirstFileString = openFileDialog1.FileName;
            FirstFile.Text = FirstFileString;
            SecondFileButton.Enabled = true;
        }

        private void SecondFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            SecondFileString = openFileDialog2.FileName;
            SecondFile.Text = SecondFileString;
        }

        private void KiwiRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                ShopID = "56893";
                button1.Enabled = true;
            }
        }

        private void RibRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                ShopID = "103370";
                button1.Enabled = true;
            }
        }

        private void PsRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                ShopID = "165290";
                button1.Enabled = true;
            }
        }
    }
}
