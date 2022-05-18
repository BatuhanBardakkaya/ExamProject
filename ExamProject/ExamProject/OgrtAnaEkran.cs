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
    public partial class OgrtAnaEkran : Form
    {
        public OgrtAnaEkran()
        {
            InitializeComponent();
        }

        private void BtnBilgiler_Click(object sender, EventArgs e)
        {
            FrmOgrtOgrencibilgi frmOgrtOgrencibilgi = new FrmOgrtOgrencibilgi();
            frmOgrtOgrencibilgi.Show();
            this.Hide();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            FrmOgrtSoruekleGuncelle frmOgrtSoruekleGuncelle = new FrmOgrtSoruekleGuncelle();
            frmOgrtSoruekleGuncelle.Show();
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
