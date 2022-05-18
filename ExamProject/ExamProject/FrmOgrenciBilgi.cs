using System;
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
    public partial class FrmOgrenciBilgi : Form
    {
        public FrmOgrenciBilgi()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from tblogrenci where ogrKAD='" + KadTXT.Text + "' and ogrSifre= '" + KsifreTXT.Text + "'", connect);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {         
                LblOgrAd.Text = dr["ogrAD"].ToString();
                LblOgrSoyad.Text = dr["ogrSoyAd"].ToString();
                LblogrTelNo.Text = dr["ogrTelNO"].ToString();
                LblogrMail.Text = dr["ogrEmail"].ToString();
                connect.Close();
            }
        }

        private void FrmOgrenciBilgi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frmogranasayfa frmogranasayfa = new Frmogranasayfa();
            frmogranasayfa.Show();
            this.Hide();
        }
    }
}
