using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOGGIS
{
    public partial class Form1 : Form
    {
        private List<String> _name = new List<string> { null, null, null, null, null, null };
        private List<String> _weather = new List<string> { null, null, null };

        private String fName()
        {
            Random rnd1 = new Random();
            String sLetter1 = Convert.ToString((char)(rnd1.Next(1, 27) + 64));
            String sLetter2 = Convert.ToString((char)(rnd1.Next(1, 27) + 64));
            int nNumber = rnd1.Next(1, 11);
            String sNumber = Convert.ToString(nNumber) + "000";

            return sLetter1 + sLetter2 + sNumber;
        }

        private void fReset()
        {
            for(int i = 1; i <= 6; i++)
            {
                _name[i - 1] = fName();
            }
            for (int i = 1; i <= 3; i++)
            {
                _weather[i - 1] = null;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            btn1.Text = _name[0];
            btn2.Text = _name[1];
            btn3.Text = _name[2];
            btn4.Text = _name[3];
            btn5.Text = _name[4];
            btn6.Text = _name[5];

            txt1.Text = _weather[0];
            txt2.Text = _weather[1];
            txt3.Text = _weather[2];

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
