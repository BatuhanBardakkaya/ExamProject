
namespace ExamProject
{
    partial class OgrtAnaEkran
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBilgiler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kupa Sınav Sistemine Hoşgeldiniz\r\n";
            // 
            // BtnBilgiler
            // 
            this.BtnBilgiler.Location = new System.Drawing.Point(472, 340);
            this.BtnBilgiler.Name = "BtnBilgiler";
            this.BtnBilgiler.Size = new System.Drawing.Size(208, 29);
            this.BtnBilgiler.TabIndex = 10;
            this.BtnBilgiler.Text = "Öğrenci Bilgilerimi Göster";
            this.BtnBilgiler.UseVisualStyleBackColor = true;
            this.BtnBilgiler.Click += new System.EventHandler(this.BtnBilgiler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(383, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Öğrenci Bilgilerinizi Görmek İçin Butona Basınız";
            // 
            // BtnBasla
            // 
            this.BtnBasla.Location = new System.Drawing.Point(92, 211);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(207, 29);
            this.BtnBasla.TabIndex = 12;
            this.BtnBasla.Text = "Soru Ekleme ";
            this.BtnBasla.UseVisualStyleBackColor = true;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soru Eklemek İçin Butona Basınız";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamProject.Properties.Resources.icons8_left_50;
            this.pictureBox1.Location = new System.Drawing.Point(757, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OgrtAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBilgiler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "OgrtAnaEkran";
            this.Text = "OgrtAnaEkran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBilgiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}