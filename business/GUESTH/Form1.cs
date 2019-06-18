using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUESTH
{
    public partial class Form1 : Form
    {
        private List<String> _col1 = new List<String> { "PetraPalmyra", "DelphinusApollo", "SimplifiedRocket", "AcqueductStructures" ,null,null,null};
        private List<String> _col2 = new List<String> { "PressTheButton", "TheyreShiite", "MosesBitten", null, null, null,null };
        private List<String> _col3 = new List<String> { "HombreDomain", "ElasticPythagoras", "ElasticGeography", "ChemicalThermometer", "OverseerResults", "CompressedCamera","WordsOfNose" };
        private List<String> _col4 = new List<String> { "N/A", null,null, null, null, null, null };
        private List<String> _col5 = new List<String> { "N/A", null, null, null, null, null, null };
        private List<String> _col6 = new List<String> { "N/A", null, null, null, null, null, null };
        private List<int> _count = new List<int> { 4, 3, 7, 1, 1, 1 };
        private int mnMode;

        private void fShow(int nMode)
        {
            int nCount;
            String sText;

            mnMode=nMode;
            nCount = _count[nMode - 1];

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for(int i = 1; i <= nCount; i++)
            {
                switch (nMode)
                {
                    case 1:
                        sText = _col1[i - 1];
                        break;
                    case 2:
                        sText = _col2[i - 1];
                        break;
                    case 3:
                        sText = _col3[i - 1];
                        break;
                    case 4:
                        sText = _col4[i - 1];
                        break;
                    case 5:
                        sText = _col5[i - 1];
                        break;
                    default:
                        sText = _col6[i - 1];
                        break;
                }
                lst1.Items.Add(sText);
            }
        }
        public Form1()
        {
            InitializeComponent();
            Random rnd1 = new Random();
            mnMode = rnd1.Next(1, 7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fShow(mnMode);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            fShow(5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            fShow(6);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fShow(4);
        }
    }
}
