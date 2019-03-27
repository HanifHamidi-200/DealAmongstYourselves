using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHESNK
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int nNumber;
        private int mnCol, mnRow;
        private int mnPos;

        private void fTry()
        {
            if (btnYou.BackColor == Color.Black)
            {
                MessageBox.Show("You win", "GWin");
                fReset();
            }
        }
        private void fNav(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    mnCol--;
                    mnRow--;
                    fAdjust(ref mnCol, ref mnRow);
                    break;
                case 2:
                     mnRow--;
                    fAdjust(ref mnCol, ref mnRow);
                    break;
                case 3:
                    mnCol++;
                    mnRow--;
                    fAdjust(ref mnCol, ref mnRow);
                    break;
                case 4:
                    mnCol++;
                    fAdjust(ref mnCol, ref mnRow);
                    break;
                case 5:
                    mnRow++;
                    fAdjust(ref mnCol, ref mnRow);
                    break;
                default:
                    mnCol--;
                    fAdjust(ref mnCol, ref mnRow);
                    break;
            }

            fUpdateDisplay();
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nType;
            String sTwo;
            int nCol = rnd1.Next(1, 11);
            int nRow = rnd1.Next(1, 11);
      
            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304050607080910";
            msShuffle2 = null;
            mnPos = (nCol - 1) * 10 + nRow;

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    nType = rnd1.Next(1, 5);
                    sTwo = "0" + Convert.ToString(nType);
                    msShuffle2 = msShuffle2 + sTwo;
                }
            }

            mnCol = rnd1.Next(1, 11);
            mnRow = rnd1.Next(1, 11);

            fPlace("05", mnPos);
  
            fUpdateDisplay();
        }

            private void fPlace(String sText,int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, (nPos - 1) * 2) + sText + msShuffle2.Substring(nPos * 2, (100 - nPos) * 2);
        }
        private void fUpdateStatus()
        {
            int nPos = (mnCol - 1) * 10 + mnRow;
            String sText = "nPos = " + Convert.ToString(nPos) + " of " + Convert.ToString(mnPos);

            lblPos.Text = sText;

        }
        private void fUpdateDisplay()
        {
            int nType;
            Color nColour;
            int nCol, nRow, nPos;
            int nSavecol = mnCol;
            int nSaverow = mnRow;

            nCol = nSavecol;
            nRow = nSaverow;
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btnYou.BackColor = nColour;

            nCol = nSavecol-1;
            nRow = nSaverow-1;
            fAdjust(ref nCol, ref nRow);
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btn1.BackColor = nColour;

            nCol = nSavecol;
            nRow = nSaverow - 1;
            fAdjust(ref nCol, ref nRow);
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btn2.BackColor = nColour;

            nCol = nSavecol + 1;
            nRow = nSaverow - 1;
            fAdjust(ref nCol, ref nRow);
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btn3.BackColor = nColour;

            nCol = nSavecol +1;
            nRow = nSaverow ;
            fAdjust(ref nCol, ref nRow);
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btn4.BackColor = nColour;

            nCol = nSavecol ;
            nRow = nSaverow + 1;
            fAdjust(ref nCol, ref nRow);
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btn5.BackColor = nColour;

            nCol = nSavecol - 1;
            nRow = nSaverow ;
            fAdjust(ref nCol, ref nRow);
            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(nPos);
            nColour = fColour(nType);
            btn6.BackColor = nColour;

            fUpdateStatus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void fAdjust(ref int nCol,ref int nRow)
        {
            if (nCol == 0)
            {
                nCol = 10;
            }
            if (nCol == 11)
            {
                nCol = 1;
            }


            if (nRow == 0)
            {
                nRow = 10;
            }
            if (nRow == 11)
            {
                nRow = 1;
            }
        }
        private Color fColour(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Blue;
                case 4:
                    return Color.Yellow;
                default:
                    return Color.Black;
            }
        }
        private int fHoletype(int nPos)
        {
            String sTwo = msShuffle2.Substring((nPos - 1) * 2, 2);

            return Convert.ToInt32(sTwo);
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            fNav(5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            fNav(6);
        }

        private void BtnYou_Click(object sender, EventArgs e)
        {
            fTry();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
