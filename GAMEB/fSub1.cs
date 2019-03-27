using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEB
{
    public partial class fSub1 : Form
    {
        public fSub1()
        {
            InitializeComponent();
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fGSub1 _dlg = new fGSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fGSub2 _dlg = new fGSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fGSub3 _dlg = new fGSub3();
            _dlg.ShowDialog();

        }
    }
}
