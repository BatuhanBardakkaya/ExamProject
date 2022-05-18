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
    public partial class FrmAdminAnaEkran : Form
    {
        public FrmAdminAnaEkran()
        {
            InitializeComponent();
        }

        private void BtnOgrtislem_Click(object sender, EventArgs e)
        {
            FrmAdminOgrt frmAdminOgrt = new FrmAdminOgrt();
            frmAdminOgrt.Show();
            this.Hide();
        }

        private void BtnOgrenciislem_Click(object sender, EventArgs e)
        {
            FrmAdminOgr frmAdminOgr = new FrmAdminOgr();
            frmAdminOgr.Show();
            this.Hide();
        }

        private void BtnSoruislem_Click(object sender, EventArgs e)
        {
            FrmAdminSoru frmAdminSoru = new FrmAdminSoru();
            frmAdminSoru.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frmAdminGiris = new FrmAdminGiris();
            frmAdminGiris.Show();
            this.Hide();
        }
    }
}
