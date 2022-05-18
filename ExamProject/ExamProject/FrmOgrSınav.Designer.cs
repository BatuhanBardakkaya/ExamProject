
namespace ExamProject
{
    partial class FrmOgrSınav
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
            this.LblSoru = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.SnvBsltBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LblDK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSoru
            // 
            this.LblSoru.AllowDrop = true;
            this.LblSoru.Location = new System.Drawing.Point(102, 92);
            this.LblSoru.Name = "LblSoru";
            this.LblSoru.Size = new System.Drawing.Size(526, 117);
            this.LblSoru.TabIndex = 0;
            this.LblSoru.Text = "*****************************************************************";
            this.LblSoru.Click += new System.EventHandler(this.LblSoru_Click);
            // 
            // LblA
            // 
            this.LblA.Location = new System.Drawing.Point(235, 260);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(221, 36);
            this.LblA.TabIndex = 1;
            this.LblA.Text = "*************************";
            // 
            // SnvBsltBtn
            // 
            this.SnvBsltBtn.Location = new System.Drawing.Point(891, 420);
            this.SnvBsltBtn.Name = "SnvBsltBtn";
            this.SnvBsltBtn.Size = new System.Drawing.Size(185, 40);
            this.SnvBsltBtn.TabIndex = 2;
            this.SnvBsltBtn.Text = "Sınava Başla";
            this.SnvBsltBtn.UseVisualStyleBackColor = true;
            this.SnvBsltBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(832, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 242);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(105, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A-)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 341);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B-)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(105, 430);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 21);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C-)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(105, 500);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 21);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D-)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // LblB
            // 
            this.LblB.Location = new System.Drawing.Point(235, 341);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(221, 36);
            this.LblB.TabIndex = 11;
            this.LblB.Text = "*************************";
            // 
            // LblC
            // 
            this.LblC.Location = new System.Drawing.Point(235, 430);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(221, 36);
            this.LblC.TabIndex = 12;
            this.LblC.Text = "*************************";
            // 
            // LblD
            // 
            this.LblD.Location = new System.Drawing.Point(235, 500);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(221, 36);
            this.LblD.TabIndex = 13;
            this.LblD.Text = "*************************";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LblDK
            // 
            this.LblDK.AutoSize = true;
            this.LblDK.Location = new System.Drawing.Point(12, 9);
            this.LblDK.Name = "LblDK";
            this.LblDK.Size = new System.Drawing.Size(46, 17);
            this.LblDK.TabIndex = 14;
            this.LblDK.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = ".";
            // 
            // LblSec
            // 
            this.LblSec.AutoSize = true;
            this.LblSec.Location = new System.Drawing.Point(82, 9);
            this.LblSec.Name = "LblSec";
            this.LblSec.Size = new System.Drawing.Size(46, 17);
            this.LblSec.TabIndex = 16;
            this.LblSec.Text = "label3";
            // 
            // FrmOgrSınav
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 599);
            this.Controls.Add(this.LblSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDK);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SnvBsltBtn);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblSoru);
            this.Name = "FrmOgrSınav";
            this.Text = "FrmOgrSınav";
            this.Load += new System.EventHandler(this.FrmOgrSınav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSoru;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Button SnvBsltBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label LblDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSec;
    }
}