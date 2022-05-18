
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
            this.Loginbut = new System.Windows.Forms.Button();
            this.AdminSifreTxt = new System.Windows.Forms.TextBox();
            this.AdminTxt = new System.Windows.Forms.TextBox();
            this.Ksifre = new System.Windows.Forms.Label();
            this.Kad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.Loginbut.Click += new System.EventHandler(this.Loginbut_Click);
            // 
            // AdminSifreTxt
            // 
            this.AdminSifreTxt.Location = new System.Drawing.Point(301, 283);
            this.AdminSifreTxt.Name = "AdminSifreTxt";
            this.AdminSifreTxt.PasswordChar = '*';
            this.AdminSifreTxt.Size = new System.Drawing.Size(176, 22);
            this.AdminSifreTxt.TabIndex = 21;
            // 
            // AdminTxt
            // 
            this.AdminTxt.Location = new System.Drawing.Point(301, 240);
            this.AdminTxt.Name = "AdminTxt";
            this.AdminTxt.Size = new System.Drawing.Size(176, 22);
            this.AdminTxt.TabIndex = 20;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamProject.Properties.Resources.icons8_left_50;
            this.pictureBox1.Location = new System.Drawing.Point(757, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Loginbut);
            this.Controls.Add(this.AdminSifreTxt);
            this.Controls.Add(this.AdminTxt);
            this.Controls.Add(this.Ksifre);
            this.Controls.Add(this.Kad);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FrmAdminGiris";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Loginbut;
        private System.Windows.Forms.TextBox AdminSifreTxt;
        private System.Windows.Forms.TextBox AdminTxt;
        private System.Windows.Forms.Label Ksifre;
        private System.Windows.Forms.Label Kad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}