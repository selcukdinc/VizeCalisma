using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeCalisma
{
    public partial class Uyg03 : Form
    {

        public Uyg03()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            tbSifre.PasswordChar = '+';
            tbPass.UseSystemPasswordChar = true;
            tbWrap.WordWrap = true;
        }

        private void Uyg03_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Uyg3Secim frm1 = new Uyg3Secim();
            if (frm1.ShowDialog() == DialogResult.OK)
            {
                if (frm1.Start > -1 && frm1.End > -1)
                {
                    tbMain.Focus();
                    tbMain.Select(frm1.Start, frm1.End);
                }
            }
        }

        private void btnSecTumunu_Click(object sender, EventArgs e)
        {
            tbMain.SelectAll();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            tbMain.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            tbMain.Copy();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            tbMain.Paste();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbAra.Text))
            {
                
                int baslangic = tbMain.Text.IndexOf(tbAra.Text);

                if (baslangic != -1)
                {
                    tbMain.Focus();
                    tbMain.Select(baslangic, tbAra.Text.Length);
                }
                else
                    MessageBox.Show("Aradığınız kriterlerde sonuç bulunamadı","Kelime Bulunamadı");
            }
            else
                MessageBox.Show("İşlem yapabilmeniz için bir değer girmeniz gerekiyor...","Değer Girilmedi!");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbMain.Clear();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (tbMain.SelectedText.Length > 0)
            {
                Uyg3Degistir frm2 = new Uyg3Degistir();
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    tbMain.SelectedText = frm2.DegisenMetin;
                }
            }
            else
                MessageBox.Show("Metin seçilmediği için değiştirilme işlemi yapılamaz");
        }

        private void btnBirdenCokSat_Click(object sender, EventArgs e)
        {
            tbKaynakUst.Multiline = true;
            tbKaynakUst.Height = tbHedef.Height;
            tbKaynakUst.ScrollBars = ScrollBars.Vertical;
        }

        private void btnDegAta_Click(object sender, EventArgs e)
        {
            string[] Satirlar = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Satirlar[i] = $"Satır_{i+1}";
            }
            tbKaynakUst.Lines = Satirlar;
            for (int i = 0; i < 5; i++)
            {
                tbKaynakUst.Text += Environment.NewLine + $"Son eklenen satırın değer {i}";
            }
        }

        private void btnDegAktar_Click(object sender, EventArgs e)
        {
            tbHedef.Lines = tbKaynakUst.Lines;
        }

        private void btnBaziDegAktar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{tbKaynakUst.Lines.Length}");
            
            
            //MessageBox.Show($"Ceiling: 2.3 = {Math.Ceiling(2.3)}\nFloor: 2.3 = {Math.Floor(2.3)}");
            string[] BaziDegerler = new string[(int)Math.Ceiling((double)tbKaynakUst.Lines.Length/2)];
            for (int i = 0; i < tbKaynakUst.Lines.Length; i+=2)
            {
                BaziDegerler[i / 2] = tbKaynakUst.Lines[i];
            }
            tbHedef.Lines = BaziDegerler;
        }

        private void btnSola_Click(object sender, EventArgs e)
        {
            this.tbHedef.TextAlign = HorizontalAlignment.Left;
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            this.tbHedef.TextAlign = HorizontalAlignment.Center;
        }

        private void btnSaga_Click(object sender, EventArgs e)
        {
            this.tbHedef.TextAlign = HorizontalAlignment.Right;
        }

        private void btnSatSay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbHedef.Text))
            {
                MessageBox.Show($"Sayır sayısı: {tbHedef.Lines.Length}");
            }
        }

        private void tbKaynakAlt_TextChanged(object sender, EventArgs e)
        {
            tbSifre.Text = tbKaynakAlt.Text;
            tbPass.Text = tbKaynakAlt.Text;
            tbNormal.Text = tbKaynakAlt.Text;
            tbBuyuk.Text = tbKaynakAlt.Text;
            tbKucuk.Text = tbKaynakAlt.Text;
            tbReadOnly.Text = tbKaynakAlt.Text;
            tbMaxLength.Text = tbKaynakAlt.Text;
            tbWrap.Text = tbKaynakAlt.Text;
        }

        private void tbKaynakAlt_Enter(object sender, EventArgs e)
        {
            tbKaynakAlt.BackColor = Color.Yellow;
            tbKaynakAlt.ForeColor = Color.Navy;
            tbKaynakAlt.Font = new Font("Lucida Sans", 10, FontStyle.Bold);
        }

        private void tbKaynakAlt_Leave(object sender, EventArgs e)
        {
            tbKaynakAlt.BackColor = Color.White;
            tbKaynakAlt.ForeColor = Color.Black;
            tbKaynakAlt.Font = new Font("Lucida Sans", 10, FontStyle.Regular);
        }

        private void tbBuyuk_TextChanged(object sender, EventArgs e)
        {
            tbBuyuk.Text = tbBuyuk.Text.ToUpper();
        }

        private void tbKucuk_TextChanged(object sender, EventArgs e)
        {
            tbKucuk.Text = tbKucuk.Text.ToLower();
        }

        private void tbMaxLength_TextChanged(object sender, EventArgs e)
        {
            if (tbMaxLength.Text.Length >= 5)
            {
                tbMaxLength.Select(0, 5);
                tbMaxLength.Text = tbMaxLength.SelectedText;
            }
        }

        private void tbUplusL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.U)
            {
                tbUplusL.Text = tbUplusL.Text.ToUpper();
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                tbUplusL.Text = tbUplusL.Text.ToLower();
            }
        }

        private void tbSadeceSay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
