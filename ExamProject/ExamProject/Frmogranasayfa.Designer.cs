﻿
namespace ExamProject
{
    partial class Frmogranasayfa
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBilgiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kupa Sınav Sistemine Hoşgeldin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınava Başlamak İçin Butona Basınız";
            // 
            // BtnBasla
            // 
            this.BtnBasla.Location = new System.Drawing.Point(105, 204);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(143, 29);
            this.BtnBasla.TabIndex = 6;
            this.BtnBasla.Text = "Başla";
            this.BtnBasla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(351, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bilgilerinizi Görmek İçin Butona Basınız";
            // 
            // BtnBilgiler
            // 
            this.BtnBilgiler.Location = new System.Drawing.Point(431, 330);
            this.BtnBilgiler.Name = "BtnBilgiler";
            this.BtnBilgiler.Size = new System.Drawing.Size(143, 29);
            this.BtnBilgiler.TabIndex = 8;
            this.BtnBilgiler.Text = "Bilgilerimi Göster";
            this.BtnBilgiler.UseVisualStyleBackColor = true;
            // 
            // Frmogranasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBilgiler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmogranasayfa";
            this.Text = "Frmogranasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBilgiler;
    }
}