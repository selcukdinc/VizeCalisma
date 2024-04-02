using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeCalisma
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
            groupBox10.Visible = false;
        }

        private void btnUyg1_Click(object sender, EventArgs e)
        {
            Uyg01 frm = new Uyg01();
            frm.ShowDialog();
        }

        private void btnUyg2_Click(object sender, EventArgs e)
        {
            Uyg02 frm = new Uyg02();
            frm.ShowDialog();
        }

        private void btnUyg3_Click(object sender, EventArgs e)
        {
            Uyg03 frm = new Uyg03();
            frm.ShowDialog();
        }

        private void btnCilgin_Click(object sender, EventArgs e)
        {
            CilginButon frm = new CilginButon();
            frm.ShowDialog();
        }

        private void btnUyg4_Click(object sender, EventArgs e)
        {
            Uyg04 frm = new Uyg04();
            frm.ShowDialog();
        }

        private void btnUyg5_Click(object sender, EventArgs e)
        {
            Uyg05 frm = new Uyg05();
            frm.ShowDialog();
        }

        private void btnBtnCogalt_Click(object sender, EventArgs e)
        {
            ButonCogalt frm = new ButonCogalt();
            frm.ShowDialog();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Editor frm = new Editor();
            frm.ShowDialog();
        }

        private void btnSatranc_Click(object sender, EventArgs e)
        {
            Satranc frm = new Satranc();
            frm.ShowDialog();
        }
    }
}
