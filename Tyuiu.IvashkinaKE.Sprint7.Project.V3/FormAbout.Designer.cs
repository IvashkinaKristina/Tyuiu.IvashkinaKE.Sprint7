
namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_IKE = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_IKE = new System.Windows.Forms.TextBox();
            this.buttonOk_IKE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IKE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_IKE
            // 
            this.pictureBoxAvatar_IKE.Image = global::Tyuiu.IvashkinaKE.Sprint7.Project.V3.Properties.Resources.photo_2023_11_22_13_01_51;
            this.pictureBoxAvatar_IKE.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxAvatar_IKE.Name = "pictureBoxAvatar_IKE";
            this.pictureBoxAvatar_IKE.Size = new System.Drawing.Size(202, 196);
            this.pictureBoxAvatar_IKE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_IKE.TabIndex = 0;
            this.pictureBoxAvatar_IKE.TabStop = false;
            // 
            // textBoxAbout_IKE
            // 
            this.textBoxAbout_IKE.BackColor = System.Drawing.Color.Peru;
            this.textBoxAbout_IKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAbout_IKE.ForeColor = System.Drawing.Color.Moccasin;
            this.textBoxAbout_IKE.Location = new System.Drawing.Point(214, 12);
            this.textBoxAbout_IKE.Multiline = true;
            this.textBoxAbout_IKE.Name = "textBoxAbout_IKE";
            this.textBoxAbout_IKE.ReadOnly = true;
            this.textBoxAbout_IKE.Size = new System.Drawing.Size(388, 191);
            this.textBoxAbout_IKE.TabIndex = 1;
            this.textBoxAbout_IKE.Text = resources.GetString("textBoxAbout_IKE.Text");
            // 
            // buttonOk_IKE
            // 
            this.buttonOk_IKE.BackColor = System.Drawing.Color.Moccasin;
            this.buttonOk_IKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_IKE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk_IKE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonOk_IKE.Location = new System.Drawing.Point(603, 180);
            this.buttonOk_IKE.Name = "buttonOk_IKE";
            this.buttonOk_IKE.Size = new System.Drawing.Size(85, 32);
            this.buttonOk_IKE.TabIndex = 2;
            this.buttonOk_IKE.Text = "Ок";
            this.buttonOk_IKE.UseVisualStyleBackColor = false;
            this.buttonOk_IKE.Click += new System.EventHandler(this.buttonOk_IKE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(696, 216);
            this.Controls.Add(this.buttonOk_IKE);
            this.Controls.Add(this.textBoxAbout_IKE);
            this.Controls.Add(this.pictureBoxAvatar_IKE);
            this.MaximumSize = new System.Drawing.Size(714, 263);
            this.MinimumSize = new System.Drawing.Size(714, 263);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_IKE;
        private System.Windows.Forms.TextBox textBoxAbout_IKE;
        private System.Windows.Forms.Button buttonOk_IKE;
    }
}