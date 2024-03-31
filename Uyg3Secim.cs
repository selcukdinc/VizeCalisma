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
    public partial class Uyg3Secim : Form
    {
        public int Start, End;
        public Uyg3Secim()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelButton = btnCancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Start = Convert.ToInt32(tbBaslangic.Text);
                End = Convert.ToInt32(tbMiktar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Start = -1;
            End = -1;
        }
    }
}
