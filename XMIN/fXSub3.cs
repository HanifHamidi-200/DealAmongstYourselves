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
    public partial class fXSub3 : Form
    {
        private int mnMode;

        private void fInit()
        {
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            txt1.Text = "tally = 0";
            txt2.Text = "tally = 0";
            txt3.Text = "tally = 0";
            txt4.Text = "tally = 0";

            fFGet();
        }

        private void fFGet()
        {

        }

        private void fFSave()
        {

        }

        private void fShow(int nMode)
        {
            mnMode = nMode;

            btn1.BackColor = Color.Yellow;
            btn2.BackColor = Color.Yellow;
            btn3.BackColor = Color.Yellow;
            btn4.BackColor = Color.Yellow;
            chk1.Visible = false;
            chk2.Visible = false;
            chk3.Visible = false;
            chk4.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;

            switch (mnMode)
            {
                case 1:
                    btn1.BackColor = Color.Red;
                    chk1.Visible = true;
                    txt1.Visible = true;
                    break;
                case 2:
                    btn2.BackColor = Color.Red;
                    chk2.Visible = true;
                    txt2.Visible = true;
                    break;
                case 3:
                    btn3.BackColor = Color.Red;
                    chk3.Visible = true;
                    txt3.Visible = true;
                    break;
                default:
                    btn4.BackColor = Color.Red;
                    chk4.Visible = true;
                    txt4.Visible = true;
                    break;
            }
        }
        public fXSub3()
        {
            InitializeComponent();
            fInit();
        }

        private void FXSub3_Load(object sender, EventArgs e)
        {
            fShow(3);
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            fFSave();
        }
    }
}
