using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTAB
{
    public partial class fSub2 : Form
    {
        private List<String> _col1 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private String msDate;

        private void fShow(int nMode)
        {
            fra1.Visible = false;
            fra2.Visible = false;

            if (nMode == 1)
            {
                fra1.Visible = true;
            }
            else
            {
                fra2.Visible = true;
            }
        }
        public fSub2()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;
        }

        
        private void FSub2_Load(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fShow(1);
        }
    }
}
