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
    public partial class fOpinion2 : Form
    {
        private cMDatabase _db = new cMDatabase();
        private cENumber _element = new cENumber();
        private int mnItem;
        private int mnCount;
        private String msElement;
        private int mnMode;
        private List<int> _count = new List<int> { 4, 2, 3, 4, 2, 3, 2, 2, 3, 2, 3, 3 };
        private List<int> _mode1 = new List<int> { 2, 3, 5, 9 };
        private List<int> _mode2 = new List<int> { 7, 12, 0, 0 };
        private List<int> _mode3 = new List<int> { 4, 5, 7, 0 };
        private List<int> _mode4 = new List<int> { 5, 8, 10, 11 };
        private List<int> _mode5 = new List<int> { 3, 4, 0, 0 };
        private List<int> _mode6 = new List<int> { 1, 2, 3, 0 };
        private List<int> _mode7 = new List<int> { 10, 11, 0, 0 };
        private List<int> _mode8 = new List<int> { 10, 11, 0, 0 };
        private List<int> _mode9 = new List<int> { 2, 3, 10, 0 };
        private List<int> _mode10 = new List<int> { 7, 12, 0, 0 };
        private List<int> _mode11 = new List<int> { 2, 3, 9, 0 };
        private List<int> _mode12 = new List<int> { 1, 7, 11, 0 };
        private List<String> _text = new List<String> { "C", "N", "O", "F", "P", "S", "Cl", "Se", "Br", "I", "At", "Ts" };

        private void fGo(int i)
        {
            int nButton;

            switch (mnMode)
            {
                case 1:
                    nButton = _mode1[i - 1];
                    break;
                case 2:
                    nButton = _mode2[i - 1];
                    break;
                case 3:
                    nButton = _mode3[i - 1];
                    break;
                case 4:
                    nButton = _mode4[i - 1];
                    break;
                case 5:
                    nButton = _mode5[i - 1];
                    break;
                case 6:
                    nButton = _mode6[i - 1];
                    break;
                case 7:
                    nButton = _mode7[i - 1];
                    break;
                case 8:
                    nButton = _mode8[i - 1];
                    break;
                case 9:
                    nButton = _mode9[i - 1];
                    break;
                case 10:
                    nButton = _mode10[i - 1];
                    break;
                case 11:
                    nButton = _mode11[i - 1];
                    break;
                default:
                    nButton = _mode12[i - 1];
                    break;
            }

            if (nButton != 0)
            {
                _element.fSave(mnItem, nButton, true);
                fMSub2 _dlg = new fMSub2();
                _dlg.ShowDialog();
            }


        }
        private void fUpdateDisplay()
        {
            int nButton=0;
            String sText;

            for(int i = 1; i <= 4; i++)
            {

            switch (mnMode)
            {
                case 1:
                    nButton = _mode1[i-1];
                    break;
                case 2:
                    nButton = _mode2[i-1];
                    break;
                case 3:
                    nButton = _mode3[i-1];
                    break;
                case 4:
                    nButton = _mode4[i-1];
                    break;
                case 5:
                    nButton = _mode5[i-1];
                    break;
                case 6:
                    nButton = _mode6[i-1];
                    break;
                case 7:
                    nButton = _mode7[i-1];
                    break;
                case 8:
                    nButton = _mode8[i-1];
                    break;
                case 9:
                    nButton = _mode9[i-1];
                    break;
                case 10:
                    nButton = _mode10[i-1];
                    break;
                case 11:
                    nButton = _mode11[i-1];
                    break;
                default:
                    nButton = _mode12[i-1];
                    break;
            }

                if (nButton == 0)
                {
                    sText = "N/A";
                }
                else
                {
                    sText = "[" + _text[nButton - 1] + "]";
                }
                switch (i)
                {
                    case 1:
                        btn1.Text = sText;
                        break;
                    case 2:
                        btn2.Text = sText;
                        break;
                    case 3:
                        btn3.Text = sText;
                        break;
                    default:
                        btn4.Text = sText;
                        break;
                }
            }


        }

        public fOpinion2()
        {
            bool bError;

            InitializeComponent();
            bError = _db.fFLoad();
            if (bError)
            {
                MessageBox.Show("There was an error reading the File", "Error!");
            }
            else
            {
                mnCount = _db.fGetCount();
                mnItem = _element.fGet();
                msElement = _db.fGetCombination(mnItem);
                mnMode = _db.fGetMode(mnItem);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FOpinion2_Load(object sender, EventArgs e)
        {
            fUpdateDisplay();
        }

        private void FOpinion2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _element.fSave(mnItem, mnMode, true);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fGo(1);
        }

        private void v(object sender, EventArgs e)
        {
            fGo(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fGo(3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            fGo(4);
        }
    }
}
