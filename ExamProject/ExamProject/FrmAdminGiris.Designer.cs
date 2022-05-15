
namespace ExamProject
{
    partial class FrmAdminGiris
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Loginbut = new System.Windows.Forms.Button();
            this.KsifreTxtbox = new System.Windows.Forms.TextBox();
            this.KadTxtbox = new System.Windows.Forms.TextBox();
            this.Ksifre = new System.Windows.Forms.Label();
            this.Kad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ExamProject.Properties.Resources._9d1fa68d45beff3aa4a0f8361241da70;
            this.pictureBox3.Location = new System.Drawing.Point(310, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Loginbut
            // 
            this.Loginbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Loginbut.Location = new System.Drawing.Point(331, 327);
            this.Loginbut.Name = "Loginbut";
            this.Loginbut.Size = new System.Drawing.Size(104, 36);
            this.Loginbut.TabIndex = 22;
            this.Loginbut.Text = "Giriş Yap";
            this.Loginbut.UseVisualStyleBackColor = true;
            // 
            // KsifreTxtbox
            // 
            this.KsifreTxtbox.Location = new System.Drawing.Point(301, 283);
            this.KsifreTxtbox.Name = "KsifreTxtbox";
            this.KsifreTxtbox.Size = new System.Drawing.Size(176, 22);
            this.KsifreTxtbox.TabIndex = 21;
            // 
            // KadTxtbox
            // 
            this.KadTxtbox.Location = new System.Drawing.Point(301, 240);
            this.KadTxtbox.Name = "KadTxtbox";
            this.KadTxtbox.Size = new System.Drawing.Size(176, 22);
            this.KadTxtbox.TabIndex = 20;
            // 
            // Ksifre
            // 
            this.Ksifre.AutoSize = true;
            this.Ksifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ksifre.Location = new System.Drawing.Point(194, 283);
            this.Ksifre.Name = "Ksifre";
            this.Ksifre.Size = new System.Drawing.Size(101, 20);
            this.Ksifre.TabIndex = 19;
            this.Ksifre.Text = "Admin Şifre:";
            // 
            // Kad
            // 
            this.Kad.AutoSize = true;
            this.Kad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kad.Location = new System.Drawing.Point(205, 240);
            this.Kad.Name = "Kad";
            this.Kad.Size = new System.Drawing.Size(90, 20);
            this.Kad.TabIndex = 18;
            this.Kad.Text = "Admin Adı:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Loginbut);
            this.Controls.Add(this.KsifreTxtbox);
            this.Controls.Add(this.KadTxtbox);
            this.Controls.Add(this.Ksifre);
            this.Controls.Add(this.Kad);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Loginbut;
        private System.Windows.Forms.TextBox KsifreTxtbox;
        private System.Windows.Forms.TextBox KadTxtbox;
        private System.Windows.Forms.Label Ksifre;
        private System.Windows.Forms.Label Kad;
    }
}