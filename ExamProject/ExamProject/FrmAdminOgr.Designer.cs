
namespace ExamProject
{
    partial class FrmAdminOgr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examdatabaseDataSet5 = new ExamProject.examdatabaseDataSet5();
            this.OgrKytbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblogrenciTableAdapter = new ExamProject.examdatabaseDataSet5TableAdapters.tblogrenciTableAdapter();
            this.Kyttelnotxt = new System.Windows.Forms.TextBox();
            this.Kytadtxt = new System.Windows.Forms.TextBox();
            this.Kytemailtxt = new System.Windows.Forms.TextBox();
            this.KytKadtxt = new System.Windows.Forms.TextBox();
            this.Kytsoyadtxt = new System.Windows.Forms.TextBox();
            this.KytKsifretxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrADDataGridViewTextBoxColumn,
            this.ogrSoyAdDataGridViewTextBoxColumn,
            this.ogrKADDataGridViewTextBoxColumn,
            this.ogrSifreDataGridViewTextBoxColumn,
            this.ogrTelNODataGridViewTextBoxColumn,
            this.ogrEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 150);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrADDataGridViewTextBoxColumn
            // 
            this.ogrADDataGridViewTextBoxColumn.DataPropertyName = "ogrAD";
            this.ogrADDataGridViewTextBoxColumn.HeaderText = "ogrAD";
            this.ogrADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrADDataGridViewTextBoxColumn.Name = "ogrADDataGridViewTextBoxColumn";
            this.ogrADDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyAdDataGridViewTextBoxColumn
            // 
            this.ogrSoyAdDataGridViewTextBoxColumn.DataPropertyName = "ogrSoyAd";
            this.ogrSoyAdDataGridViewTextBoxColumn.HeaderText = "ogrSoyAd";
            this.ogrSoyAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyAdDataGridViewTextBoxColumn.Name = "ogrSoyAdDataGridViewTextBoxColumn";
            this.ogrSoyAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrKADDataGridViewTextBoxColumn
            // 
            this.ogrKADDataGridViewTextBoxColumn.DataPropertyName = "ogrKAD";
            this.ogrKADDataGridViewTextBoxColumn.HeaderText = "ogrKAD";
            this.ogrKADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrKADDataGridViewTextBoxColumn.Name = "ogrKADDataGridViewTextBoxColumn";
            this.ogrKADDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSifreDataGridViewTextBoxColumn
            // 
            this.ogrSifreDataGridViewTextBoxColumn.DataPropertyName = "ogrSifre";
            this.ogrSifreDataGridViewTextBoxColumn.HeaderText = "ogrSifre";
            this.ogrSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSifreDataGridViewTextBoxColumn.Name = "ogrSifreDataGridViewTextBoxColumn";
            this.ogrSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrTelNODataGridViewTextBoxColumn
            // 
            this.ogrTelNODataGridViewTextBoxColumn.DataPropertyName = "ogrTelNO";
            this.ogrTelNODataGridViewTextBoxColumn.HeaderText = "ogrTelNO";
            this.ogrTelNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTelNODataGridViewTextBoxColumn.Name = "ogrTelNODataGridViewTextBoxColumn";
            this.ogrTelNODataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrEmailDataGridViewTextBoxColumn
            // 
            this.ogrEmailDataGridViewTextBoxColumn.DataPropertyName = "ogrEmail";
            this.ogrEmailDataGridViewTextBoxColumn.HeaderText = "ogrEmail";
            this.ogrEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrEmailDataGridViewTextBoxColumn.Name = "ogrEmailDataGridViewTextBoxColumn";
            this.ogrEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblogrenciBindingSource
            // 
            this.tblogrenciBindingSource.DataMember = "tblogrenci";
            this.tblogrenciBindingSource.DataSource = this.examdatabaseDataSet5;
            // 
            // examdatabaseDataSet5
            // 
            this.examdatabaseDataSet5.DataSetName = "examdatabaseDataSet5";
            this.examdatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OgrKytbtn
            // 
            this.OgrKytbtn.Location = new System.Drawing.Point(312, 229);
            this.OgrKytbtn.Name = "OgrKytbtn";
            this.OgrKytbtn.Size = new System.Drawing.Size(84, 28);
            this.OgrKytbtn.TabIndex = 37;
            this.OgrKytbtn.Text = "Kaydet";
            this.OgrKytbtn.UseVisualStyleBackColor = true;
            this.OgrKytbtn.Click += new System.EventHandler(this.OgrKytbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Öğrenci E-Mail Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Öğrenci Telefon Numara:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(106, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Öğrenci Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Öğrenci Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Öğrenci Kullanıcı Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // tblogrenciTableAdapter
            // 
            this.tblogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // Kyttelnotxt
            // 
            this.Kyttelnotxt.Location = new System.Drawing.Point(257, 159);
            this.Kyttelnotxt.Name = "Kyttelnotxt";
            this.Kyttelnotxt.Size = new System.Drawing.Size(199, 22);
            this.Kyttelnotxt.TabIndex = 5;
            // 
            // Kytadtxt
            // 
            this.Kytadtxt.Location = new System.Drawing.Point(257, 29);
            this.Kytadtxt.Name = "Kytadtxt";
            this.Kytadtxt.Size = new System.Drawing.Size(199, 22);
            this.Kytadtxt.TabIndex = 1;
            // 
            // Kytemailtxt
            // 
            this.Kytemailtxt.Location = new System.Drawing.Point(257, 191);
            this.Kytemailtxt.Name = "Kytemailtxt";
            this.Kytemailtxt.Size = new System.Drawing.Size(199, 22);
            this.Kytemailtxt.TabIndex = 6;
            // 
            // KytKadtxt
            // 
            this.KytKadtxt.Location = new System.Drawing.Point(257, 99);
            this.KytKadtxt.Name = "KytKadtxt";
            this.KytKadtxt.Size = new System.Drawing.Size(199, 22);
            this.KytKadtxt.TabIndex = 3;
            // 
            // Kytsoyadtxt
            // 
            this.Kytsoyadtxt.Location = new System.Drawing.Point(257, 61);
            this.Kytsoyadtxt.Name = "Kytsoyadtxt";
            this.Kytsoyadtxt.Size = new System.Drawing.Size(199, 22);
            this.Kytsoyadtxt.TabIndex = 2;
            // 
            // KytKsifretxt
            // 
            this.KytKsifretxt.Location = new System.Drawing.Point(257, 131);
            this.KytKsifretxt.Name = "KytKsifretxt";
            this.KytKsifretxt.Size = new System.Drawing.Size(199, 22);
            this.KytKsifretxt.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamProject.Properties.Resources.icons8_left_50;
            this.pictureBox1.Location = new System.Drawing.Point(939, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmAdminOgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KytKsifretxt);
            this.Controls.Add(this.Kyttelnotxt);
            this.Controls.Add(this.Kytadtxt);
            this.Controls.Add(this.Kytemailtxt);
            this.Controls.Add(this.KytKadtxt);
            this.Controls.Add(this.Kytsoyadtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OgrKytbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdminOgr";
            this.Text = "FrmAdminOgr";
            this.Load += new System.EventHandler(this.FrmAdminOgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OgrKytbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private examdatabaseDataSet5 examdatabaseDataSet5;
        private System.Windows.Forms.BindingSource tblogrenciBindingSource;
        private examdatabaseDataSet5TableAdapters.tblogrenciTableAdapter tblogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Kyttelnotxt;
        private System.Windows.Forms.TextBox Kytadtxt;
        private System.Windows.Forms.TextBox Kytemailtxt;
        private System.Windows.Forms.TextBox KytKadtxt;
        private System.Windows.Forms.TextBox Kytsoyadtxt;
        private System.Windows.Forms.TextBox KytKsifretxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}