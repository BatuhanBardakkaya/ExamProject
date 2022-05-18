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
    public partial class FrmOgrSınav : Form
    {
        public FrmOgrSınav()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        int min = 9, second = 59;
        int SoruID = 1;
        int ss = 0, sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
          
            gorunurlukayar(true);
            SqlCommand komut = new SqlCommand($"select * from tblSoru where SorId={SoruID}", connect);
            SqlDataReader dr = komut.ExecuteReader();

            SnvBsltBtn.Text = "Cevabı Onayla";
            if (ss<15)
            {
                while (dr.Read())
                {
                    ss++;
                    LblSoru.Text = dr["Soru"].ToString();
                    LblA.Text = dr["A"].ToString();
                    LblB.Text = dr["B"].ToString();
                    LblC.Text = dr["C"].ToString();
                    LblD.Text = dr["D"].ToString();
                    if (!Convert.IsDBNull(dr["Gorseller"]))
                    {
                        byte[] image = new byte[0];
                        image = (byte[])(dr["Gorseller"]);


                    }
                    else
                        pictureBox1.Image = null;

                    string DogruSık = dr["DogruSIK"].ToString();

                    if ((radioButton1.Checked && DogruSık=="A")|| (radioButton2.Checked && DogruSık == "B") || (radioButton3.Checked && DogruSık == "C") || (radioButton4.Checked && DogruSık == "D"))
                    {
                        sayac++;
                    }
                    SoruID++;
                    //MessageBox.Show("soru ıd"+SoruID+"SS:"+ss);
                }
            }

            if (ss==15)
            {
                MessageBox.Show($"Sınavın Sonuna Geldin!{sayac} Sorun Doğru {ss-sayac} Sorun Yanlış");
                this.Close();
                Frmogranasayfa frmogranasayfa = new Frmogranasayfa();
                frmogranasayfa.Show();
                this.Hide();
            }
            dr.Close();
            connect.Close();
        }

        private void LblSoru_Click(object sender, EventArgs e)
        {

        }

        private void FrmOgrSınav_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            LblDK.Text = 9.ToString();
            LblSec.Text = 60.ToString();
            gorunurlukayar(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            min--;
            LblDK.Text = min.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (second==0)
            {
                second = 59;
            }
            LblSec.Text = second.ToString();
            second--;

            if (min <=0 && second<=1)
            {
                LblDK.Text = "0";
                LblSec.Text = "0";
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Sınav Süreniz Sona Ermiştir!");
                this.Hide();
            }
           


        }

        void gorunurlukayar(bool acıkmı)
        {
            LblSec.Visible = acıkmı;
            LblA.Visible = acıkmı;
            LblB.Visible = acıkmı;
            LblC.Visible = acıkmı;
            LblD.Visible = acıkmı;
            LblDK.Visible = acıkmı;
            pictureBox1.Visible = acıkmı;
            radioButton1.Visible = acıkmı;
            radioButton2.Visible = acıkmı;
            radioButton3.Visible = acıkmı;
            radioButton4.Visible = acıkmı;

            if (acıkmı)
            {
                timer1.Start();
                timer2.Start();
            }
        }
    }
}
