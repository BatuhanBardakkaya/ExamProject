
namespace ExamProject
{
    partial class FrmAdminAnaEkran
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
            this.BtnOgrtislem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Öğrenci = new System.Windows.Forms.Label();
            this.BtnOgrenciislem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSoruislem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOgrtislem
            // 
            this.BtnOgrtislem.Location = new System.Drawing.Point(145, 136);
            this.BtnOgrtislem.Name = "BtnOgrtislem";
            this.BtnOgrtislem.Size = new System.Drawing.Size(75, 23);
            this.BtnOgrtislem.TabIndex = 0;
            this.BtnOgrtislem.Text = "Göster";
            this.BtnOgrtislem.UseVisualStyleBackColor = true;
            this.BtnOgrtislem.Click += new System.EventHandler(this.BtnOgrtislem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğretmen İşlemleri";
            // 
            // Öğrenci
            // 
            this.Öğrenci.AutoSize = true;
            this.Öğrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Öğrenci.Location = new System.Drawing.Point(288, 186);
            this.Öğrenci.Name = "Öğrenci";
            this.Öğrenci.Size = new System.Drawing.Size(153, 20);
            this.Öğrenci.TabIndex = 4;
            this.Öğrenci.Text = "Öğrenci İşlemleri";
            // 
            // BtnOgrenciislem
            // 
            this.BtnOgrenciislem.Location = new System.Drawing.Point(366, 233);
            this.BtnOgrenciislem.Name = "BtnOgrenciislem";
            this.BtnOgrenciislem.Size = new System.Drawing.Size(75, 23);
            this.BtnOgrenciislem.TabIndex = 3;
            this.BtnOgrenciislem.Text = "Göster";
            this.BtnOgrenciislem.UseVisualStyleBackColor = true;
            this.BtnOgrenciislem.Click += new System.EventHandler(this.BtnOgrenciislem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(556, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soru İşlemleri";
            // 
            // BtnSoruislem
            // 
            this.BtnSoruislem.Location = new System.Drawing.Point(607, 330);
            this.BtnSoruislem.Name = "BtnSoruislem";
            this.BtnSoruislem.Size = new System.Drawing.Size(75, 23);
            this.BtnSoruislem.TabIndex = 5;
            this.BtnSoruislem.Text = "Göster";
            this.BtnSoruislem.UseVisualStyleBackColor = true;
            this.BtnSoruislem.Click += new System.EventHandler(this.BtnSoruislem_Click);
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
            // FrmAdminAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSoruislem);
            this.Controls.Add(this.Öğrenci);
            this.Controls.Add(this.BtnOgrenciislem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOgrtislem);
            this.Name = "FrmAdminAnaEkran";
            this.Text = "FrmAdminAnaEkran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrtislem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Öğrenci;
        private System.Windows.Forms.Button BtnOgrenciislem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSoruislem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}