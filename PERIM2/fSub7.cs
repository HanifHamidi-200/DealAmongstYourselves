using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERIM2
{
    public partial class fSub7 : Form
    {
        public fSub7()
        {
            InitializeComponent();
        }

        private void FSub7_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fTSub1 _dlg = new fTSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fTSub2 _dlg = new fTSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fTSub3 _dlg = new fTSub3();
            _dlg.ShowDialog();

        }

        private void BtnOpen4_Click(object sender, EventArgs e)
        {
            fTSub4 _dlg = new fTSub4();
            _dlg.ShowDialog();

        }
    }
}
