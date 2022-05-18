﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class FrmOgrtOgrencibilgi : Form
    {
        public FrmOgrtOgrencibilgi()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private void OgrKytbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into tblogrenci(ogrAD,ogrSoyAd,ogrKAD,ogrSifre,ogrTelNO,ogrEmail)values(@ogrAD,@ogrSoyAd,@ogrKAD,@ogrSifre,@ogrTelNO,@ogrEmail)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@ogrAD", Kytadtxt.Text);
                komut.Parameters.AddWithValue("@ogrSoyAd", Kytsoyadtxt.Text);
                komut.Parameters.AddWithValue("@ogrKAD", KytKadtxt.Text);
                komut.Parameters.AddWithValue("@ogrSifre", KytKsifretxt.Text);
                komut.Parameters.AddWithValue("@ogrTelNO", Kyttelnotxt.Text);
                komut.Parameters.AddWithValue("@ogrEmail", Kytemailtxt.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Öğrenci Kaydınız Başarıyla Oluşturuldu.");
                FrmOgrtSoruekleGuncelle.TabloDegercek(connect, dataGridView1, "tblogrenci");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana geldi." + hata.Message);

            }

        }

        private void FrmOgrtOgrencibilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examdatabaseDataSet7.tblogrenci' table. You can move, or remove it, as needed.
            this.tblogrenciTableAdapter.Fill(this.examdatabaseDataSet7.tblogrenci);
            FrmOgrtSoruekleGuncelle.TabloDegercek(connect, dataGridView1, "tblogrenci");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OgrtAnaEkran ogrtAnaEkran = new OgrtAnaEkran();
            ogrtAnaEkran.Show();
            this.Hide();
        }
    }
}
