using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void Loginbut_Click(object sender, EventArgs e)
        {
            if (AdminTxt.Text=="Batu"&&AdminSifreTxt.Text=="Batu123")
            {
                FrmAdminAnaEkran frmAdminAnaEkran = new FrmAdminAnaEkran();
                frmAdminAnaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Hatalı!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGirisekran frmGirisekran = new FrmGirisekran();
            frmGirisekran.Show();
            this.Hide();
        }
    }
}
