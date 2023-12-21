
namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    partial class Form1
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
            this.panelName_IKE = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonHelp_IKE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelName_IKE.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName_IKE
            // 
            this.panelName_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.panelName_IKE.Controls.Add(this.textBox1);
            this.panelName_IKE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName_IKE.Location = new System.Drawing.Point(0, 0);
            this.panelName_IKE.Name = "panelName_IKE";
            this.panelName_IKE.Size = new System.Drawing.Size(866, 54);
            this.panelName_IKE.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonHelp_IKE);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 398);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.IvashkinaKE.Sprint7.Project.V3.Properties.Resources.industrialuniversityoftyumen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Peru;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Тюменский Индустриальный Университет";
            // 
            // buttonHelp_IKE
            // 
            this.buttonHelp_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonHelp_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_IKE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_IKE.ForeColor = System.Drawing.Color.Peru;
            this.buttonHelp_IKE.Location = new System.Drawing.Point(800, 348);
            this.buttonHelp_IKE.Name = "buttonHelp_IKE";
            this.buttonHelp_IKE.Size = new System.Drawing.Size(54, 47);
            this.buttonHelp_IKE.TabIndex = 1;
            this.buttonHelp_IKE.Text = "?";
            this.buttonHelp_IKE.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Peru;
            this.button1.Location = new System.Drawing.Point(635, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Об Университете";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button2.ForeColor = System.Drawing.Color.Peru;
            this.button2.Location = new System.Drawing.Point(635, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Преподователи";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelName_IKE);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelName_IKE.ResumeLayout(false);
            this.panelName_IKE.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName_IKE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_IKE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

