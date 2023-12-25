
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
            this.panelTop_IKE = new System.Windows.Forms.Panel();
            this.textBoxTop_KE = new System.Windows.Forms.TextBox();
            this.panelFill_IKE = new System.Windows.Forms.Panel();
            this.buttonDelete_IKE = new System.Windows.Forms.Button();
            this.buttonAdd_IKE = new System.Windows.Forms.Button();
            this.labelSearch_IKE = new System.Windows.Forms.Label();
            this.textBoxSearch_IKE = new System.Windows.Forms.TextBox();
            this.buttonDo_IKE = new System.Windows.Forms.Button();
            this.buttonSaveFile_IKE = new System.Windows.Forms.Button();
            this.groupBoxSort_IKE = new System.Windows.Forms.GroupBox();
            this.buttonAlphabeticalSorting_IKE = new System.Windows.Forms.Button();
            this.groupBoxFilter_IKE = new System.Windows.Forms.GroupBox();
            this.buttonFilterKafedra_IKE = new System.Windows.Forms.Button();
            this.buttonFilterPredmet_IKE = new System.Windows.Forms.Button();
            this.textBoxFilterPredmet_IKE = new System.Windows.Forms.TextBox();
            this.textBoxFilterKafedra_IKE = new System.Windows.Forms.TextBox();
            this.dataGridViewResult_IKE = new System.Windows.Forms.DataGridView();
            this.toolTipSorting_IKE = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_IKE = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_IKE = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenChart_IKE = new System.Windows.Forms.Button();
            this.panelTop_IKE.SuspendLayout();
            this.panelFill_IKE.SuspendLayout();
            this.groupBoxSort_IKE.SuspendLayout();
            this.groupBoxFilter_IKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_IKE
            // 
            this.panelTop_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.panelTop_IKE.Controls.Add(this.textBoxTop_KE);
            this.panelTop_IKE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_IKE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_IKE.Name = "panelTop_IKE";
            this.panelTop_IKE.Size = new System.Drawing.Size(1261, 100);
            this.panelTop_IKE.TabIndex = 0;
            // 
            // textBoxTop_KE
            // 
            this.textBoxTop_KE.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxTop_KE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTop_KE.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTop_KE.ForeColor = System.Drawing.Color.Peru;
            this.textBoxTop_KE.Location = new System.Drawing.Point(140, 30);
            this.textBoxTop_KE.Multiline = true;
            this.textBoxTop_KE.Name = "textBoxTop_KE";
            this.textBoxTop_KE.ReadOnly = true;
            this.textBoxTop_KE.Size = new System.Drawing.Size(1085, 62);
            this.textBoxTop_KE.TabIndex = 0;
            this.textBoxTop_KE.Text = "Преподователи Тюменского Индустриального Университета";
            // 
            // panelFill_IKE
            // 
            this.panelFill_IKE.BackColor = System.Drawing.Color.Peru;
            this.panelFill_IKE.Controls.Add(this.buttonOpenChart_IKE);
            this.panelFill_IKE.Controls.Add(this.buttonDelete_IKE);
            this.panelFill_IKE.Controls.Add(this.buttonAdd_IKE);
            this.panelFill_IKE.Controls.Add(this.labelSearch_IKE);
            this.panelFill_IKE.Controls.Add(this.textBoxSearch_IKE);
            this.panelFill_IKE.Controls.Add(this.buttonDo_IKE);
            this.panelFill_IKE.Controls.Add(this.buttonSaveFile_IKE);
            this.panelFill_IKE.Controls.Add(this.groupBoxSort_IKE);
            this.panelFill_IKE.Controls.Add(this.groupBoxFilter_IKE);
            this.panelFill_IKE.Controls.Add(this.dataGridViewResult_IKE);
            this.panelFill_IKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_IKE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelFill_IKE.Location = new System.Drawing.Point(0, 100);
            this.panelFill_IKE.Name = "panelFill_IKE";
            this.panelFill_IKE.Size = new System.Drawing.Size(1261, 643);
            this.panelFill_IKE.TabIndex = 1;
            // 
            // buttonDelete_IKE
            // 
            this.buttonDelete_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonDelete_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDelete_IKE.Location = new System.Drawing.Point(1127, 576);
            this.buttonDelete_IKE.Name = "buttonDelete_IKE";
            this.buttonDelete_IKE.Size = new System.Drawing.Size(112, 54);
            this.buttonDelete_IKE.TabIndex = 10;
            this.buttonDelete_IKE.Text = "Удалить строку";
            this.buttonDelete_IKE.UseVisualStyleBackColor = false;
            this.buttonDelete_IKE.Click += new System.EventHandler(this.buttonDelete_IKE_Click);
            // 
            // buttonAdd_IKE
            // 
            this.buttonAdd_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAdd_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAdd_IKE.Location = new System.Drawing.Point(1127, 516);
            this.buttonAdd_IKE.Name = "buttonAdd_IKE";
            this.buttonAdd_IKE.Size = new System.Drawing.Size(112, 54);
            this.buttonAdd_IKE.TabIndex = 9;
            this.buttonAdd_IKE.Text = "Добавить строку";
            this.buttonAdd_IKE.UseVisualStyleBackColor = false;
            this.buttonAdd_IKE.Click += new System.EventHandler(this.buttonAdd_IKE_Cick);
            // 
            // labelSearch_IKE
            // 
            this.labelSearch_IKE.AutoSize = true;
            this.labelSearch_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch_IKE.ForeColor = System.Drawing.Color.Moccasin;
            this.labelSearch_IKE.Location = new System.Drawing.Point(239, 588);
            this.labelSearch_IKE.Name = "labelSearch_IKE";
            this.labelSearch_IKE.Size = new System.Drawing.Size(59, 19);
            this.labelSearch_IKE.TabIndex = 7;
            this.labelSearch_IKE.Text = "Поиск:";
            // 
            // textBoxSearch_IKE
            // 
            this.textBoxSearch_IKE.Location = new System.Drawing.Point(236, 608);
            this.textBoxSearch_IKE.Name = "textBoxSearch_IKE";
            this.textBoxSearch_IKE.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch_IKE.TabIndex = 6;
            this.textBoxSearch_IKE.TextChanged += new System.EventHandler(this.textBoxSearch_IKE_TextChanged);
            // 
            // buttonDo_IKE
            // 
            this.buttonDo_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonDo_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDo_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDo_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDo_IKE.Location = new System.Drawing.Point(437, 516);
            this.buttonDo_IKE.Name = "buttonDo_IKE";
            this.buttonDo_IKE.Size = new System.Drawing.Size(112, 54);
            this.buttonDo_IKE.TabIndex = 3;
            this.buttonDo_IKE.Text = "Открыть файл";
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
            this.buttonSaveFile_IKE.Location = new System.Drawing.Point(438, 576);
            this.buttonSaveFile_IKE.Name = "buttonSaveFile_IKE";
            this.buttonSaveFile_IKE.Size = new System.Drawing.Size(111, 54);
            this.buttonSaveFile_IKE.TabIndex = 2;
            this.buttonSaveFile_IKE.Text = "Сохранить файл";
            this.toolTipSorting_IKE.SetToolTip(this.buttonSaveFile_IKE, "Сохранить файл");
            this.buttonSaveFile_IKE.UseVisualStyleBackColor = false;
            this.buttonSaveFile_IKE.Click += new System.EventHandler(this.buttonSaveFile_IKE_Click);
            // 
            // groupBoxSort_IKE
            // 
            this.groupBoxSort_IKE.Controls.Add(this.buttonAlphabeticalSorting_IKE);
            this.groupBoxSort_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort_IKE.ForeColor = System.Drawing.Color.Moccasin;
            this.groupBoxSort_IKE.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxSort_IKE.Location = new System.Drawing.Point(236, 502);
            this.groupBoxSort_IKE.Name = "groupBoxSort_IKE";
            this.groupBoxSort_IKE.Size = new System.Drawing.Size(182, 84);
            this.groupBoxSort_IKE.TabIndex = 1;
            this.groupBoxSort_IKE.TabStop = false;
            this.groupBoxSort_IKE.Text = "Сотртировка списка:";
            // 
            // buttonAlphabeticalSorting_IKE
            // 
            this.buttonAlphabeticalSorting_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAlphabeticalSorting_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlphabeticalSorting_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlphabeticalSorting_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAlphabeticalSorting_IKE.Location = new System.Drawing.Point(6, 21);
            this.buttonAlphabeticalSorting_IKE.Name = "buttonAlphabeticalSorting_IKE";
            this.buttonAlphabeticalSorting_IKE.Size = new System.Drawing.Size(170, 57);
            this.buttonAlphabeticalSorting_IKE.TabIndex = 2;
            this.buttonAlphabeticalSorting_IKE.Text = "От А-Я ";
            this.toolTipSorting_IKE.SetToolTip(this.buttonAlphabeticalSorting_IKE, "Можете отсортировать список от А-Я");
            this.buttonAlphabeticalSorting_IKE.UseVisualStyleBackColor = false;
            this.buttonAlphabeticalSorting_IKE.Click += new System.EventHandler(this.buttonAlphabeticalSorting_IKE_Click);
            // 
            // groupBoxFilter_IKE
            // 
            this.groupBoxFilter_IKE.Controls.Add(this.buttonFilterKafedra_IKE);
            this.groupBoxFilter_IKE.Controls.Add(this.buttonFilterPredmet_IKE);
            this.groupBoxFilter_IKE.Controls.Add(this.textBoxFilterPredmet_IKE);
            this.groupBoxFilter_IKE.Controls.Add(this.textBoxFilterKafedra_IKE);
            this.groupBoxFilter_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilter_IKE.ForeColor = System.Drawing.Color.Moccasin;
            this.groupBoxFilter_IKE.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxFilter_IKE.Location = new System.Drawing.Point(12, 502);
            this.groupBoxFilter_IKE.Name = "groupBoxFilter_IKE";
            this.groupBoxFilter_IKE.Size = new System.Drawing.Size(218, 129);
            this.groupBoxFilter_IKE.TabIndex = 1;
            this.groupBoxFilter_IKE.TabStop = false;
            this.groupBoxFilter_IKE.Text = "Фильтрация списка:";
            // 
            // buttonFilterKafedra_IKE
            // 
            this.buttonFilterKafedra_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonFilterKafedra_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilterKafedra_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilterKafedra_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonFilterKafedra_IKE.Location = new System.Drawing.Point(112, 30);
            this.buttonFilterKafedra_IKE.Name = "buttonFilterKafedra_IKE";
            this.buttonFilterKafedra_IKE.Size = new System.Drawing.Size(100, 57);
            this.buttonFilterKafedra_IKE.TabIndex = 1;
            this.buttonFilterKafedra_IKE.Text = "По кафедре";
            this.toolTipSorting_IKE.SetToolTip(this.buttonFilterKafedra_IKE, "Можете произвести фильтрацию списка по кафедрам");
            this.buttonFilterKafedra_IKE.UseVisualStyleBackColor = false;
            this.buttonFilterKafedra_IKE.Click += new System.EventHandler(this.buttonFilterKafedra_IKE_Click);
            // 
            // buttonFilterPredmet_IKE
            // 
            this.buttonFilterPredmet_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonFilterPredmet_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilterPredmet_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilterPredmet_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonFilterPredmet_IKE.Location = new System.Drawing.Point(6, 30);
            this.buttonFilterPredmet_IKE.Name = "buttonFilterPredmet_IKE";
            this.buttonFilterPredmet_IKE.Size = new System.Drawing.Size(100, 57);
            this.buttonFilterPredmet_IKE.TabIndex = 0;
            this.buttonFilterPredmet_IKE.Text = "По предмету";
            this.toolTipSorting_IKE.SetToolTip(this.buttonFilterPredmet_IKE, "Можете произвести фильтрацию списка по предметам");
            this.buttonFilterPredmet_IKE.UseVisualStyleBackColor = false;
            this.buttonFilterPredmet_IKE.Click += new System.EventHandler(this.buttonFilterPredmet_IKE_Click);
            // 
            // textBoxFilterPredmet_IKE
            // 
            this.textBoxFilterPredmet_IKE.Location = new System.Drawing.Point(6, 93);
            this.textBoxFilterPredmet_IKE.Name = "textBoxFilterPredmet_IKE";
            this.textBoxFilterPredmet_IKE.Size = new System.Drawing.Size(100, 27);
            this.textBoxFilterPredmet_IKE.TabIndex = 5;
            // 
            // textBoxFilterKafedra_IKE
            // 
            this.textBoxFilterKafedra_IKE.Location = new System.Drawing.Point(112, 93);
            this.textBoxFilterKafedra_IKE.Name = "textBoxFilterKafedra_IKE";
            this.textBoxFilterKafedra_IKE.Size = new System.Drawing.Size(100, 27);
            this.textBoxFilterKafedra_IKE.TabIndex = 4;
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
            this.dataGridViewResult_IKE.Size = new System.Drawing.Size(1261, 496);
            this.dataGridViewResult_IKE.TabIndex = 0;
            // 
            // openFileDialog_IKE
            // 
            this.openFileDialog_IKE.FileName = "openFileDialog1";
            // 
            // buttonOpenChart_IKE
            // 
            this.buttonOpenChart_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonOpenChart_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenChart_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenChart_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonOpenChart_IKE.Location = new System.Drawing.Point(1009, 576);
            this.buttonOpenChart_IKE.Name = "buttonOpenChart_IKE";
            this.buttonOpenChart_IKE.Size = new System.Drawing.Size(112, 54);
            this.buttonOpenChart_IKE.TabIndex = 11;
            this.buttonOpenChart_IKE.Text = "Открыть график";
            this.toolTipSorting_IKE.SetToolTip(this.buttonOpenChart_IKE, "Просмотреть статистику");
            this.buttonOpenChart_IKE.UseVisualStyleBackColor = false;
            this.buttonOpenChart_IKE.Click += new System.EventHandler(this.buttonOpenChart_IKE_Click);
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 743);
            this.Controls.Add(this.panelFill_IKE);
            this.Controls.Add(this.panelTop_IKE);
            this.MaximumSize = new System.Drawing.Size(1279, 790);
            this.MinimumSize = new System.Drawing.Size(1279, 790);
            this.Name = "FormTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeachers";
            this.Load += new System.EventHandler(this.FormTeachers_Load);
            this.panelTop_IKE.ResumeLayout(false);
            this.panelTop_IKE.PerformLayout();
            this.panelFill_IKE.ResumeLayout(false);
            this.panelFill_IKE.PerformLayout();
            this.groupBoxSort_IKE.ResumeLayout(false);
            this.groupBoxFilter_IKE.ResumeLayout(false);
            this.groupBoxFilter_IKE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_IKE;
        private System.Windows.Forms.TextBox textBoxTop_KE;
        private System.Windows.Forms.Panel panelFill_IKE;
        private System.Windows.Forms.DataGridView dataGridViewResult_IKE;
        private System.Windows.Forms.GroupBox groupBoxFilter_IKE;
        private System.Windows.Forms.Button buttonAlphabeticalSorting_IKE;
        private System.Windows.Forms.Button buttonFilterKafedra_IKE;
        private System.Windows.Forms.Button buttonFilterPredmet_IKE;
        private System.Windows.Forms.ToolTip toolTipSorting_IKE;
        private System.Windows.Forms.Button buttonDo_IKE;
        private System.Windows.Forms.Button buttonSaveFile_IKE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_IKE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_IKE;
        private System.Windows.Forms.TextBox textBoxFilterKafedra_IKE;
        private System.Windows.Forms.GroupBox groupBoxSort_IKE;
        private System.Windows.Forms.TextBox textBoxFilterPredmet_IKE;
        private System.Windows.Forms.Label labelSearch_IKE;
        private System.Windows.Forms.TextBox textBoxSearch_IKE;
        private System.Windows.Forms.Button buttonAdd_IKE;
        private System.Windows.Forms.Button buttonDelete_IKE;
        private System.Windows.Forms.Button buttonOpenChart_IKE;
    }
}