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
    public partial class fGSSub8a : Form
    {
        private int mnMode;
        private int mnItem;

        private void fShow(int nMode)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;

            mnMode = nMode;

            switch (nMode)
            {
                case 1:
                    pic1.Visible = true;
                    break;
                case 2:
                    pic2.Visible = true;
                    break;
                case 3:
                    pic3.Visible = true;
                    break;
                case 4:
                    pic4.Visible = true;
                    break;
                case 5:
                    pic5.Visible = true;
                    break;
                case 6:
                    pic6.Visible = true;
                    break;
                case 7:
                    pic7.Visible = true;
                    break;
                default:
                    pic8.Visible = true;
                    break;
            }
        }
        public fGSSub8a()
        {
            InitializeComponent();
            pic2.Left = pic1.Left;
            pic2.Top = pic1.Top;
            pic3.Left = pic1.Left;
            pic3.Top = pic1.Top;
            pic4.Left = pic1.Left;
            pic4.Top = pic1.Top;
            pic5.Left = pic1.Left;
            pic5.Top = pic1.Top;
            pic6.Left = pic1.Left;
            pic6.Top = pic1.Top;
            pic7.Left = pic1.Left;
            pic7.Top = pic1.Top;
            pic8.Left = pic1.Left;
            pic8.Top = pic1.Top;
        }

        private void FGSSub8a_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnItem = rnd1.Next(1, 9);
            fShow(mnItem);
        }

        private void Lst1_Click(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
            fShow(mnItem);
        }
    }
}
