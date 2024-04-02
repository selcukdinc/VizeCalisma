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

namespace _233302071SelcukDİNC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbBaglantiSifre.PasswordChar = '*';
            FileStream fs = new FileStream(@".\BaglantiTipi.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string kelime;
            while ((kelime = sr.ReadLine()) != null)
            {
                cbBagTip.Items.Add(kelime);

            }
            sr.Close();
            fs.Close();
        }

        private void tbBaglantiSifre_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = tbBaglantiSifre.Text;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCihazIsim.Text) && !string.IsNullOrEmpty(tbCihazId.Text) && !string.IsNullOrEmpty(tbBaglantiSifre.Text) && cbBagTip.SelectedIndex != -1)
            {
                 //MessageBox.Show("Başarılı bir şekilde kaydedildi");
                lblSonuc.Text = tbCihazId.Text +" ID nolu "+ tbCihazIsim.Text+", "+cbBagTip.Items[cbBagTip.SelectedIndex]+" bağlantısı gerçekleştirildi";
                lblSonuc.BackColor = Color.LightGreen;

            }
            else{
                lblSonuc.BackColor = Color.LightSalmon;
                //MessageBox.Show("kaydedilemedi");
                //btnIptal.PerformClick();
                lblSonuc.Text = "Sonuç: Kaydedilemedi...";
                }


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            lblSonuc.BackColor = Color.LightSalmon;
            lblSonuc.Text = "Sonuç: Kayıtlı kullanıcı tarafından iptal edildi";
            tbBaglantiSifre.Text = "";
            tbCihazId.Text = "";
            tbCihazIsim.Text = "";
            cbBagTip.SelectedIndex = -1;
            for (int i = 0; i < clbKulList.Items.Count; i++)
			{
                clbKulList.SetItemChecked(i, false);
			}
            
        }

        
    }
}
