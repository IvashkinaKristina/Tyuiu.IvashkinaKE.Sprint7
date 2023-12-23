
namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    partial class FormTeachers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDo_IKE = new System.Windows.Forms.Button();
            this.buttonSaveFile_IKE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAlphabeticalSorting_IKE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewResult_IKE = new System.Windows.Forms.DataGridView();
            this.toolTipSorting_IKE = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_IKE = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_IKE = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Peru;
            this.textBox1.Location = new System.Drawing.Point(140, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1085, 62);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Преподователи Тюменского Индустриального Университета";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.buttonDo_IKE);
            this.panel2.Controls.Add(this.buttonSaveFile_IKE);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dataGridViewResult_IKE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 643);
            this.panel2.TabIndex = 1;
            // 
            // buttonDo_IKE
            // 
            this.buttonDo_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonDo_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDo_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDo_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDo_IKE.Location = new System.Drawing.Point(1021, 577);
            this.buttonDo_IKE.Name = "buttonDo_IKE";
            this.buttonDo_IKE.Size = new System.Drawing.Size(112, 54);
            this.buttonDo_IKE.TabIndex = 3;
            this.buttonDo_IKE.Text = "Открыть ";
            this.toolTipSorting_IKE.SetToolTip(this.buttonDo_IKE, "Можете открыть файл");
            this.buttonDo_IKE.UseVisualStyleBackColor = false;
            this.buttonDo_IKE.Click += new System.EventHandler(this.buttonDo_IKE_Click);
            // 
            // buttonSaveFile_IKE
            // 
            this.buttonSaveFile_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonSaveFile_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonSaveFile_IKE.Location = new System.Drawing.Point(1138, 577);
            this.buttonSaveFile_IKE.Name = "buttonSaveFile_IKE";
            this.buttonSaveFile_IKE.Size = new System.Drawing.Size(111, 54);
            this.buttonSaveFile_IKE.TabIndex = 2;
            this.buttonSaveFile_IKE.Text = "Сохранить";
            this.toolTipSorting_IKE.SetToolTip(this.buttonSaveFile_IKE, "Сохранить файл");
            this.buttonSaveFile_IKE.UseVisualStyleBackColor = false;
            this.buttonSaveFile_IKE.Click += new System.EventHandler(this.buttonSaveFile_IKE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAlphabeticalSorting_IKE);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Moccasin;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(13, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка списка:";
            // 
            // buttonAlphabeticalSorting_IKE
            // 
            this.buttonAlphabeticalSorting_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAlphabeticalSorting_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlphabeticalSorting_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlphabeticalSorting_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAlphabeticalSorting_IKE.Location = new System.Drawing.Point(213, 21);
            this.buttonAlphabeticalSorting_IKE.Name = "buttonAlphabeticalSorting_IKE";
            this.buttonAlphabeticalSorting_IKE.Size = new System.Drawing.Size(123, 57);
            this.buttonAlphabeticalSorting_IKE.TabIndex = 2;
            this.buttonAlphabeticalSorting_IKE.Text = "От А-Я ";
            this.toolTipSorting_IKE.SetToolTip(this.buttonAlphabeticalSorting_IKE, "Можете отсортировать список от А-Я");
            this.buttonAlphabeticalSorting_IKE.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(112, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "По кафедре";
            this.toolTipSorting_IKE.SetToolTip(this.button2, "Можете отсортировать список по кафедрам");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "По предметам";
            this.toolTipSorting_IKE.SetToolTip(this.button1, "Можете отсортировать список по предметам");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewResult_IKE
            // 
            this.dataGridViewResult_IKE.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewResult_IKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_IKE.ColumnHeadersVisible = false;
            this.dataGridViewResult_IKE.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResult_IKE.Name = "dataGridViewResult_IKE";
            this.dataGridViewResult_IKE.RowHeadersVisible = false;
            this.dataGridViewResult_IKE.RowHeadersWidth = 51;
            this.dataGridViewResult_IKE.RowTemplate.Height = 24;
            this.dataGridViewResult_IKE.Size = new System.Drawing.Size(1261, 550);
            this.dataGridViewResult_IKE.TabIndex = 0;
            // 
            // openFileDialog_IKE
            // 
            this.openFileDialog_IKE.FileName = "openFileDialog1";
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1279, 790);
            this.MinimumSize = new System.Drawing.Size(1279, 790);
            this.Name = "FormTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeachers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewResult_IKE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAlphabeticalSorting_IKE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipSorting_IKE;
        private System.Windows.Forms.Button buttonDo_IKE;
        private System.Windows.Forms.Button buttonSaveFile_IKE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_IKE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_IKE;
    }
}