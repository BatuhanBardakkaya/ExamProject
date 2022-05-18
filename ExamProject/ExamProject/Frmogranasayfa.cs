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
    public partial class Frmogranasayfa : Form
    {
        public Frmogranasayfa()
        {
            InitializeComponent();
        }

        private void BtnBilgiler_Click(object sender, EventArgs e)
        {
            FrmOgrenciBilgi frmOgrenciBilgi = new FrmOgrenciBilgi();
            frmOgrenciBilgi.Show();
            this.Hide();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            FrmOgrSınav frmOgrSınav = new FrmOgrSınav();
            frmOgrSınav.Show();
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
