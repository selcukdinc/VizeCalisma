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
using System.Security;

namespace VizeCalisma
{
    public partial class Uyg04 : Form
    {
        public Uyg04()
        {
            InitializeComponent();
            tbYukseklik.Text = cbTemelIslem.Height.ToString();
            tbGenislik.Text = $"{cbTemelIslem.Width}";
            lbTemelSay.Text = $"{cbTemelIslem.Items.Count}";
            illeriOku();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void illeriOku()
        {
            string il;
            StreamReader sr = new StreamReader(@".\il_ilceler\iller.txt");
            try
            {
                while ((il = sr.ReadLine()) != null)
                {
                    cbIller.Items.Add(il);
                }
                cbIller.SelectedIndex = -1;
                cbIller.Text = "il seçin";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }finally
            { 
                sr.Close(); 
            }
        }


        private void btnSimple_Click(object sender, EventArgs e)
        {
            cbTemelIslem.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            cbTemelIslem.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnDropDownList_Click(object sender, EventArgs e)
        {
            cbTemelIslem.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAyarla_Click(object sender, EventArgs e)
        {
            try
            {
                int genislik = Convert.ToInt32(tbGenislik.Text);
                int Yukseklik = Convert.ToInt32(tbYukseklik.Text);
                cbTemelIslem.DropDownWidth = genislik;
                cbTemelIslem.DropDownHeight = Yukseklik;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
               
            }
            
        }

        private void cbTemelIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTemelIndex.Text = $"{cbTemelIslem.SelectedIndex}";
            lbTemelSecilen.Text = $"{cbTemelIslem.Items[cbTemelIslem.SelectedIndex]}";
        }

        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ilce;
            cbIlceler.Items.Clear();
            StreamReader sr;
            try
            {
                sr = new StreamReader($@".\il_ilceler\{cbIller.Items[cbIller.SelectedIndex].ToString().TrimStart(' ')}.txt");
                while ((ilce = sr.ReadLine()) != null)
                {
                    cbIlceler.Items.Add(ilce);
                }
                cbIlceler.Text = "İlçe seçin";
                cbIlceler.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");  
                
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cbEkleKaynak.Items.Add(tbEkle.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cbEkleKaynak.Items.Clear();
        }

        private void btnKntEkle_Click(object sender, EventArgs e)
        {
            if (!cbEkleKaynak.Items.Contains(tbEkle.Text))
            {
                cbEkleKaynak.Items.Add(tbEkle.Text);
                tbEkle.Text = "";
            }
            else
                MessageBox.Show("Bu değer daha önceden girilmiş");
        }

        private void btnDİziEkle_Click(object sender, EventArgs e)
        {
            string[] dizi = {"ankara", "istanbul", "izmir", "konya", "bursa" };
            for (int i = 0; i < dizi.Length; i++)
            {
                cbEkleKaynak.Items.Add(dizi[i]);
            }
        }

        private void btnDiziAktar_Click(object sender, EventArgs e)
        {
            string[] ekle = new string[cbEkleKaynak.Items.Count];
            cbEkleKaynak.Items.CopyTo(ekle, 0);
            tbEkleSonuc.Lines = ekle;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cbEkleKaynak.Items.Insert(Convert.ToInt32(tbEkleKonum.Text), tbEkleVeri.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbEkleKaynak.Items.Contains(tbEkleVeri.Text))
                cbEkleKaynak.Items.Remove(tbEkleVeri.Text);
            else
                MessageBox.Show("Değer uyuşmadığı için silinemedi");  
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            try
            {
                cbEkleKaynak.Items.RemoveAt(Convert.ToInt32(tbEkleKonum.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnIslemlerEkle_Click(object sender, EventArgs e)
        {
            cbIslemSec.Items.Clear();
            string[] islemler = {"Topla", "Çıkar", "Çarp", "Böl"};
            for (int i = 0; i < islemler.Length; i++)
            {
                cbIslemSec.Items.Add(islemler[i]);
            }
        }

        private void cbIslemSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Topla
            //Çıkar
            //Çarp
            //Böl
            string temp = cbIslemSec.Items[cbIslemSec.SelectedIndex].ToString();
            try
            {
                switch (temp)
                {
                    case "Topla": tbSonuc.Text = $"{Convert.ToDouble(tbIlkSay.Text) + Convert.ToDouble(tbIkinciSay.Text)}"; break;
                    case "Çıkar": tbSonuc.Text = $"{Convert.ToDouble(tbIlkSay.Text) - Convert.ToDouble(tbIkinciSay.Text)}"; break;
                    case "Çarp": tbSonuc.Text = $"{Convert.ToDouble(tbIlkSay.Text) * Convert.ToDouble(tbIkinciSay.Text)}"; break;
                    case "Böl": tbSonuc.Text = $"{Convert.ToDouble(tbIlkSay.Text) / Convert.ToDouble(tbIkinciSay.Text)}"; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
