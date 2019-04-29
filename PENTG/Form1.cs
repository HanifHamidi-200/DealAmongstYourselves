using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PENTG
{
    public partial class Form1 : Form
    {
        private List<String> _text = new List<String> { "LuckyDatabase", "NYCentralHub", "DuplicatesOffice", "BaBRequest" };
        private List<int> _numbers = new List<int> { 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            for(int i = 1; i <= 4; i++)
            {
                _numbers[i - 1] = rnd1.Next(1, 201);
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for(int i = 1; i <= 4; i++)
            {
                sText = _text[i - 1] + " = " + Convert.ToString(_numbers[i - 1]);
                lst1.Items.Add(sText);
            }

            txt1.Text = null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
