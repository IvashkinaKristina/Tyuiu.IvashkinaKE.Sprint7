using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    public partial class FormChart : Form
    {
        public static FormChart instance;
        public FormChart()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonBuildChart_IKE_Click(object sender, EventArgs e)
        {
            this.chartResult_IKE.ChartAreas[0].AxisX.Title = "";
            this.chartResult_IKE.ChartAreas[0].AxisY.Title = "Количество часов";
            this.chartResult_IKE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chartResult_IKE.Legends[0].Enabled = false;
            chartResult_IKE.Series[0].Points.Clear();

            int[] array = FormTeachers.instance.Amount_Hours_Array;

            for (int i = 0; i < array.Length; i++)
            {
                chartResult_IKE.Series[0].Points.AddXY(i, array[i]);
            }

        }

        private void buttonCloseChart_IKE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
