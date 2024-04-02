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
using Microsoft.VisualBasic;

namespace VizeCalisma
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            this.Text = "Editör - Yeni Belge";
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (tbMetin.Font.Bold == true && tbMetin.Font.Italic == true)
            {
                tbMetin.Font = new Font(tbMetin.Font.FontFamily, tbMetin.Font.Size, FontStyle.Italic);
            }
            else if (tbMetin.Font.Bold == true && tbMetin.Font.Italic == false)
            {
                tbMetin.Font = new Font(tbMetin.Font.FontFamily, tbMetin.Font.Size, FontStyle.Regular);
            }
            else
            {
                tbMetin.Font = new Font(tbMetin.Font.FontFamily, tbMetin.Font.Size, FontStyle.Bold);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if ( tbMetin.Font.Bold == true && tbMetin.Font.Italic == true)
            {
                tbMetin.Font = new Font(tbMetin.Font.FontFamily, tbMetin.Font.Size, FontStyle.Bold);
            }
            else if (tbMetin.Font.Bold == false && tbMetin.Font.Italic == true)
            {
                tbMetin.Font = new Font(tbMetin.Font.FontFamily, tbMetin.Font.Size, FontStyle.Regular);
            }
            else
            {
                tbMetin.Font = new Font(tbMetin.Font.FontFamily, tbMetin.Font.Size, FontStyle.Italic);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            tbMetin.Font = fd.Font;
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            tbMetin.ForeColor = cd.Color;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string projectAdress = Environment.CurrentDirectory;
            ofd.InitialDirectory = projectAdress;

            if (this.Text != "Editör - Yeni Belge")
            {
                try
                {
                    string Adress = Environment.CurrentDirectory;
                    FileStream fs = new FileStream(Adress +"\\"+this.Text, FileMode.Open);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(tbMetin.Text);

                    sw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            else
                btnFarkliKaydet.PerformClick();
        }

        private void btnFarkliKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string Adress = Environment.CurrentDirectory;
            sfd.InitialDirectory = Adress;
            sfd.Title = $"{this.Text} Dosyasını Farklı Kaydet";
            sfd.Filter = "Text belgesi | .txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string a = sfd.InitialDirectory;
                string b = sfd.FileName;
                string c = a + b;
                try
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine(tbMetin.Text);
                    this.Text = $"{Path.GetFileNameWithoutExtension(Path.GetFileName(sfd.FileName))}";
                    sw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string Adress = Environment.CurrentDirectory;
            ofd.InitialDirectory = Adress;
            ofd.Title = "Aç";
           
            //ofd.Filter = "Text Belgesi | .txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    int syc = 0;
                    string satir;
                    tbMetin.Text = " \n";
                    
                    while ((satir = sr.ReadLine()) != null)
                    {
                        int MetinEskSay = tbMetin.Lines.Length;
                        int MetinGunSay = MetinEskSay + 1;
                        string[] yeniSatirlar = new string[MetinGunSay];
                        Array.Copy(tbMetin.Lines, yeniSatirlar, MetinEskSay);
                        for (int i = MetinEskSay; i < MetinGunSay; i++)
                        {
                            yeniSatirlar[i] = satir;
                        }
                        tbMetin.Lines = yeniSatirlar;
                        //tbMetin.Lines[syc] = satir;
                        syc++;
                    }

                    this.Text = $"{ofd.SafeFileName}";
                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
    }
}
