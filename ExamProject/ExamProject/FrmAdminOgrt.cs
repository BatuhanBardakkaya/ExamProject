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
    public partial class FrmAdminOgrt : Form
    {
        public FrmAdminOgrt()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private void FrmAdminOgrt_Load(object sender, EventArgs e)
        {
            FrmOgrtSoruekleGuncelle.TabloDegercek(connect, dataGridView1, "lbtogrt");
            // TODO: This line of code loads data into the 'examdatabaseDataSet6.lbtogrt' table. You can move, or remove it, as needed.
            // this.lbtogrtTableAdapter.Fill(this.examdatabaseDataSet6.lbtogrt);

        }

        private void SoruKayıtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string soruekle = "insert into lbtogrt(ogrtAD,ogrtSoyAD,ogrtKad,ogrtKsifre,ogrtTelNO,ogrtEmail)values(@ogrtAD,@ogrtSoyAD,@ogrtKad,@ogrtKsifre,@ogrtTelNO,@ogrtEmai)";
                SqlCommand komut = new SqlCommand(soruekle, connect);

                komut.Parameters.AddWithValue("@ogrtAD", OgrtAdTXT.Text);
                komut.Parameters.AddWithValue("@ogrtSoyAD", OgrtSoyadTXT.Text);
                komut.Parameters.AddWithValue("@ogrtKad", OgrtKadTXT.Text);
                komut.Parameters.AddWithValue("@ogrtKsifre", OgrtSifreTXT.Text);
                komut.Parameters.AddWithValue("@ogrtTelNO", OgrtTelnoTXT.Text);
                komut.Parameters.AddWithValue("@ogrtEmai", OgrtemailTXT.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Öğretmen Kaydınız Başarıyla Oluştu.");
                FrmOgrtSoruekleGuncelle.TabloDegercek(connect, dataGridView1, "tblogrt");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana geldi." + hata.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdminAnaEkran frmAdminAnaEkran = new FrmAdminAnaEkran();
            frmAdminAnaEkran.Show();
            this.Hide();
        }
    }
}
