using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTFL
{
    public partial class fRSub4 : Form
    {
        public fRSub4()
        {
            InitializeComponent();
        }

        private void BtnOpen7_Click(object sender, EventArgs e)
        {
            fPSub7 _dlg = new fPSub7();
            _dlg.ShowDialog();
        }
    }
}
