using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class FrmSifredegistir : Form
    {
        public FrmSifredegistir()
        {
            InitializeComponent();
        }
        bool hesapvarmi = false;
        static string constring = "Data Source=DESKTOP-77L4ADL\\SQLEXPRESS;Initial Catalog=examdatabase;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void FrmSifredegistir_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void BtnSifreDegis_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut;
            SqlDataReader dr;


            if (radioButton1.Checked)
            {
                komut = new SqlCommand($"select * from tblogrenci where ogrEmail='{MailTXT.Text}'", connect);
                kayitsorgulama("tblOgrenci", connect);
            }
            else
            {
                komut = new SqlCommand($"select * from tblogrenci where ogrEmail='{MailTXT.Text}'", connect);
                kayitsorgulama("lbtogrt", connect);
            }
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadres = ("orumcekadam414141@gmail.com");//kendi mail yaz
                    String sifre = "sorumcek41";//benim mail şifresi...https://www.youtube.com/watch?v=sVGGj1Ya_qU güvenliği düşürmeleiyiz
                    String smtpsrvr = "smtp.gmail.com";
                    String kime = (dr["ogrEmail"].ToString());
                    String konu = "Şifre Hatırlatma Talebi";
                    String yaz = ("Sayın " + dr["ogrAD"].ToString() + " " + dr["ogrSoyAd"].ToString() + "\n" + "Bizden " + tarih + " tarihinde şifre hatırlatma talebinde bulundunuz \nParolanız:" +
                        dr["ogrSifre"].ToString() + "\nİyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadres, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadres);
                    mail.To.Add(kime);
                    mail.Subject = (konu);
                    mail.Body = (yaz);
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Bilgiler Uyuşuyor.Şifreniz Hatırlatma Mail'i gönderildi.");
                    this.Hide();
                }
                catch (Exception h)
                {
                    MessageBox.Show("e mail hatası"+h.Message);
                    throw;
                }


            }
        }

        void kayitsorgulama(string tabloAdi, SqlConnection sc)
        {
            SqlCommand s = new SqlCommand($"select * from {tabloAdi}", sc);
            SqlDataReader drr;
            drr = s.ExecuteReader();

            while (drr.Read())
            {
                if (drr["ogrEmail"].ToString() == MailTXT.Text && hesapvarmi == false)
                {
                    MessageBox.Show("Kayıt Bulundu Lütfen Bekleyiniz.");
                    hesapvarmi = true;
                    break;
                }
                if (drr["ogrEmail"].ToString()!= MailTXT.Text)
                {
                    hesapvarmi = false;
                }
            }
            if (!hesapvarmi)
            {

                MessageBox.Show("Böyle Bir Kayıt Yok Tekrar Deneyiniz.");
            }
            drr.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmGirisekran frmGirisekran = new FrmGirisekran();
            frmGirisekran.Show();
            this.Hide();
        }
    }
}
