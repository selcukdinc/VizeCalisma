using Microsoft.Office.Core;
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
    public partial class Satranc : Form
    {
        public Satranc()
        {
            InitializeComponent();
        }
        int BaslangicXKonum;
        private void Satranc_Load(object sender, EventArgs e)
        {
            BaslangicXKonum = btnOlustur.Location.X + btnOlustur.Width + 100 + (100 * 8);
            this.Width = BaslangicXKonum + this.Width - this.ClientSize.Width;
            this.Height = btnSample.Height * 8 + this.Height - this.ClientSize.Height;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        enum Renkler
        {
            Siyah, Beyaz
        }
        Renkler renk = Renkler.Beyaz;
       private void Ozmiras(Button Source,ref Button[] Target, int sayac)
        {
            Target[sayac] = new Button();
            Target[sayac].Text = $"{sayac+1}";
            Target[sayac].Name = $"Tas{sayac}";
            Target[sayac].Height = Source.Height;
            Target[sayac].Width = Source.Width;
            Target[sayac].FlatStyle = FlatStyle.Flat;
            Target[sayac].FlatAppearance.BorderSize = 0;
            this.Controls.Add(Target[sayac]);
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            btnOlustur.Enabled = false;
            int Xkonum = btnOlustur.Location.X + btnOlustur.Width + 100;
            int Ykonum = 0;
            int syc = 0;
            Button[] Btns = new Button[64];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (renk)
                    {
                        case Renkler.Siyah:
                            Ozmiras(btnSample, ref Btns, syc);
                            Btns[syc].Left = Xkonum + j * 100;
                            Btns[syc].Top = Ykonum;
                            Btns[syc].BackColor = Color.Black;
                            Btns[syc].ForeColor = Color.White;
                            syc++;
                            renk = Renkler.Beyaz;
                            break;
                        
                        case Renkler.Beyaz:
                            Ozmiras(btnSample, ref Btns, syc);
                            Btns[syc].Left = Xkonum + j * 100;
                            Btns[syc].Top = Ykonum;
                            Btns[syc].BackColor = Color.White;
                            Btns[syc].ForeColor = Color.Black;
                            syc++;
                            renk = Renkler.Siyah;
                            break;

                    }
                }
                if (renk == Renkler.Siyah)
                    renk = Renkler.Beyaz;
                else
                    renk = Renkler.Siyah;
                
                
                Xkonum = btnOlustur.Location.X + btnOlustur.Width + 100;
                Ykonum += 100;
            }
        }
    }
}
