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
using System.IO;

namespace ExamProject
{
    public partial class FrmAdminSoru : Form
    {
        public FrmAdminSoru()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        string imagepath;

        private void FrmAdminSoru_Load(object sender, EventArgs e)
        {
            FrmOgrtSoruekleGuncelle.TabloDegercek(connect, dataGridView1, "tblSoru");

            // TODO: This line of code loads data into the 'examdatabaseDataSet4.tblSoru' table. You can move, or remove it, as needed.
            // this.tblSoruTableAdapter.Fill(this.examdatabaseDataSet4.tblSoru);

        }

        private void SoruKayıtbtn_Click(object sender, EventArgs e)
        {

            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string soruekle = "insert into tblSoru(Soru,A,B,C,D,DogruSIK,Gorseller)values(@Soru,@A,@B,@C,@D,@DogruSIK,@Gorseller)";
                SqlCommand komut = new SqlCommand(soruekle, connect);

                komut.Parameters.AddWithValue("@Soru", SoruRTXT.Text);
                komut.Parameters.AddWithValue("@A", ASIKTXT.Text);
                komut.Parameters.AddWithValue("@B", BSIKTXT.Text);
                komut.Parameters.AddWithValue("@C", CSIKTXT.Text);
                komut.Parameters.AddWithValue("@D", DSIKTXT.Text);
                komut.Parameters.AddWithValue("@DogruSIK", DOGRUSIKTXT.Text);
                komut.Parameters.Add("@Gorseller", SqlDbType.Image, resim.Length).Value = resim;
                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Sorunuz Başarıyla Eklendi.");
                FrmOgrtSoruekleGuncelle.TabloDegercek(connect, dataGridView1, "tblSoru");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana geldi." + hata.Message);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAdminAnaEkran frmAdminAnaEkran = new FrmAdminAnaEkran();
            frmAdminAnaEkran.Show();
            this.Hide();


            //  FrmOgrtSoruekleGuncelle.TabloDegercek();
        }

        private void Gorselbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg dosyaları(*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpeg | Png Dosyaları(*.png) | *.png ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;

            }
        }
    }
}

