using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEXTNT
{
    public partial class fSub3 : Form
    {
        private int mnWanta,mnWantb,mnWantc;
        private List<int> _numbers_a = new List<int> { 0, 0, 0 };
        private List<int> _numbers_b = new List<int> { 0, 0, 0 };
        private List<int> _numbers_c = new List<int> { 0, 0, 0 };
        private int mnWin = 0;

        private void fReset(int nMode)
        {
            Random rnd1 = new Random();
            int nTotal = 100;
            int nMinus;

            switch (nMode)
            {
                case 1:
                    mnWanta = rnd1.Next(10, 91);
                    nMinus = rnd1.Next(1, nTotal - 1);
                    _numbers_a[0] = nMinus;
                    nTotal -= nMinus;
                    nMinus = rnd1.Next(1, nTotal - 1);
                    _numbers_a[1] = nMinus;
                    nTotal -= nMinus;
                    _numbers_a[2] = nTotal;
                    txtPlusa.Text = null;
                    txtMinusa.Text = null;
                    break;
                case 2:
                    mnWantb = rnd1.Next(10, 91);
                    nMinus = rnd1.Next(1, nTotal - 1);
                    _numbers_b[0] = nMinus;
                    nTotal -= nMinus;
                    nMinus = rnd1.Next(1, nTotal - 1);
                    _numbers_b[1] = nMinus;
                    nTotal -= nMinus;
                    _numbers_b[2] = nTotal;
                    txtPlusb.Text = null;
                    txtMinusb.Text = null;
                    break;
                default:
                    mnWantc = rnd1.Next(10, 91);
                    nMinus = rnd1.Next(1, nTotal - 1);
                    _numbers_c[0] = nMinus;
                    nTotal -= nMinus;
                    nMinus = rnd1.Next(1, nTotal - 1);
                    _numbers_c[1] = nMinus;
                    nTotal -= nMinus;
                    _numbers_c[2] = nTotal;
                    txtPlusc.Text = null;
                    txtMinusc.Text = null;
                    break;
            }

          
        
            fUpdateDisplay(nMode);
        }

        private void fUpdateDisplay(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    lblWanta.Text = "Iwant " + Convert.ToString(mnWanta) + "%";
                    lbl1a.Text = Convert.ToString(_numbers_a[0]) + "%";
                    lbl2a.Text = Convert.ToString(_numbers_a[1]) + "%";
                    lbl3a.Text = Convert.ToString(_numbers_a[2]) + "%";
                    break;
                case 2:
                    lblWantb.Text = "Iwant " + Convert.ToString(mnWantb) + "%";
                    lbl1b.Text = Convert.ToString(_numbers_b[0]) + "%";
                    lbl2b.Text = Convert.ToString(_numbers_b[1]) + "%";
                    lbl3b.Text = Convert.ToString(_numbers_b[2]) + "%";
                    break;
                default:
                    lblWantc.Text = "Iwant " + Convert.ToString(mnWantc) + "%";
                    lbl1c.Text = Convert.ToString(_numbers_c[0]) + "%";
                    lbl2c.Text = Convert.ToString(_numbers_c[1]) + "%";
                    lbl3c.Text = Convert.ToString(_numbers_c[2]) + "%";
                    break;
            }

        }
        private void fCheck1(int nMode,int nNumber)
        {
            int nTotal;

            switch (nMode)
            {
                case 1:
                    for (int i = 1; i <= 3; i++)
                    {
                        nTotal = _numbers_a[i - 1] + nNumber;
                        if (nTotal == mnWanta)
                        {
                            mnWin += 1;
                            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                            fReset(1);
                            goto endline;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 3; i++)
                    {
                        nTotal = _numbers_b[i - 1] + nNumber;
                        if (nTotal == mnWantb)
                        {
                            mnWin += 1;
                            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                            fReset(2);
                            goto endline;
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 3; i++)
                    {
                        nTotal = _numbers_c[i - 1] + nNumber;
                        if (nTotal == mnWantc)
                        {
                            mnWin += 1;
                            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                            fReset(3);
                            goto endline;
                        }
                    }
                    break;
            }

            endline:;
        }
        private void fCheck2(int nMode,int nNumber)
        {
            int nTotal;

            switch (nMode)
            {
                case 1:
                    for (int i = 1; i <= 3; i++)
                    {
                        nTotal = _numbers_a[i - 1] - nNumber;
                        if (nTotal == mnWanta)
                        {
                            mnWin += 1;
                            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                            fReset(1);
                            goto endline;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 3; i++)
                    {
                        nTotal = _numbers_b[i - 1] - nNumber;
                        if (nTotal == mnWantb)
                        {
                            mnWin += 1;
                            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                            fReset(2);
                            goto endline;
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 3; i++)
                    {
                        nTotal = _numbers_c[i - 1] - nNumber;
                        if (nTotal == mnWantc)
                        {
                            mnWin += 1;
                            MessageBox.Show("You win", "GWin" + Convert.ToString(mnWin));
                            fReset(3);
                            goto endline;
                        }
                    }
                    break;
            }

            endline:;
        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset(1);
            fReset(2);
            fReset(3);
        }

        private void btnPlusb_Click(object sender, EventArgs e)
        {
            fCheck1(2, Convert.ToInt32(txtPlusb.Text));
        }

        private void btnPlusc_Click(object sender, EventArgs e)
        {
            fCheck1(3, Convert.ToInt32(txtPlusc.Text));
        }

        private void btnMinusb_Click(object sender, EventArgs e)
        {
            fCheck2(2, Convert.ToInt32(txtMinusb.Text));
        }

        private void btnMinusc_Click(object sender, EventArgs e)
        {
            fCheck2(3, Convert.ToInt32(txtMinusc.Text));
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            fCheck1(1,Convert.ToInt32(txtPlusa.Text));

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            fCheck2(1,Convert.ToInt32(txtMinusa.Text));

        }
    }
}
