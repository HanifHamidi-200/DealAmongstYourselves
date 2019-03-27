using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLDTIM
{
    public partial class fSub3 : Form
    {
        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fWSub1 _dlg = new fWSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fWSub2 _dlg = new fWSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fWSub3 _dlg = new fWSub3();
            _dlg.ShowDialog();

        }

        private void BtnOpen4_Click(object sender, EventArgs e)
        {
            fWSub4 _dlg = new fWSub4();
            _dlg.ShowDialog();

        }

        private void BtnOpen5_Click(object sender, EventArgs e)
        {
            fWSub5 _dlg = new fWSub5();
            _dlg.ShowDialog();

        }

     }
}
