using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.VisualBasic;

namespace VizeCalisma
{
    public partial class Uyg01 : Form
    {
        public Uyg01()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        private void Uyg01_Load(object sender, EventArgs e)
        {
            btnBGLTile.Enabled = false;
            btnBGLNone.Enabled = false;
            btnBGLCenter.Enabled = false;
            btnBGLStretch.Enabled = false;
            btnBGLZoom.Enabled = false;
            btnBuyukEnable.Text = "Disable";
            btnKucukEnable.Text = "Disable";
        }

        Random rnd = new Random();
        private void btnFormTxtIB_Click(object sender, EventArgs e)
        {
            this.Text = Interaction.InputBox("Formunuzun yeni başlığını yazınız");
        }

        private void btnFormTxtCode_Click(object sender, EventArgs e)
        {
            int senSay = rnd.Next(1, 101), benSay = rnd.Next(1, 101);
            string sonuc = "Ben kazandım";
            if (senSay > benSay) 
                sonuc = "Sen kazandın";
            else if (senSay == benSay)
                sonuc = "Berabere kaldık ;)";
            this.Text = $"sen: {senSay}\tben: {benSay}\t sonuç: {sonuc}";
        }

        private void btnBGDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            this.BackColor = cd.Color;
        }

        private void btnBGCode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void btnBGImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string projectAdress = Environment.CurrentDirectory;
            ofd.InitialDirectory = projectAdress;

            ofd.Title = "Arka Plan Resmini Seçiniz";
            ofd.Filter = "Png dosyaları | *.png;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap resim = new Bitmap(ofd.FileName);
                this.BackgroundImage = resim;
                btnBGLTile.Enabled = true;
                btnBGLNone.Enabled = true;
                btnBGLCenter.Enabled = true;
                btnBGLStretch.Enabled = true;
                btnBGLZoom.Enabled = true;
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string projectAdress = Environment.CurrentDirectory;
            ofd.InitialDirectory = projectAdress;

            ofd.Title = "İkon Ekle";
            ofd.Filter = "İkon dosyaları | *.ico";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Icon ikon = new Icon(ofd.FileName);
                this.Icon = ikon;
            }
        }

        private void btnIconAddCode_Click(object sender, EventArgs e)
        {
            Icon ikon = new Icon(@".\favicon.ico");
            this.Icon = ikon;
        }

        private void btnIconShow_Click(object sender, EventArgs e)
        {
            this.ShowIcon = true;
        }

        private void btnIconDntShow_Click(object sender, EventArgs e)
        {
            this.ShowIcon = false;
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            this.ForeColor = cd.Color;
        }

        private void btnForeColorCode_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            this.Font = fd.Font;
        }

        private void btnFontCode_Click(object sender, EventArgs e)
        {
            Font fnt = new Font("Verdana", 10, FontStyle.Italic);
            this.Font = fnt;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblDeger.Text = $"Değer = {trackBar1.Value}";
            this.Opacity = (double)trackBar1.Value / 100;
        }

        private void btnCrcvYk_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCrcvVar_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnSbtFrm_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnSbtDialogFormu_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void btnAutoScrllOn_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void btnAutoScrollOff_Click(object sender, EventArgs e)
        {
            this.AutoScroll = false;
        }

        private void btnAutoSizeAcik_Click(object sender, EventArgs e)
        {
            this.AutoSize = true;
        }

        private void btnAutoSizeKapali_Click(object sender, EventArgs e)
        {
            this.AutoSize = false;
        }

        private void btnGrowOnly_Click(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        private void btnGrowndShrink_Click(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnKucukEnable_Click(object sender, EventArgs e)
        {
            if (this.MinimizeBox == true)
            {
                this.MinimizeBox = false;
                btnKucukEnable.Text = "Enable";
            }
            else
            {
                this.MinimizeBox = true;
                btnKucukEnable.Text = "Disable";
            }

        }

        private void btnBuyukEnable_Click(object sender, EventArgs e)
        {
            if (this.MaximizeBox == true)
            {
                this.MaximizeBox = false;
                btnBuyukEnable.Text = "Enable";
            }
            else
            {
                this.MaximizeBox = true;
                btnBuyukEnable.Text = "Disable";
            }
        }

        private void btnEnableHelp_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            btnBuyukEnable.Text = "Enable";
            this.MinimizeBox = false;
            btnKucukEnable.Text = "Enable";
            this.HelpButton = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(tbWidth.Text), h = Convert.ToInt32(tbHeight.Text);
            this.Size = new Size(w,h);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbHeight.Text = "";
            tbWidth.Text = "";
        }

        private void Uyg01_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
