using EnvDTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeCalisma
{
    internal class btnClss
    {
        Button btn;
        PictureBox pb;
        public bool durum = false;
        public btnClss(Button btnSource, PictureBox pbSource)
        {
            btn = btnSource;
            pb = pbSource;
            btnİlkKonum = new Point(btn.Left, btn.Top);
            btnSource.MouseDown += new MouseEventHandler(btnSource_Down);
            btnSource.MouseMove += new MouseEventHandler(btnSource_Move);
        }

        private void btnSource_Down(object sender, MouseEventArgs e)
        {
            this.MouseDown(e);
        }

        private void btnSource_Move(object sender, MouseEventArgs e)
        {
            this.MouseMove(e);
        }

        public void Yazdir()
        {
            MessageBox.Show($"Buton name: {btn.Name}\nButon text: {btn.Text}\nButon ForeColor: {btn.ForeColor}\nButon BackColor: {btn.BackColor}");
        }
        
        Point btnKonum, btnİlkKonum;
        
        public void MouseDown(MouseEventArgs e)
        {
            btnKonum = e.Location;
        }

        public void MouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btn.Left += e.X - (btnKonum.X);
                btn.Top += e.Y - (btnKonum.Y);
            }
        }
        public Button[] Btns = new Button[0]; public int BtnSyc = 0; int BtnSecilen = 0;
        private void OzMiras(Button BtnSource, Button[] BtnTarget, int Syc)
        {
            BtnTarget[Syc] = new Button();
            BtnTarget[Syc].Name = $"{BtnSource.Name}{Syc}";
            BtnTarget[Syc].Text = $"{BtnSource.Text}{Syc}";
            BtnTarget[Syc].Height = BtnSource.Height;
            BtnTarget[Syc].Width = BtnSource.Width;
            BtnTarget[Syc].Font = BtnSource.Font;
            BtnTarget[Syc].BackColor = BtnSource.BackColor;
            BtnTarget[Syc].ForeColor = BtnSource.ForeColor;
            BtnTarget[Syc].Location = BtnSource.Location;
        }
        public void MouseUpPart1()
        {
            if (btn.Location.X + btn.Width > pb.Width + btn.Width)
            {
                Array.Resize(ref Btns, BtnSyc + 1);
                OzMiras(btn, Btns, BtnSyc);
                durum = true;
                btn.Location = btnİlkKonum;
                //BtnSyc++;
            }
            else
            {
                btn.Location = btnİlkKonum;
                durum = false;
            }
        }
        public void Btns_MouseDown(MouseEventArgs e,Point ptCursor)
        {
            for (int i = 0; i < Btns.Length; i++)
            {
                if (Btns[i].Bounds.Contains(ptCursor))
                {
                    BtnSecilen = i;
                    break;
                }
            }
            btnKonum = e.Location;
        }
        public void Btns_MouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Btns[BtnSecilen].Left += e.X - (btnKonum.X);
                Btns[BtnSecilen].Top += e.Y - (btnİlkKonum.Y);
            }
        }
    }
}
