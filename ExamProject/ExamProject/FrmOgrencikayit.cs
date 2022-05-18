using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamProject
{
    public partial class FrmOgrencikayit : Form
    {
        public FrmOgrencikayit()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void Kytbutton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Kaydınız Başarıyla Gerçekleştirildi.");

            }
            catch (Exception hata) 
            {
                MessageBox.Show("Hata Meydana geldi." + hata.Message);

            }
            FrmGirisekran frm = new FrmGirisekran();
            frm.Show();
            this.Hide();
        }

        private void FrmOgrencikayit_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGirisekran frmGirisekran = new FrmGirisekran();
            frmGirisekran.Show();
            this.Hide();
        }
    }
}
