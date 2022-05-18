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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect=new SqlConnection(constring);

        private void Kytbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into lbtogrt(ogrtAD,ogrtSoyAD,ogrtKad,ogrtKsifre,ogrtTelNO,ogrtEmail)values(@ogrtAD,@ogrtSoyAD,@ogrtKad,@ogrtKsifre,@ogrtTelNO,@ogrtEmail)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@ogrtAD", ogrtKytadtxt.Text);
                komut.Parameters.AddWithValue("@ogrtSoyAD", ogrtKytsoyadtxt.Text);
                komut.Parameters.AddWithValue("@ogrtKad", ogrtKytKadtxt.Text);
                komut.Parameters.AddWithValue("@ogrtKsifre", ogrtKytKsifretxt.Text);
                komut.Parameters.AddWithValue("@ogrtTelNO", ogrtKyttelnotxt.Text);
                komut.Parameters.AddWithValue("@ogrtEmail", ogrtKytemailtxt.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGirisekran frmGirisekran = new FrmGirisekran();
            frmGirisekran.Show();
            this.Hide();
        }
    }
}
