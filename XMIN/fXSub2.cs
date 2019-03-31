using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMIN
{
    public partial class fXSub2 : Form
    {
        private List<String> _text = new List<String> { "Name", "Address", "Date", "ID", "ColourScheme", "Password", "StudentID/WorkID" };
        private int mnMode;

        private void fShow(int nMode)
        {
            mnMode = nMode;

            btn1.BackColor = Color.Yellow;
            btn2.BackColor = Color.Yellow;
            btn3.BackColor = Color.Yellow;
            btn4.BackColor = Color.Yellow;
            btn5.BackColor = Color.Yellow;
            btn6.BackColor = Color.Yellow;
            btn7.BackColor = Color.Yellow;

            switch (mnMode)
            {
                case 1:
                    btn1.BackColor = Color.Red;
                    break;
                case 2:
                    btn2.BackColor = Color.Red;
                    break;
                case 3:
                    btn3.BackColor = Color.Red;
                    break;
                case 4:
                    btn4.BackColor = Color.Red;
                    break;
                case 5:
                    btn5.BackColor = Color.Red;
                    break;
                case 6:
                    btn6.BackColor = Color.Red;
                    break;
                default:
                    btn7.BackColor = Color.Red;
                    break;
            }

            lblName.Text = "---" + _text[mnMode - 1] + "---";
        }
        public fXSub2()
        {
            InitializeComponent();
        }

        private void FXSub2_Load(object sender, EventArgs e)
        {
            fShow(4);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            fShow(4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            fShow(5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            fShow(6);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            fShow(7);
        }
    }
}
