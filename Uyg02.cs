using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace VizeCalisma
{
    public partial class Uyg02 : Form
    {
        public Uyg02()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        void Uyg02_Load(object sender, EventArgs e)
        {
            btnOyun.Enabled = false;
        }
        
        enum BtnDirection
        {
            Yukari, Saga, Asagi, Sola
        }
        int Artan = 15;
        private void ButonHareket(BtnDirection btnD)
        {
            int FarkDeger = 5, konumy = btnOyun.Location.Y, konumx = btnOyun.Location.X;
            switch (btnD)
            {
                case BtnDirection.Yukari: 
                    konumy -= FarkDeger;
                    btnOyun.Location = new Point(btnOyun.Location.X, konumy);
                    break;
                case BtnDirection.Saga:
                    konumx += FarkDeger;
                    btnOyun.Location = new Point(konumx, btnOyun.Location.Y);
                    break;
                case BtnDirection.Asagi:
                    konumy += FarkDeger;
                    btnOyun.Location = new Point(btnOyun.Location.X, konumy);
                    break;
                case BtnDirection.Sola:
                    konumx -= FarkDeger;
                    btnOyun.Location = new Point(konumx, btnOyun.Location.Y);
                    break;
            }
        }
        
        

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnOyun.Enabled = true;
            btnOyun.Focus();
            btnPlay.Enabled = false;
        }

        private void btnOyun_Leave(object sender, EventArgs e)
        {
            btnOyun.Enabled = false;
            btnPlay.Enabled = true;
            okunanDeg = "";
        }
        string okunanDeg;
        private void btnOyun_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPressEventArgs
            string[] tuslar = {"a","s","d","w"};
            okunanDeg = e.KeyChar.ToString().ToLower();
            //MessageBox.Show($"'{okunanDeg}'");
            while (Array.Exists(tuslar, element => element == $"{okunanDeg}"))
            {
                Application.DoEvents();
                lblOkunanDeg.Text = $"Değer: {e.KeyChar}";
                okunanDeg = e.KeyChar.ToString().ToLower();
                switch (okunanDeg)
                {
                    case "w":
                        ButonHareket(BtnDirection.Yukari);
                        break;
                    case "d":
                        ButonHareket(BtnDirection.Saga);
                        break;
                    case "s":
                        ButonHareket(BtnDirection.Asagi);
                        break;
                    case "a":
                        ButonHareket(BtnDirection.Sola);
                        break;
                }
                Thread.Sleep(30);
            }      
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            ButonHareket(BtnDirection.Yukari);
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            ButonHareket(BtnDirection.Saga);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            ButonHareket(BtnDirection.Asagi);
        }

        private void btnSola_Click(object sender, EventArgs e)
        {
            ButonHareket(BtnDirection.Sola);
        }

        private void btnImageList_Click(object sender, EventArgs e)
        {
            btn0.ImageList = btn1.ImageList = btn2.ImageList = ımageList1;
            btn0.ImageIndex = 0;
            btn1.ImageIndex = 2;
            btn2.ImageIndex = 3;
        }

        private void btnBoyutlandir_Click(object sender, EventArgs e)
        {
            int uzunluk = 150;
            for(int i = 0; i < 3; i++)
            {
                this.Controls[$"btn{i}"].Width = uzunluk;
                this.Controls[$"btn{i}"].Height = uzunluk;
            }
        }

        private void btnKon_Click(object sender, EventArgs e)
        {
            btn0.TextAlign = ContentAlignment.TopLeft;
            btn2.TextAlign = ContentAlignment.BottomRight;
        }

        private void btnKonRes_Click(object sender, EventArgs e)
        {
            btn0.TextImageRelation = TextImageRelation.ImageAboveText;
            btn1.TextImageRelation = TextImageRelation.TextAboveImage;
            btn2.TextImageRelation = TextImageRelation.TextBeforeImage;
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            btn0.ImageAlign = ContentAlignment.BottomLeft;
            btn1.ImageAlign = ContentAlignment.MiddleRight;
            btn2.ImageAlign = ContentAlignment.TopRight;
        }

        private void Uyg02_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
