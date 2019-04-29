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
    public partial class fGSSub8b : Form
    {
        private int mnMode;
        private int mnItem;

        private void fShow(int nMode)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
       
            mnMode = nMode;

            switch (nMode)
            {
                case 1:
                    pic1.Visible = true;
                    break;
                case 2:
                    pic2.Visible = true;
                    break;
                default:
                    pic3.Visible = true;
                    break;
            }
        }
        public fGSSub8b()
        {
            InitializeComponent();
            pic2.Left = pic1.Left;
            pic2.Top = pic1.Top;
            pic3.Left = pic1.Left;
            pic3.Top = pic1.Top;
        }

        private void FGSSub8b_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnItem = rnd1.Next(1, 4);
            fShow(mnItem);
        }

        private void Lst1_Click(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
            fShow(mnItem);
        }
    }
}
