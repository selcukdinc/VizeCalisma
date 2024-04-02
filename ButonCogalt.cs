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
    public partial class ButonCogalt : Form
    {
        public ButonCogalt()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        btnClss btnE, btnBenv1, btnSenv1, btnOv1, btnBizv1, btnSizv1, btnOnlarv1;
        private void ButonCogalt_Load(object sender, EventArgs e)
        {
            btnE = new btnClss(btnEger, pb1);
            btnBenv1 = new btnClss(btnBen, pb1);
            btnSenv1 = new btnClss(btnSen, pb1);
            btnOv1 = new btnClss(btnO, pb1);
            btnBizv1 = new btnClss(btnBiz, pb1);
            btnSizv1 = new btnClss(btnSiz, pb1);
            btnOnlarv1 = new btnClss(btnOnlar, pb1);
        }
        #region Eger

        private void btnEger_MouseUp(object sender, MouseEventArgs e)
        {
            btnE.MouseUpPart1();
            if (btnE.durum)
            {
                this.Controls.Add(btnE.Btns[btnE.BtnSyc]);
                btnE.Btns[btnE.BtnSyc].MouseDown += new MouseEventHandler(btnEs_MouseDown);
                btnE.Btns[btnE.BtnSyc].MouseMove += new MouseEventHandler(btnEs_MouseMove);
                btnE.BtnSyc++;
            }
        }
        private void btnEs_MouseDown(object sender, MouseEventArgs e)
        {
            Point ptv1 = Cursor.Position;
            ptv1 = PointToClient(ptv1);
            btnE.Btns_MouseDown(e, ptv1);
        }
        private void btnEs_MouseMove(object sender, MouseEventArgs e)
        {
            btnE.Btns_MouseMove(e);
        }

        #endregion

        #region Ben

        private void btnBen_MouseUp(object sender, MouseEventArgs e)
        {
            btnBenv1.MouseUpPart1();
            if (btnBenv1.durum)
            {
                this.Controls.Add(btnBenv1.Btns[btnBenv1.BtnSyc]);
                btnBenv1.Btns[btnBenv1.BtnSyc].MouseDown += new MouseEventHandler(btnBens_MouseDown);
                btnBenv1.Btns[btnBenv1.BtnSyc].MouseMove += new MouseEventHandler(btnBens_MouseMove);
                btnBenv1.BtnSyc++;
            }
        }

        private void btnBens_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            pt = PointToClient(pt);
            btnBenv1.Btns_MouseDown(e, pt);
        }

        private void btnBens_MouseMove(object sender, MouseEventArgs e)
        {
            btnBenv1.Btns_MouseMove(e);
        }

        #endregion

        #region Sen

        private void btnSen_MouseUp(object sender, MouseEventArgs e)
        {
            btnSenv1.MouseUpPart1();
            if (btnSenv1.durum)
            {
                this.Controls.Add(btnSenv1.Btns[btnSenv1.BtnSyc]);
                btnSenv1.Btns[btnSenv1.BtnSyc].MouseDown += new MouseEventHandler(btnSens_MouseDown);
                btnSenv1.Btns[btnSenv1.BtnSyc].MouseMove += new MouseEventHandler(btnSens_MouseMove);
                btnSenv1.BtnSyc++;
            }
        }

        private void btnSens_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            pt = PointToClient(pt);
            btnSenv1.Btns_MouseDown(e, pt);
        }

        private void btnSens_MouseMove(object sender, MouseEventArgs e)
        {
            btnSenv1.Btns_MouseMove(e);
        }

        #endregion

        #region O

        private void btnO_MouseUp(object sender, MouseEventArgs e)
        {
            btnOv1.MouseUpPart1();
            if (btnOv1.durum)
            {
                this.Controls.Add(btnOv1.Btns[btnOv1.BtnSyc]);
                btnOv1.Btns[btnOv1.BtnSyc].MouseDown += new MouseEventHandler(btnOs_MouseDown);
                btnOv1.Btns[btnOv1.BtnSyc].MouseMove += new MouseEventHandler(btnOs_MouseMove);
                btnOv1.BtnSyc++;
            }
        }

        private void btnOs_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            pt = PointToClient(pt);
            btnOv1.Btns_MouseDown(e, pt);
        }

        private void btnOs_MouseMove(object sender, MouseEventArgs e)
        {
            btnOv1.Btns_MouseMove(e);
        }

        #endregion

        #region Biz

        private void btnBiz_MouseUp(object sender, MouseEventArgs e)
        {
            btnBizv1.MouseUpPart1();
            if (btnBizv1.durum)
            {
                this.Controls.Add(btnBizv1.Btns[btnBizv1.BtnSyc]);
                btnBizv1.Btns[btnBizv1.BtnSyc].MouseDown += new MouseEventHandler(btnBizs_MouseDown);
                btnBizv1.Btns[btnBizv1.BtnSyc].MouseMove += new MouseEventHandler(btnBizs_MouseMove);
                btnBizv1.BtnSyc++;
            }
        }

        private void btnBizs_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            pt = PointToClient(pt);
            btnBizv1.Btns_MouseDown(e, pt);
        }

        private void btnBizs_MouseMove(object sender, MouseEventArgs e)
        {
            btnBizv1.Btns_MouseMove(e);
        }

        #endregion

        #region Siz

        private void btnSiz_MouseUp(object sender, MouseEventArgs e)
        {
            btnSizv1.MouseUpPart1();
            if (btnSizv1.durum)
            {
                this.Controls.Add(btnSizv1.Btns[btnSizv1.BtnSyc]);
                btnSizv1.Btns[btnSizv1.BtnSyc].MouseDown += new MouseEventHandler(btnSizs_MouseDown);
                btnSizv1.Btns[btnSizv1.BtnSyc].MouseMove += new MouseEventHandler(btnSizs_MouseMove);
                btnSizv1.BtnSyc++;
            }
        }

        private void btnSizs_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            pt = PointToClient(pt);
            btnSizv1.Btns_MouseDown(e, pt);
        }

        private void btnSizs_MouseMove(object sender, MouseEventArgs e)
        {
            btnSizv1.Btns_MouseMove(e);
        }

        #endregion

        #region Onlar

        private void btnOnlar_MouseUp(object sender, MouseEventArgs e)
        {
            btnOnlarv1.MouseUpPart1();
            if (btnOnlarv1.durum)
            {
                this.Controls.Add(btnOnlarv1.Btns[btnOnlarv1.BtnSyc]);
                btnOnlarv1.Btns[btnOnlarv1.BtnSyc].MouseDown += new MouseEventHandler(btnOnlars_MouseDown);
                btnOnlarv1.Btns[btnOnlarv1.BtnSyc].MouseMove += new MouseEventHandler(btnOnlars_MouseMove);
                btnOnlarv1.BtnSyc++;
            }
        }

        private void btnOnlars_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            pt = PointToClient(pt);
            btnOnlarv1.Btns_MouseDown(e, pt);
        }

        private void btnOnlars_MouseMove(object sender, MouseEventArgs e)
        {
            btnOnlarv1.Btns_MouseMove(e);
        }

        #endregion
    }
}
