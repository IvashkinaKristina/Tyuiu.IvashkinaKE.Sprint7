
namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    partial class FormAboutUniversity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUniversity));
            this.textBoxNameUniversity_IKE = new System.Windows.Forms.TextBox();
            this.textBoxAboutUniversity_IKE = new System.Windows.Forms.TextBox();
            this.button1_IKE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNameUniversity_IKE
            // 
            this.textBoxNameUniversity_IKE.BackColor = System.Drawing.Color.Peru;
            this.textBoxNameUniversity_IKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameUniversity_IKE.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUniversity_IKE.ForeColor = System.Drawing.Color.Moccasin;
            this.textBoxNameUniversity_IKE.Location = new System.Drawing.Point(0, 27);
            this.textBoxNameUniversity_IKE.Multiline = true;
            this.textBoxNameUniversity_IKE.Name = "textBoxNameUniversity_IKE";
            this.textBoxNameUniversity_IKE.ReadOnly = true;
            this.textBoxNameUniversity_IKE.Size = new System.Drawing.Size(698, 56);
            this.textBoxNameUniversity_IKE.TabIndex = 0;
            this.textBoxNameUniversity_IKE.Text = "Тюменский Индустриальный Университет";
            // 
            // textBoxAboutUniversity_IKE
            // 
            this.textBoxAboutUniversity_IKE.BackColor = System.Drawing.Color.Peru;
            this.textBoxAboutUniversity_IKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAboutUniversity_IKE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAboutUniversity_IKE.ForeColor = System.Drawing.Color.Moccasin;
            this.textBoxAboutUniversity_IKE.Location = new System.Drawing.Point(17, 89);
            this.textBoxAboutUniversity_IKE.Multiline = true;
            this.textBoxAboutUniversity_IKE.Name = "textBoxAboutUniversity_IKE";
            this.textBoxAboutUniversity_IKE.ReadOnly = true;
            this.textBoxAboutUniversity_IKE.Size = new System.Drawing.Size(661, 214);
            this.textBoxAboutUniversity_IKE.TabIndex = 1;
            this.textBoxAboutUniversity_IKE.Text = resources.GetString("textBoxAboutUniversity_IKE.Text");
            // 
            // button1_IKE
            // 
            this.button1_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.button1_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1_IKE.Location = new System.Drawing.Point(611, 261);
            this.button1_IKE.Name = "button1_IKE";
            this.button1_IKE.Size = new System.Drawing.Size(86, 35);
            this.button1_IKE.TabIndex = 2;
            this.button1_IKE.Text = "Ок";
            this.button1_IKE.UseVisualStyleBackColor = false;
            this.button1_IKE.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAboutUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(702, 301);
            this.Controls.Add(this.button1_IKE);
            this.Controls.Add(this.textBoxAboutUniversity_IKE);
            this.Controls.Add(this.textBoxNameUniversity_IKE);
            this.MaximumSize = new System.Drawing.Size(720, 348);
            this.MinimumSize = new System.Drawing.Size(720, 348);
            this.Name = "FormAboutUniversity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Об Университете";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameUniversity_IKE;
        private System.Windows.Forms.TextBox textBoxAboutUniversity_IKE;
        private System.Windows.Forms.Button button1_IKE;
    }
}