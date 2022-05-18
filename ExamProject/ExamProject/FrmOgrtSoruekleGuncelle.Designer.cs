
namespace ExamProject
{
    partial class FrmOgrtSoruekleGuncelle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SoruRTXT = new System.Windows.Forms.RichTextBox();
            this.ASIKTXT = new System.Windows.Forms.TextBox();
            this.BSIKTXT = new System.Windows.Forms.TextBox();
            this.CSIKTXT = new System.Windows.Forms.TextBox();
            this.DSIKTXT = new System.Windows.Forms.TextBox();
            this.DOGRUSIKTXT = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SoruKayıtbtn = new System.Windows.Forms.Button();
            this.Gorselbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soruIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogruSIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSoruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examdatabaseDataSet3 = new ExamProject.examdatabaseDataSet3();
            this.tblSoruTableAdapter = new ExamProject.examdatabaseDataSet3TableAdapters.tblSoruTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSoruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "A Şıkkı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "B Şıkkı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "D Şıkkı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(68, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "C Şıkkı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(44, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doğru Şık:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(71, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Görsel:";
            // 
            // SoruRTXT
            // 
            this.SoruRTXT.Location = new System.Drawing.Point(136, 85);
            this.SoruRTXT.Name = "SoruRTXT";
            this.SoruRTXT.Size = new System.Drawing.Size(716, 97);
            this.SoruRTXT.TabIndex = 1;
            this.SoruRTXT.Text = "";
            // 
            // ASIKTXT
            // 
            this.ASIKTXT.Location = new System.Drawing.Point(146, 195);
            this.ASIKTXT.Name = "ASIKTXT";
            this.ASIKTXT.Size = new System.Drawing.Size(110, 22);
            this.ASIKTXT.TabIndex = 2;
            // 
            // BSIKTXT
            // 
            this.BSIKTXT.Location = new System.Drawing.Point(148, 227);
            this.BSIKTXT.Name = "BSIKTXT";
            this.BSIKTXT.Size = new System.Drawing.Size(110, 22);
            this.BSIKTXT.TabIndex = 3;
            // 
            // CSIKTXT
            // 
            this.CSIKTXT.Location = new System.Drawing.Point(148, 259);
            this.CSIKTXT.Name = "CSIKTXT";
            this.CSIKTXT.Size = new System.Drawing.Size(110, 22);
            this.CSIKTXT.TabIndex = 4;
            // 
            // DSIKTXT
            // 
            this.DSIKTXT.Location = new System.Drawing.Point(148, 291);
            this.DSIKTXT.Name = "DSIKTXT";
            this.DSIKTXT.Size = new System.Drawing.Size(110, 22);
            this.DSIKTXT.TabIndex = 5;
            // 
            // DOGRUSIKTXT
            // 
            this.DOGRUSIKTXT.Location = new System.Drawing.Point(148, 323);
            this.DOGRUSIKTXT.Name = "DOGRUSIKTXT";
            this.DOGRUSIKTXT.Size = new System.Drawing.Size(110, 22);
            this.DOGRUSIKTXT.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 355);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 22);
            this.textBox7.TabIndex = 7;
            // 
            // SoruKayıtbtn
            // 
            this.SoruKayıtbtn.Location = new System.Drawing.Point(159, 383);
            this.SoruKayıtbtn.Name = "SoruKayıtbtn";
            this.SoruKayıtbtn.Size = new System.Drawing.Size(87, 28);
            this.SoruKayıtbtn.TabIndex = 16;
            this.SoruKayıtbtn.Text = "Kaydet";
            this.SoruKayıtbtn.UseVisualStyleBackColor = true;
            this.SoruKayıtbtn.Click += new System.EventHandler(this.SoruKayıtbtn_Click);
            // 
            // Gorselbtn
            // 
            this.Gorselbtn.BackColor = System.Drawing.Color.White;
            this.Gorselbtn.Location = new System.Drawing.Point(264, 355);
            this.Gorselbtn.Name = "Gorselbtn";
            this.Gorselbtn.Size = new System.Drawing.Size(32, 22);
            this.Gorselbtn.TabIndex = 18;
            this.Gorselbtn.Text = "...";
            this.Gorselbtn.UseVisualStyleBackColor = false;
            this.Gorselbtn.Click += new System.EventHandler(this.Gorselbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(472, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruIdDataGridViewTextBoxColumn,
            this.soruDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.dogruSIKDataGridViewTextBoxColumn,
            this.gorselDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSoruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // soruIdDataGridViewTextBoxColumn
            // 
            this.soruIdDataGridViewTextBoxColumn.DataPropertyName = "SoruId";
            this.soruIdDataGridViewTextBoxColumn.HeaderText = "SoruId";
            this.soruIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soruIdDataGridViewTextBoxColumn.Name = "soruIdDataGridViewTextBoxColumn";
            this.soruIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.soruIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // soruDataGridViewTextBoxColumn
            // 
            this.soruDataGridViewTextBoxColumn.DataPropertyName = "Soru";
            this.soruDataGridViewTextBoxColumn.HeaderText = "Soru";
            this.soruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soruDataGridViewTextBoxColumn.Name = "soruDataGridViewTextBoxColumn";
            this.soruDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "A";
            this.aDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.Width = 125;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.Width = 125;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 125;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            this.dDataGridViewTextBoxColumn.HeaderText = "D";
            this.dDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogruSIKDataGridViewTextBoxColumn
            // 
            this.dogruSIKDataGridViewTextBoxColumn.DataPropertyName = "DogruSIK";
            this.dogruSIKDataGridViewTextBoxColumn.HeaderText = "DogruSIK";
            this.dogruSIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogruSIKDataGridViewTextBoxColumn.Name = "dogruSIKDataGridViewTextBoxColumn";
            this.dogruSIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // gorselDataGridViewTextBoxColumn
            // 
            this.gorselDataGridViewTextBoxColumn.DataPropertyName = "Gorsel";
            this.gorselDataGridViewTextBoxColumn.HeaderText = "Gorsel";
            this.gorselDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gorselDataGridViewTextBoxColumn.Name = "gorselDataGridViewTextBoxColumn";
            this.gorselDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblSoruBindingSource
            // 
            this.tblSoruBindingSource.DataMember = "tblSoru";
            this.tblSoruBindingSource.DataSource = this.examdatabaseDataSet3;
            // 
            // examdatabaseDataSet3
            // 
            this.examdatabaseDataSet3.DataSetName = "examdatabaseDataSet3";
            this.examdatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSoruTableAdapter
            // 
            this.tblSoruTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExamProject.Properties.Resources.icons8_left_50;
            this.pictureBox2.Location = new System.Drawing.Point(853, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmOgrtSoruekleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 642);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gorselbtn);
            this.Controls.Add(this.SoruKayıtbtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.DOGRUSIKTXT);
            this.Controls.Add(this.DSIKTXT);
            this.Controls.Add(this.CSIKTXT);
            this.Controls.Add(this.BSIKTXT);
            this.Controls.Add(this.ASIKTXT);
            this.Controls.Add(this.SoruRTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FrmOgrtSoruekleGuncelle";
            this.Text = "FrmOgrtSoruekleGuncelle";
            this.Load += new System.EventHandler(this.FrmOgrtSoruekleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSoruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox SoruRTXT;
        private System.Windows.Forms.TextBox ASIKTXT;
        private System.Windows.Forms.TextBox BSIKTXT;
        private System.Windows.Forms.TextBox CSIKTXT;
        private System.Windows.Forms.TextBox DSIKTXT;
        private System.Windows.Forms.TextBox DOGRUSIKTXT;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button SoruKayıtbtn;
        private System.Windows.Forms.Button Gorselbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private examdatabaseDataSet3 examdatabaseDataSet3;
        private System.Windows.Forms.BindingSource tblSoruBindingSource;
        private examdatabaseDataSet3TableAdapters.tblSoruTableAdapter tblSoruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogruSIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorselDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}