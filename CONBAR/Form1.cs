using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONBAR
{
    public partial class Form1 : Form
    {
        private void fCalculate(int nFarming,int nMining)
        {
            int nTogether = nFarming + nMining;
            int nMax=0,nMinus=0;

            if (nTogether <= 100)
            {
                nMax = 100;
            }
            else
            {
                if (nTogether <= 1000)
                {
                    nMax = 1000;
                }
                else
                {
                    if (nTogether <= 10000)
                    {
                        nMax = 10000;
                    }
                    else
                    {
                        nMax = 1000000;
                    }
                }
            }
            nMinus = nMax - nTogether;
            lblConstruction.Text = "Answer = " + Convert.ToString(nMinus);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            fCalculate(Convert.ToInt32(txtFarming.Text), Convert.ToInt32(txtMining.Text));
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            String sLine;

            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@"Data.txt"))
                {

                    sLine = file.ReadLine();
                    file.Close();
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                goto endline;
            }

            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        endline:;
        }

     }
}
