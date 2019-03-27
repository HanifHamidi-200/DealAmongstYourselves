using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIQUID
{
    public partial class Form1 : Form
    {
        private List<String> _numbers = new List<string> { null, null, null, null, null, null, null, null, null, null };

        private void fReset()
        {
            Random rnd1 = new Random();
            int nAdd;
            int nSofar = 20;

            for (int i = 1; i <= 10; i++)
            {
                nAdd = rnd1.Next(1, 401);
                nSofar += nAdd;
                _numbers[i - 1] = Convert.ToString(nSofar);
            }

            fUpdateDisplay();
        }


        private void fUpdateDisplay()
        {
            txt1.Text = _numbers[0];
            txt2.Text = _numbers[1];
            txt3.Text = _numbers[2];
            txt4.Text = _numbers[3];
            txt5.Text = _numbers[4];
            txt6.Text = _numbers[5];
            txt7.Text = _numbers[6];
            txt8.Text = _numbers[7];
            txt9.Text = _numbers[8];
            txt10.Text = _numbers[9];

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
