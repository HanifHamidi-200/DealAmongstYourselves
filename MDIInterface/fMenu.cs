using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIInterface
{
    public partial class fMenu : Form
    {
        private void fShow(int nMode)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            switch (nMode)
            {
                case 1:
                    groupBox1.Visible = true;
                    break;
                case 2:
                    groupBox2.Visible = true;
                    break;
                case 3:
                    groupBox3.Visible = true;
                      break;
                default:
                    groupBox4.Visible = true;
                    break;

            }
        }
        public fMenu()
        {
            InitializeComponent();
            groupBox2.Left = groupBox1.Left;
            groupBox2.Top = groupBox1.Top;
            groupBox3.Left = groupBox1.Left;
            groupBox3.Top = groupBox1.Top;
            groupBox4.Left = groupBox1.Left;
            groupBox4.Top = groupBox1.Top;

        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue = rnd1.Next(1, 5);

            fShow(nValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fShow(4);
        }
    }
}
