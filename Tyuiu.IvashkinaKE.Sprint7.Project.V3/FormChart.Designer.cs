
namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartResult_IKE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBuildChart_IKE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.buttonBuildChart_IKE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartResult_IKE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 0;
            // 
            // chartResult_IKE
            // 
            this.chartResult_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.chartResult_IKE.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartResult_IKE.BackSecondaryColor = System.Drawing.Color.Snow;
            chartArea1.Name = "ChartArea1";
            this.chartResult_IKE.ChartAreas.Add(chartArea1);
            this.chartResult_IKE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_IKE.Legends.Add(legend1);
            this.chartResult_IKE.Location = new System.Drawing.Point(0, 0);
            this.chartResult_IKE.Name = "chartResult_IKE";
            this.chartResult_IKE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_IKE.Series.Add(series1);
            this.chartResult_IKE.Size = new System.Drawing.Size(800, 350);
            this.chartResult_IKE.TabIndex = 0;
            this.chartResult_IKE.Text = "chart1";
            // 
            // buttonBuildChart_IKE
            // 
            this.buttonBuildChart_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonBuildChart_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuildChart_IKE.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.buttonBuildChart_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonBuildChart_IKE.Location = new System.Drawing.Point(635, 12);
            this.buttonBuildChart_IKE.Name = "buttonBuildChart_IKE";
            this.buttonBuildChart_IKE.Size = new System.Drawing.Size(153, 70);
            this.buttonBuildChart_IKE.TabIndex = 4;
            this.buttonBuildChart_IKE.Text = "Открыть график";
            this.buttonBuildChart_IKE.UseVisualStyleBackColor = false;
            this.buttonBuildChart_IKE.Click += new System.EventHandler(this.buttonBuildChart_IKE_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormChart";
            this.Text = "FormChart";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_IKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_IKE;
        private System.Windows.Forms.Button buttonBuildChart_IKE;
    }
}