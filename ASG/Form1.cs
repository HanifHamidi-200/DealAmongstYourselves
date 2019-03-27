using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASG
{
    public partial class Form1 : Form
    {
        private List<int> _data = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _data2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private int fFree()
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nPos;

            do
            {
                nPos = rnd1.Next(1, 13);
                if (_data2[nPos - 1] != 0)
                {
                    bFound = true;
                }
            }while(bFound==false);

            return nPos;
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nPos;

            for (int i = 1; i <= 12; i++)
            {
                _data[i - 1] = rnd1.Next(1, 101);
                _data2[i - 1] = _data[i - 1];
            }

            for (int i = 1; i <= 4; i++)
            {
                nPos = fFree();
                _data2[nPos - 1] = 0;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl1.BackColor = Color.LightGreen;
            lbl2.BackColor = Color.LightGreen;
            lbl3.BackColor = Color.LightGreen;
            lbl4.BackColor = Color.LightGreen;
            lbl5.BackColor = Color.LightGreen;
            lbl6.BackColor = Color.LightGreen;
            lbl7.BackColor = Color.LightGreen;
            lbl8.BackColor = Color.LightGreen;
            lbl9.BackColor = Color.LightGreen;
            lbl10.BackColor = Color.LightGreen;
            lbl11.BackColor = Color.LightGreen;
            lbl12.BackColor = Color.LightGreen;

            lbl1.Text = Convert.ToString(_data2[0]);
            lbl2.Text = Convert.ToString(_data2[1]);
            lbl3.Text = Convert.ToString(_data2[2]);
            lbl4.Text = Convert.ToString(_data2[3]);
            lbl5.Text = Convert.ToString(_data2[4]);
            lbl6.Text = Convert.ToString(_data2[5]);
            lbl7.Text = Convert.ToString(_data2[6]);
            lbl8.Text = Convert.ToString(_data2[7]);
            lbl9.Text = Convert.ToString(_data2[8]);
            lbl10.Text = Convert.ToString(_data2[9]);
            lbl11.Text = Convert.ToString(_data2[10]);
            lbl12.Text = Convert.ToString(_data2[11]);

            if (_data2[0] == 0)
            {
                lbl1.BackColor = Color.Red;
            }
            if (_data2[1] == 0)
            {
                lbl2.BackColor = Color.Red;
            }
            if (_data2[2] == 0)
            {
                lbl3.BackColor = Color.Red;
            }
            if (_data2[3] == 0)
            {
                lbl4.BackColor = Color.Red;
            }
            if (_data2[4] == 0)
            {
                lbl5.BackColor = Color.Red;
            }
            if (_data2[5] == 0)
            {
                lbl6.BackColor = Color.Red;
            }
            if (_data2[6] == 0)
            {
                lbl7.BackColor = Color.Red;
            }
            if (_data2[7] == 0)
            {
                lbl8.BackColor = Color.Red;
            }
            if (_data2[8] == 0)
            {
                lbl9.BackColor = Color.Red;
            }
            if (_data2[9] == 0)
            {
                lbl10.BackColor = Color.Red;
            }
            if (_data2[10] == 0)
            {
                lbl11.BackColor = Color.Red;
            }
            if (_data2[11] == 0)
            {
                lbl12.BackColor = Color.Red;
            }
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
