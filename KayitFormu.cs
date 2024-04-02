using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeCalisma
{
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            cbUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBolum.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        string hobi;
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            hobi = "";
            if (!string.IsNullOrEmpty(tbAdSoyad.Text) && !string.IsNullOrEmpty(mtbOgNo.Text) && !string.IsNullOrEmpty(mtbTelNo.Text) && cbUni.SelectedIndex != -1 && cbUni.SelectedIndex != -1)
            {
                //MessageBox.Show("Kayıt Yapıldı");
                try
                {
                    
                    for (int i = 0; i < clbHobi.SelectedIndices.Count; i++)
                        hobi += $"{clbHobi.Items[clbHobi.SelectedIndices[i]]}\t";
                    
                    string sonuc = $"AdSoyad:\t{tbAdSoyad.Text}\tOgNo:\t{mtbOgNo.Text}\tTelNo:\t{mtbTelNo.Text}\tÜniversite:\t{cbUni.Items[cbUni.SelectedIndex]}\tBölüm:\t{cbBolum.Items[cbBolum.SelectedIndex]}\tAdres:\t{tbAdres.Text}\tHobi:\t{hobi}";
                    File.AppendAllText(@".\KayitForm.txt",sonuc + Environment.NewLine);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
                MessageBox.Show("Eksik yer bıraktınız");
        }
    }
}
