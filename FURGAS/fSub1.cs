using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FURGAS
{
    public partial class fSub1 : Form
    {
        private int mnMode;

        private void fShow(int nMode)
        {
            fra1.Visible = false;
            fra2.Visible = false;

            mnMode = nMode;

            if (nMode == 1)
            {
                fra1.Visible = true;
            }
            else
            {
                fra2.Visible = true;
            }
        }
        public fSub1()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;
        }

        private void FSub1_Load(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }
    }
}
