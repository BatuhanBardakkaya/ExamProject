
namespace ExamProject
{
    partial class FrmAdminOgrt
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
            this.ogrtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtSoyADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtKadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtKsifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtTelNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtogrtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examdatabaseDataSet6 = new ExamProject.examdatabaseDataSet6();
            this.OgrtKytBtn = new System.Windows.Forms.Button();
            this.OgrtemailTXT = new System.Windows.Forms.TextBox();
            this.OgrtTelnoTXT = new System.Windows.Forms.TextBox();
            this.OgrtSifreTXT = new System.Windows.Forms.TextBox();
            this.OgrtKadTXT = new System.Windows.Forms.TextBox();
            this.OgrtSoyadTXT = new System.Windows.Forms.TextBox();
            this.OgrtAdTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtogrtTableAdapter = new ExamProject.examdatabaseDataSet6TableAdapters.lbtogrtTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbtogrtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrtIDDataGridViewTextBoxColumn,
            this.ogrtADDataGridViewTextBoxColumn,
            this.ogrtSoyADDataGridViewTextBoxColumn,
            this.ogrtKadDataGridViewTextBoxColumn,
            this.ogrtKsifreDataGridViewTextBoxColumn,
            this.ogrtTelNODataGridViewTextBoxColumn,
            this.ogrtEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lbtogrtBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 150);
            this.dataGridView1.TabIndex = 56;
            // 
            // ogrtIDDataGridViewTextBoxColumn
            // 
            this.ogrtIDDataGridViewTextBoxColumn.DataPropertyName = "ogrtID";
            this.ogrtIDDataGridViewTextBoxColumn.HeaderText = "ogrtID";
            this.ogrtIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtIDDataGridViewTextBoxColumn.Name = "ogrtIDDataGridViewTextBoxColumn";
            this.ogrtIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrtIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtADDataGridViewTextBoxColumn
            // 
            this.ogrtADDataGridViewTextBoxColumn.DataPropertyName = "ogrtAD";
            this.ogrtADDataGridViewTextBoxColumn.HeaderText = "ogrtAD";
            this.ogrtADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtADDataGridViewTextBoxColumn.Name = "ogrtADDataGridViewTextBoxColumn";
            this.ogrtADDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtSoyADDataGridViewTextBoxColumn
            // 
            this.ogrtSoyADDataGridViewTextBoxColumn.DataPropertyName = "ogrtSoyAD";
            this.ogrtSoyADDataGridViewTextBoxColumn.HeaderText = "ogrtSoyAD";
            this.ogrtSoyADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtSoyADDataGridViewTextBoxColumn.Name = "ogrtSoyADDataGridViewTextBoxColumn";
            this.ogrtSoyADDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtKadDataGridViewTextBoxColumn
            // 
            this.ogrtKadDataGridViewTextBoxColumn.DataPropertyName = "ogrtKad";
            this.ogrtKadDataGridViewTextBoxColumn.HeaderText = "ogrtKad";
            this.ogrtKadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtKadDataGridViewTextBoxColumn.Name = "ogrtKadDataGridViewTextBoxColumn";
            this.ogrtKadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtKsifreDataGridViewTextBoxColumn
            // 
            this.ogrtKsifreDataGridViewTextBoxColumn.DataPropertyName = "ogrtKsifre";
            this.ogrtKsifreDataGridViewTextBoxColumn.HeaderText = "ogrtKsifre";
            this.ogrtKsifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtKsifreDataGridViewTextBoxColumn.Name = "ogrtKsifreDataGridViewTextBoxColumn";
            this.ogrtKsifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtTelNODataGridViewTextBoxColumn
            // 
            this.ogrtTelNODataGridViewTextBoxColumn.DataPropertyName = "ogrtTelNO";
            this.ogrtTelNODataGridViewTextBoxColumn.HeaderText = "ogrtTelNO";
            this.ogrtTelNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtTelNODataGridViewTextBoxColumn.Name = "ogrtTelNODataGridViewTextBoxColumn";
            this.ogrtTelNODataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtEmailDataGridViewTextBoxColumn
            // 
            this.ogrtEmailDataGridViewTextBoxColumn.DataPropertyName = "ogrtEmail";
            this.ogrtEmailDataGridViewTextBoxColumn.HeaderText = "ogrtEmail";
            this.ogrtEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtEmailDataGridViewTextBoxColumn.Name = "ogrtEmailDataGridViewTextBoxColumn";
            this.ogrtEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // lbtogrtBindingSource
            // 
            this.lbtogrtBindingSource.DataMember = "lbtogrt";
            this.lbtogrtBindingSource.DataSource = this.examdatabaseDataSet6;
            // 
            // examdatabaseDataSet6
            // 
            this.examdatabaseDataSet6.DataSetName = "examdatabaseDataSet6";
            this.examdatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OgrtKytBtn
            // 
            this.OgrtKytBtn.Location = new System.Drawing.Point(369, 250);
            this.OgrtKytBtn.Name = "OgrtKytBtn";
            this.OgrtKytBtn.Size = new System.Drawing.Size(119, 28);
            this.OgrtKytBtn.TabIndex = 54;
            this.OgrtKytBtn.Text = "Kaydet";
            this.OgrtKytBtn.UseVisualStyleBackColor = true;
            this.OgrtKytBtn.Click += new System.EventHandler(this.SoruKayıtbtn_Click);
            // 
            // OgrtemailTXT
            // 
            this.OgrtemailTXT.Location = new System.Drawing.Point(343, 222);
            this.OgrtemailTXT.Name = "OgrtemailTXT";
            this.OgrtemailTXT.Size = new System.Drawing.Size(174, 22);
            this.OgrtemailTXT.TabIndex = 6;
            // 
            // OgrtTelnoTXT
            // 
            this.OgrtTelnoTXT.Location = new System.Drawing.Point(343, 191);
            this.OgrtTelnoTXT.Name = "OgrtTelnoTXT";
            this.OgrtTelnoTXT.Size = new System.Drawing.Size(174, 22);
            this.OgrtTelnoTXT.TabIndex = 5;
            // 
            // OgrtSifreTXT
            // 
            this.OgrtSifreTXT.Location = new System.Drawing.Point(343, 160);
            this.OgrtSifreTXT.Name = "OgrtSifreTXT";
            this.OgrtSifreTXT.Size = new System.Drawing.Size(174, 22);
            this.OgrtSifreTXT.TabIndex = 4;
            // 
            // OgrtKadTXT
            // 
            this.OgrtKadTXT.Location = new System.Drawing.Point(343, 129);
            this.OgrtKadTXT.Name = "OgrtKadTXT";
            this.OgrtKadTXT.Size = new System.Drawing.Size(174, 22);
            this.OgrtKadTXT.TabIndex = 3;
            // 
            // OgrtSoyadTXT
            // 
            this.OgrtSoyadTXT.Location = new System.Drawing.Point(343, 98);
            this.OgrtSoyadTXT.Name = "OgrtSoyadTXT";
            this.OgrtSoyadTXT.Size = new System.Drawing.Size(174, 22);
            this.OgrtSoyadTXT.TabIndex = 2;
            // 
            // OgrtAdTXT
            // 
            this.OgrtAdTXT.Location = new System.Drawing.Point(343, 67);
            this.OgrtAdTXT.Name = "OgrtAdTXT";
            this.OgrtAdTXT.Size = new System.Drawing.Size(174, 22);
            this.OgrtAdTXT.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(37, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Öğretmen Telefon Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(145, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Öğretmen Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Öğretmen Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(158, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Öğretmen Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(129, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Öğretmen Soyadı:";
            // 
            // lbtogrtTableAdapter
            // 
            this.lbtogrtTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Öğretmen E-mail Adresi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamProject.Properties.Resources.icons8_left_50;
            this.pictureBox1.Location = new System.Drawing.Point(877, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmAdminOgrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OgrtKytBtn);
            this.Controls.Add(this.OgrtemailTXT);
            this.Controls.Add(this.OgrtTelnoTXT);
            this.Controls.Add(this.OgrtSifreTXT);
            this.Controls.Add(this.OgrtKadTXT);
            this.Controls.Add(this.OgrtSoyadTXT);
            this.Controls.Add(this.OgrtAdTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "FrmAdminOgrt";
            this.Text = "FrmAdminOgrt";
            this.Load += new System.EventHandler(this.FrmAdminOgrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbtogrtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OgrtKytBtn;
        private System.Windows.Forms.TextBox OgrtemailTXT;
        private System.Windows.Forms.TextBox OgrtTelnoTXT;
        private System.Windows.Forms.TextBox OgrtSifreTXT;
        private System.Windows.Forms.TextBox OgrtKadTXT;
        private System.Windows.Forms.TextBox OgrtSoyadTXT;
        private System.Windows.Forms.TextBox OgrtAdTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private examdatabaseDataSet6 examdatabaseDataSet6;
        private System.Windows.Forms.BindingSource lbtogrtBindingSource;
        private examdatabaseDataSet6TableAdapters.lbtogrtTableAdapter lbtogrtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtSoyADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtKadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtKsifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtTelNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}