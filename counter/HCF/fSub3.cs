using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCF
{
    public partial class fSub3 : Form
    {
        public fSub3()
        {
            InitializeComponent();
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fLSub1 _dlg = new fLSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fLSub2 _dlg = new fLSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fLSub3 _dlg = new fLSub3();
            _dlg.ShowDialog();

        }

        private void BtnOpen4_Click(object sender, EventArgs e)
        {
            fLSub4 _dlg = new fLSub4();
            _dlg.ShowDialog();

        }

        private void BtnOpen5_Click(object sender, EventArgs e)
        {
            fLSub5 _dlg = new fLSub5();
            _dlg.ShowDialog();

        }

        private void BtnOpen6_Click(object sender, EventArgs e)
        {
            fLSub6 _dlg = new fLSub6();
            _dlg.ShowDialog();

        }

        private void BtnOpen7_Click(object sender, EventArgs e)
        {
            fLSub7 _dlg = new fLSub7();
            _dlg.ShowDialog();

        }
    }
}
