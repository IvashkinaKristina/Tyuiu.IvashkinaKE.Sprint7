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
        public static FormTeachers instance;

        public FormTeachers()
        {
            InitializeComponent();
            instance = this;
        }

        public string openFilePath;

        DataService ds = new DataService();

        static int columns;
        static int rows;
        public string path;
        static int cost;
        public int[] Amount_Hours_Array;

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

        private void buttonAlphabeticalSorting_IKE_Click(object sender, EventArgs e)
        {
            string[,] matrix = ds.SortAlhp(Array(path));
            dataGridViewResult_IKE.Columns.Clear();
            dataGridViewResult_IKE.Rows.Clear();

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_IKE.ColumnCount = columns;
            dataGridViewResult_IKE.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_IKE.Columns[j].Width = 200;
                    dataGridViewResult_IKE.Rows[i].Height = 20;
                    dataGridViewResult_IKE.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void FormTeachers_Load(object sender, EventArgs e)
        {
      
        }

        private void buttonFilterKafedra_IKE_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string text = textBoxFilterKafedra_IKE.Text;

            int Row = Array(path).GetUpperBound(0) + 1;

            for (int i = 0; i < Row; i++)
            {
                if (Array(path)[i, 10] == text && text != "Кафедра")
                {
                    flag = true;
                    
                }
            }

            if(flag == true)
            {
                string filterCondition = textBoxFilterKafedra_IKE.Text;

                
                dataGridViewResult_IKE.ClearSelection();
                {
                    
                    foreach (DataGridViewRow row in dataGridViewResult_IKE.Rows)
                    {
                        
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            
                            if (cell.Value != null && cell.Value.ToString().Contains(filterCondition))
                            {
                                
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }


            else
            {
                MessageBox.Show("Такой кафедры нет, попробуйте заново", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

               
        private void buttonFilterPredmet_IKE_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string text = textBoxFilterPredmet_IKE.Text;

            int Row = Array(path).GetUpperBound(0) + 1;

            for (int i = 0; i < Row; i++)
            {
                if (Array(path)[i, 5] == text && text != "Предмет")
                {
                    flag = true;

                }
            }

            if (flag == true)
            {
                string filterCondition = textBoxFilterPredmet_IKE.Text;

                
                dataGridViewResult_IKE.ClearSelection();
                {
                    
                    foreach (DataGridViewRow row in dataGridViewResult_IKE.Rows)
                    {
                       
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            
                            if (cell.Value != null && cell.Value.ToString().Contains(filterCondition))
                            {
                                
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }


            else
            {
                MessageBox.Show("Такого предмета нет, попробуйте заново", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_IKE_Cick(object sender, EventArgs e)
        {
            dataGridViewResult_IKE.Rows.Add();
        }

        private void buttonDelete_IKE_Click(object sender, EventArgs e)
        {
            int delete = dataGridViewResult_IKE.SelectedCells[0].RowIndex;
            dataGridViewResult_IKE.Rows.RemoveAt(delete);
        }


        private void textBoxSearch_IKE_TextChanged(object sender, EventArgs e)
        {
            
                string searchValue = textBoxSearch_IKE.Text.ToLower();

                foreach (DataGridViewRow row in dataGridViewResult_IKE.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                        {
                            cell.Style.BackColor = Color.Green; 
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White; 
                        }
                    }
                }
            

        }

        private void buttonOpenChart_IKE_Click(object sender, EventArgs e)
        {
           
            
                Amount_Hours_Array = new int[rows]; 

                int c = 0;

                for (int i = 0; i < rows ; i++) 
                {
                    bool ch = false;
                    string ResultString = "";
                    string CollectedStringValue = (dataGridViewResult_IKE.Rows[i].Cells[6].Value.ToString());
                    for (int k = 0; k < CollectedStringValue.Length; k++)
                    {
                        if (Char.IsDigit(CollectedStringValue[k]))
                        {
                            ResultString += CollectedStringValue[k];
                            ch = true;
                        }
                    }
                    if (ch)
                    {
                        Amount_Hours_Array[c] = int.Parse(ResultString);
                        c++;
                    }
                }
           
           

            FormChart formChart = new FormChart();
            formChart.Show();

        }
    }
}
      
    

