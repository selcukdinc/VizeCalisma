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
    public partial class CilginButon : Form
    {
        public CilginButon()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnEvet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hile yapmak yok ;)");
        }
        int syc;
        private void btnEvet_MouseEnter(object sender, EventArgs e)
        {
            Point konum = new Point(rnd.Next(0,this.ClientSize.Width-btnEvet.Width),rnd.Next(0,this.ClientSize.Height - btnEvet.Height));
            btnEvet.Location = konum;
            syc++;
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            switch (syc)
            {
                case 0: MessageBox.Show("OOOO Hemen başlayalım çalışmaya"); break;
                case 1: MessageBox.Show("Yanlışlıkla mı bastın?, derse koş çabuk"); break;
                case 2: MessageBox.Show("Yanlışlıkla değil sen çalışmak mı istemiyorsun, basmak yok evete"); break;
                case 3: MessageBox.Show("şansını 3 kere denemişsin, oyun oynamak yok, derse"); break;
                case 4: MessageBox.Show("eee daha ne kadar deneyeceksin şansını :D"); break;
                default: MessageBox.Show($"{syc} Defa denedin ama hala olmadı demi,\n he he he, oyun oynamak yok...."); break;
            }
            
        }
    }
}
