using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using Tyuiu.IvashkinaKE.Sprint7.Project.V3.Lib;

namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
        }

        public string openFilePath;

        DataService ds = new DataService();



        static int columns;
        static int rows;
        public string path;
        static int cost;

        public static string[,] Array(string path)
        {

            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    try
                    {
                        int lin = Convert.ToInt32(strok[j]);
                        cost = j;
                        break;
                    }
                    catch
                    {
                        continue;
                    }

                }
            }

            string[,] mtr = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            return mtr;
        }

        private void buttonDo_IKE_Click(object sender, EventArgs e)
        {
            openFileDialog_IKE.ShowDialog();
            path = openFileDialog_IKE.FileName;

           

            string[,] res = Array(path);
            dataGridViewResult_IKE.Columns.Clear();
            dataGridViewResult_IKE.Rows.Clear();

            dataGridViewResult_IKE.ColumnCount = columns;
            dataGridViewResult_IKE.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    dataGridViewResult_IKE.Rows[i].Cells[j].Value = res[i, j];
                    dataGridViewResult_IKE.Columns[j].Width = 200;
                    dataGridViewResult_IKE.Rows[i].Height = 25;
                }
            }
        }

        private void buttonSaveFile_IKE_Click(object sender, EventArgs e)
        {
            saveFileDialog_IKE.FileName = "Tyu.csv";
            saveFileDialog_IKE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_IKE.ShowDialog();

            string path = saveFileDialog_IKE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_IKE.RowCount;
            int columns = dataGridViewResult_IKE.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewResult_IKE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewResult_IKE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        
    }
}
      
    

