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
    }
}
