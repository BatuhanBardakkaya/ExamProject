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
    public partial class FrmGirisekran : Form
    {
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public FrmGirisekran()
        {  
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void KadTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Loginbut_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from tblogrenci where ogrKAD='"+ KadTxtbox.Text+ "' and ogrSifre= '"+ KsifreTxtbox.Text +"'",connect);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frmogranasayfa frmogranasayfa = new Frmogranasayfa();
                frmogranasayfa.Show();
                connect.Close();
            }

        }

        private void Kayitolbut_Click(object sender, EventArgs e)
        {
            FrmOgrencikayit frm2 = new FrmOgrencikayit();
            frm2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void ogrtkayıtbtn_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm4 = new FrmAdminGiris();
            frm4.Show();
            this.Hide();
        }

        private void ogrtgirisbtn_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from lbtogrt where ogrtKad='" + ogrtKadtxt.Text + "' and ogrtKsifre= '" + ogrtsifretxt.Text + "'", connect);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgrtAnaEkran ogrtAnaEkran = new OgrtAnaEkran();
                ogrtAnaEkran.Show();
                

            }
            connect.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifredegistir frmSifredegistir = new FrmSifredegistir();
            frmSifredegistir.Show();
            this.Hide();

        }

        private void ogrtsifreunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifredegistir frmSifredegistir = new FrmSifredegistir();
            frmSifredegistir.Show();
            this.Hide();
        }
    }
}
