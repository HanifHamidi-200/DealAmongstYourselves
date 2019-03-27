using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCF
{
    public partial class Form1 : Form
    {
        private List<int> _tally = new List<int> { 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20 };
        private int mnTallyCount = 12;
        private int mnNum1, mnNum2;
        private void fReset()
        {
            Random rnd1 = new Random();
            int nPos;

            nPos = rnd1.Next(1, mnTallyCount + 1);
            mnNum1 = _tally[nPos - 1];
            nPos = rnd1.Next(1, mnTallyCount + 1);
            mnNum2 = _tally[nPos - 1];

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;

            lbl1.Text = Convert.ToString(mnNum1) + ", Factors =";
            lbl2.Text = Convert.ToString(mnNum2) + ", Factors =";
            lbl3.Text = "LCM =";
            lbl4.Text = "HCF =";

        }
        public Form1()
        { 
            InitializeComponent();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click_1(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
