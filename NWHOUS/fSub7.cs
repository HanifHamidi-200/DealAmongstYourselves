using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWHOUS
{
    public partial class fSub7 : Form
    {
        private List<int> _P1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _P2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _P3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnCount1, mnCount2, mnCount3;

        private void fReset()
        {
            Random rnd1 = new Random();

            mnCount1 = rnd1.Next(1, 11);
            mnCount2 = rnd1.Next(1, 11);
            mnCount3 = rnd1.Next(1, 11);

            for(int i = 1; i <= 10; i++)
            {
                _P1[i - 1] = rnd1.Next(1, 201);
                _P2[i - 1] = rnd1.Next(1, 201);
                _P3[i - 1] = rnd1.Next(1, 201);
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
            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }
            if (lst3.Items.Count > 0)
            {
                do
                {
                    lst3.Items.RemoveAt(0);
                } while (lst3.Items.Count > 0);
            }

            for(int i = 1; i <= mnCount1; i++)
            {
                sText = Convert.ToString(_P1[i - 1]);
                lst1.Items.Add(sText);
            }
            for (int i = 1; i <= mnCount2; i++)
            {
                sText = Convert.ToString(_P2[i - 1]);
                lst2.Items.Add(sText);
            }
            for (int i = 1; i <= mnCount3; i++)
            {
                sText = Convert.ToString(_P3[i - 1]);
                lst3.Items.Add(sText);
            }
        }
        public fSub7()
        {
            InitializeComponent();
        }

        private void FSub7_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
