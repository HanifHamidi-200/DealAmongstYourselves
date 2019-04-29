using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMERG
{
    public partial class fGSub1b : Form
    {
        public fGSub1b()
        {
            InitializeComponent();
        }

        private void BtnOpen8_Click(object sender, EventArgs e)
        {
            fGSSub8a _dlg = new fGSSub8a();
            _dlg.ShowDialog();
        }

        private void BtnOpen8b_Click(object sender, EventArgs e)
        {
            fGSSub8b _dlg = new fGSSub8b();
            _dlg.ShowDialog();

        }
    }
}
