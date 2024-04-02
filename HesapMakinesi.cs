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
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        enum İslemler
        {
            Topla,Cikar,Bol,Carp, None
        }
        
        private void Acik(bool deger)
        {
            switch (deger)
            {
                case true:
                    btnArti.Enabled = true;
                    btnBol.Enabled = true;
                    btnCarp.Enabled = true;
                    btnEksi.Enabled = true;
                    break;
                case false:
                    btnArti.Enabled = false;
                    btnBol.Enabled = false;
                    btnCarp.Enabled = false;
                    btnEksi.Enabled = false;
                    break;
            }
        }

        İslemler islem = İslemler.None;

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            try
            {
                
                switch (islem)
                {
                case İslemler.Topla:
                    say2 = Convert.ToInt32(tbEkran.Text);
                    tbEkran.Text = $"{say1 + say2}";
                    Acik(true);
                    islem = İslemler.None;
                    break;

                case İslemler.Cikar:
                    say2 = Convert.ToInt32(tbEkran.Text);
                    tbEkran.Text = $"{say1 - say2}";
                    Acik(true);
                    islem = İslemler.None;
                    break;

                case İslemler.Bol:
                    say2 = Convert.ToInt32(tbEkran.Text);
                    tbEkran.Text = $"{say1 / say2}";
                    Acik(true);
                    islem = İslemler.None;
                    break;

                case İslemler.Carp:
                    say2 = Convert.ToInt32(tbEkran.Text);
                    tbEkran.Text = $"{say1 * say2}";
                    Acik(true);
                    islem = İslemler.None;
                    break;

                case İslemler.None:
                    break;
                }
            }catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        int say1, say2;
        private void btnArti_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbEkran.Text))
            {
                say1 = Convert.ToInt32(tbEkran.Text);
                tbEkran.Text = "";
                Acik(false);
                islem = İslemler.Topla;
                tbEkran.Focus();
            }
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbEkran.Text))
            {
                say1 = Convert.ToInt32(tbEkran.Text);
                tbEkran.Text = "";
                Acik(false);
                islem = İslemler.Cikar;
                tbEkran.Focus();
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbEkran.Text))
            {
                say1 = Convert.ToInt32(tbEkran.Text);
                tbEkran.Text = "";
                Acik(false);
                islem = İslemler.Carp;
                tbEkran.Focus();
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbEkran.Text))
            {
                say1 = Convert.ToInt32(tbEkran.Text);
                tbEkran.Text = "";
                Acik(false);
                islem = İslemler.Bol;
                tbEkran.Focus();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbEkran.Text += "9";
        }

        private void tbEkran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
