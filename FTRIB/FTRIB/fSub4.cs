using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTRIB
{
    public partial class fSub4 : Form
    {
        public fSub4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt2.Text = null;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt3.Text = null;
        }
    }
}
