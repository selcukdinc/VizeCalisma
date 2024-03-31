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
    public partial class Uyg3Degistir : Form
    {
        public string DegisenMetin;
        public Uyg3Degistir()
        {
            InitializeComponent();
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DegisenMetin = tbMetin.Text;
        }
    }
}
