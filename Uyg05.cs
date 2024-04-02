using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VizeCalisma
{
    public partial class Uyg05 : Form
    {
        public Uyg05()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnTIEkle_Click(object sender, EventArgs e)
        {
            lbTIKaynak.Items.Add(tbTIEkle.Text);
        }

        private void btnTIOne_Click(object sender, EventArgs e)
        {
            lbTIKaynak.SelectionMode = SelectionMode.One;
        }

        private void btnTINone_Click(object sender, EventArgs e)
        {
            lbTIKaynak.SelectionMode = SelectionMode.None;
        }

        private void btnTIMultiSimple_Click(object sender, EventArgs e)
        {
            lbTIKaynak.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnTIMultiExtended_Click(object sender, EventArgs e)
        {
            lbTIKaynak.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnTIIndicesAdd_Click(object sender, EventArgs e)
        {
            lbTIKaynak.SelectedIndices.Add(Convert.ToInt32(tbTIIndicies.Text));
        }

        private void btnTIIndicesRemove_Click(object sender, EventArgs e)
        {
            lbTIKaynak.SelectedIndices.Remove(Convert.ToInt32(tbTIIndicies.Text));
        }

        private void btnTISecimleriAktar_Click(object sender, EventArgs e)
        {
            foreach (var item in lbTIKaynak.SelectedItems)
            {
                lbTIHedef.Items.Add(item);
            }
        }

        bool durum = false;
        private void btnTISirali_Click(object sender, EventArgs e)
        {
            switch (durum)
            {
                case true:
                    lbTIHedef.Sorted = false;
                    durum = false;
                    btnTISirali.BackColor = Color.White;
                    break;
                case false:
                    lbTIHedef.Sorted = true;
                    durum = true;
                    btnTISirali.BackColor = Color.LightGreen;
                    break;
            }
        }

        private void btnTIBul_Click(object sender, EventArgs e)
        {
            lbTIKaynak.Focus();
            lbTIKaynak.SelectedIndex = lbTIKaynak.FindString(tbTIAra.Text);
        }

        int deger = 0;
        private void btnTIBulSonrakini_Click(object sender, EventArgs e)
        {
            if (lbTIKaynak.SelectedIndex < 0)
            {
                btnTIBul.PerformClick();
            }
            else
            {
                int index = lbTIKaynak.SelectedIndex;
                if (lbTIKaynak.FindString(tbTIAra.Text, index) > -1)
                {
                    index = lbTIKaynak.FindString(tbTIAra.Text, index);
                    if (index != 0)
                    {
                        lbTIKaynak.SelectedIndex = index;
                    }
                    else
                    {
                        if (MessageBox.Show("Son kelimeye gelindi başa dönülsün mü?", "Arama Sonu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            lbTIKaynak.SelectedIndex = -1;
                        }
                    }
                }
            }
        }

        private void btnACBAsalCarpan_Click(object sender, EventArgs e)
        {
            int bolum = 2;
            int sayi = Convert.ToInt32(tbACB.Text);
            while (sayi >= bolum)
            {
                if (asalmi(bolum) && sayi % bolum == 0)
                {
                    sayi /= bolum;
                    lbACBSonuc.Items.Add(bolum);
                }
                else
                    bolum++;
            }
        }

        private bool asalmi(int bolum)
        {
            if (bolum == 2)
                return true;
            else
            {
                for (int i = 2; i < bolum; i++)
                    if (bolum % i == 0)
                        return false;
                return true;
            }
        }

        private void btnSBul_Click(object sender, EventArgs e)
        {
            int index = lbSListe.FindString(tbSAra.Text);
            if (index < 0)
            {
                MessageBox.Show("Bulunamadı");
            }
            else
            {
                lbSListe.SelectedIndex = index;
                string satir = Kelimeler[index];
                string[] parcala = satir.Split(';');

                lblSBirinci.Text = "Birinci Hali : " + parcala[0];
                lblSIkinci.Text = "İkinci Hali : " + parcala[1];
                lblSUcuncu.Text = "Üçüncü Hali : " + parcala[2];
                lblSAnlam.Text = "Anlamı : " + parcala[3];
            }
        }

        private void KelimeOku(bool turkce)
        {
            lbSListe.Items.Clear();
            foreach (var satir in Kelimeler)
            {
                string[] parcala = satir.Split(';');
                string kelime = string.Empty;
                kelime = turkce ? parcala[3] : parcala[0];
                lbSListe.Items.Add(kelime);
            }
        }

        string[] Kelimeler;
        private void Uyg05_Load(object sender, EventArgs e)
        {
            Kelimeler = File.ReadAllLines(@".\Sozluk.txt", Encoding.UTF8);
            KelimeOku(true);
            rbSTrEng.Checked = true;
        }

        private void rbSTrEng_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSEngTr.Checked == true)
                KelimeOku(false);
            else
                KelimeOku(true);
        }

        private void rbSEngTr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSEngTr.Checked == true)
                KelimeOku(false);
            else
                KelimeOku(true);
        }

    }    
}
