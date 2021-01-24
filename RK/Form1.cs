using ExcelDataReader;
using System;
using ExcelLibrary;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;

namespace RK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstFileButton.Enabled = true;
            SecondFileButton.Enabled = false;
            button2.Enabled = false;
        }

        public string FirstFileString;
        public string SecondFileString;
        public string Dir = Environment.CurrentDirectory;
        public string ShopID;
      

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
                button2.Enabled = true;
            }
        }

        private void RibRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                ShopID = "103370";
                button2.Enabled = true;
            }
        }

        private void PsRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                ShopID = "165290";
                button2.Enabled = true;
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            var FirstArr = ToArr(ReadExcel(FirstFileString));
            var SecondArr = ToArr(ReadExcel(SecondFileString));

            if (FirstArr.GetLength(0) != SecondArr.GetLength(0))
            {
                MessageBox.Show("Разное чилсло строк в файлах");
                Application.Exit();
            }

            var ExportArr = NewArr(FirstArr, SecondArr);

            WriteExcel(ExportArr);
        }

        public DataSet ReadExcel (string filename)
        {
            using (var StreamExcel = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var ExcelReader = ExcelReaderFactory.CreateReader(StreamExcel))
                {
                    var Result = ExcelReader.AsDataSet();
                    ExcelReader.Close();
                    StreamExcel.Close();
                    return Result;
                }
            }
        }

        public string[,] ToArr(DataSet dataset)
        {
            var Rows = dataset.Tables[0].Rows;
            var Col = dataset.Tables[0].Columns;
            string[,] arr = new string[Rows.Count, Col.Count];

            for (int i = 0; i < Rows.Count; i++)
            {
                for (int j = 0; j < Col.Count; j++)
                {
                    arr[i, j] = dataset.Tables[0].Rows[i][j].ToString();
                }
            }
            return arr;
        }

        public string[,] NewArr(string[,] FirstArr, string[,] SecondArr)
        {
            int rows = FirstArr.GetLength(0);
            string[,] NewArr = new string[rows,4];
            if (FirstArr.GetLength(0) == SecondArr.GetLength(0))
            {
                NewArr[0, 0] = "Логин";
                NewArr[0, 1] = "Идентификатор";
                NewArr[0, 2] = "Ставка";
                NewArr[0, 3] = "ShopID";
                for (int i = 1; i < rows; i++)
                {
                    if (FirstArr[i, 1] == SecondArr[i, 0])
                    {
                        NewArr[i, 0] = FirstArr[i, 0];
                        NewArr[i, 1] = SecondArr[i, 22];
                        try
                        {
                            NewArr[i, 1] = NewArr[i, 1].Trim((char)160);
                        }
                        catch
                        {
                            NewArr[i, 1] = NewArr[i, 1];
                        }
                        NewArr[i, 2] = SecondArr[i, 7];
                        NewArr[i, 3] = ShopID;
                    }
                }
            } else
            {
                MessageBox.Show("Не верное кол-во строк в файлах");
            }
            return NewArr;
        }
        public void WriteExcel(string[,] InputArr)
        {
            string SavePath = string.Format("{0}\\Admin_{1}{2}{3}.xls", Dir, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Workbook WB = new Workbook();
            Worksheet WorkSheet = new Worksheet("First Sheet");
            

            for (int i = 0; i < InputArr.GetLength(0); i++)
            {
                for (int j = 0; j < InputArr.GetLength(1); j++)
                {
                    WorkSheet.Cells[i, j] = new Cell(InputArr[i, j]);
                }
            }

            WB.Worksheets.Add(WorkSheet);
            WB.Save(SavePath);
            MessageBox.Show("Готово");
        }

    }
}
