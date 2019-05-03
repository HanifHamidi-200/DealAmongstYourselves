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
    public partial class fSub2 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msShuffle3;
        private int mnBar, mnRow;
        private int mnActiveBar, mnActiveRow;
        private int mnFindBar,mnFindRow;
        private int mnFindMode, mnFindNumber;
        private bool mbFindTrue;
        private List<int> _height = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _width = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _depth = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _red = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _yellow = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _blue = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private int nNumber;
        private List<int> _pass1 = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _pass2 = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _pass3 = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _pass4 = new List<int> { 0, 0, 0, 0, 0 };
        private List<bool> _pass5 = new List<bool> {false,false,false,false,false };
        private List<bool> _passdone = new List<bool> { false, false, false, false, false };
        private int mnPass;
        private int mnWinNumber,mnDoneNumber;

        private void fPass1()
        {
            mnPass++;
            if (mnPass > 5)
            {
                MessageBox.Show("You lose", "GEnd");
                fReset();
            }

            _pass1[mnPass - 1] = mnFindBar;
            _pass2[mnPass - 1] = mnFindRow;
            _pass3[mnPass - 1] = mnFindMode;
            _pass4[mnPass - 1] = mnFindNumber;
            _pass5[mnPass - 1] = mbFindTrue;
            _passdone[mnPass - 1] = false;

            lst1.Items.Add(lblQuestion.Text);
            fFind1();
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sLine;
            int nPos, nType;
            int nCol = 0, nRow = 0;

            mnPass = 0;
            mnWinNumber = 4;
            mnDoneNumber = 0;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@"Data.txt"))
                {

                    sLine = file.ReadLine();
                    msShuffle2 = file.ReadLine();
                    msShuffle3 = file.ReadLine();
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                goto endline;
            }

            for(int i = 1; i <= 64; i++)
            {
                nType = fHoletype(msShuffle3, i);
                if (nType <= 5)
                {
                    _height[i - 1] = 0;
                    _width[i - 1] = 0;
                    _depth[i - 1] = 0;
                    _red[i - 1] = false;
                    _yellow[i - 1] = false;
                    _blue[i - 1] = false;
                }
                else
                {
                    _height[i - 1] = rnd1.Next(1,201);
                    _width[i - 1] = rnd1.Next(1, 201);
                    _depth[i - 1] = rnd1.Next(1, 201);
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {
                        _red[i - 1] = false;
                    }
                    else
                    {
                        _red[i - 1] = true;
                    }
                    if (nNumber <= 5)
                    {
                        _yellow[i - 1] = false;
                    }
                    else
                    {
                        _yellow[i - 1] = true;
                    }
                    if (nNumber <= 5)
                    {
                        _blue[i - 1] = false;
                    }
                    else
                    {
                        _blue[i - 1] = true;
                    }
                }
            }

            fFind1();
            fUpdateDisplay();
            fUpdateStatus();

        endline:;
        }

        private void fFind1()
        {
            Random rnd1 = new Random();
            int nPos, nType;
            int nCol = 0, nRow = 0;

            fFree2(ref nCol, ref nRow);
            nPos = (nCol - 1) * 8 + nRow;

            mnFindBar = nCol;
            mnFindRow = nRow;
            mnFindMode = rnd1.Next(1, 7);
            switch (mnFindMode)
            {
                case 1:
                    mnFindNumber = _height[nPos - 1];
                    mbFindTrue = false;
                    break;
                case 2:
                    mnFindNumber = _width[nPos - 1];
                    mbFindTrue = false;
                    break;
                case 3:
                    mnFindNumber = _depth[nPos - 1];
                    mbFindTrue = false;
                    break;
                case 4:
                    mnFindNumber = 0;
                    mbFindTrue = _red[nPos - 1];
                    break;
                case 5:
                    mnFindNumber = 0;
                    mbFindTrue = _yellow[nPos - 1];
                    break;
                default:
                    mnFindNumber = 0;
                    mbFindTrue = _blue[nPos - 1];
                    break;
            }

            fUpdateFind();
        }

        private void fCheck()
        {
            Random rnd1 = new Random();
            int nPos = (mnBar - 1) * 8 + mnRow;
            int nCheckNumber;
            bool bCheckTrue;
            bool bCorrect = false;

            switch (mnFindMode)
            {
                case 1:
                    nCheckNumber = _height[nPos - 1];
                    if (nCheckNumber == mnFindNumber)
                    {
                        bCorrect = true;
                    }
                    break;
                case 2:
                    nCheckNumber = _width[nPos - 1];
                    if (nCheckNumber == mnFindNumber)
                    {
                        bCorrect = true;
                    }
                    break;
                case 3:
                    nCheckNumber = _depth[nPos - 1];
                    if (nCheckNumber == mnFindNumber)
                    {
                        bCorrect = true;
                    }
                    break;
                case 4:
                    bCheckTrue = _red[nPos - 1];
                    if (bCheckTrue == mbFindTrue)
                    {
                        bCorrect = true;
                    }
                    break;
                case 5:
                    bCheckTrue = _yellow[nPos - 1];
                    if (bCheckTrue == mbFindTrue)
                    {
                        bCorrect = true;
                    }
                    break;
                default:
                    bCheckTrue = _blue[nPos - 1];
                    if (bCheckTrue == mbFindTrue)
                    {
                        bCorrect = true;
                    }
                    break;

            }

            if (!bCorrect)
            {
                MessageBox.Show("Wrong!", "Error");
            }
            else
            {
                mnDoneNumber++;
                if (mnDoneNumber == mnWinNumber)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {
                        mnWinNumber++;
                    }
                    if (mnDoneNumber == mnWinNumber)
                    {
                        fReset();
                        goto endline;
                    }
                }
                fUpdateReveal(mnBar, mnRow);
                fFind1();
            }

        endline:;
        }
        private void fFree2(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType, nPos;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle3, nPos);
                if (nType > 5)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }

        private void fClick(int nCol, int nRow)
        {
            mnActiveBar = mnBar;
            mnActiveRow = mnRow;
        }

        private void fPlace2(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msShuffle3 = msShuffle3.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle3.Substring(nSquare * 2, (64 - nSquare) * 2);
        }

        private void fUpdateFind()
        {
            String sText = "Find ";
            String sText2 = mbFindTrue ? "TRUE" : "FALSE";

            switch (mnFindMode)
            {
                case 1:
                    sText = sText + "height = " + Convert.ToString(mnFindNumber);
                    break;
                case 2:
                    sText = sText + "width = " + Convert.ToString(mnFindNumber);
                    break;
                case 3:
                    sText = sText + "depth = " + Convert.ToString(mnFindNumber);
                    break;
                case 4:
                    sText = sText + "red = " + sText2;
                    break;
                case 5:
                    sText = sText + "yellow = " + sText2;
                    break;
                default:
                    sText = sText + "blue = " + sText2;
                    break;
            }
            lblQuestion.Text = sText;
        }

        private void fUpdateStatus()
        {
            int nPos = (mnBar - 1) * 8 + mnRow;
            bool bTrue;

            fraSelected.Text = "Selected = (" + Convert.ToString(mnBar) + "," + Convert.ToString(mnRow) + ")";
            lbl1.Text = "HxWxD = "+Convert.ToString(_height[nPos-1])+"x"+Convert.ToString(_width[nPos - 1])+"x" + Convert.ToString(_depth[nPos - 1]);
             bTrue = _red[nPos - 1];
            if (bTrue)
            {
                lbl2.Text = "RedWire = TRUE";
            }
            else
            {
                lbl2.Text = "RedWire = FALSE";
            }
            bTrue = _yellow[nPos - 1];
            if (bTrue)
            {
                lbl3.Text = "YellowWire = TRUE";
            }
            else
            {
                lbl3.Text = "YellowWire = FALSE";
            }
            bTrue = _blue[nPos - 1];
            if (bTrue)
            {
                lbl4.Text = "BlueWire = TRUE";
            }
            else
            {
                lbl4.Text = "BlueWire = FALSE";
            }
        }

        private void fUpdateReveal(int nBar, int nRow)
        {
            PictureBox _pic = new PictureBox();
            int nPos = (nBar - 1) * 8 + nRow;
            int nType = fHoletype(msShuffle2, nPos), nRotate = 1;

            fPlace2(nType, nPos);
            fPeek(nType, nRotate, ref _pic);

            switch (nBar)
            {
                case 1:
                    switch (nRow)
                    {
                        case 1:
                            pic11.Image = _pic.Image;
                            break;
                        case 2:
                            pic12.Image = _pic.Image;
                            break;
                        case 3:
                            pic13.Image = _pic.Image;
                            break;
                        case 4:
                            pic14.Image = _pic.Image;
                            break;
                        case 5:
                            pic15.Image = _pic.Image;
                            break;
                        case 6:
                            pic16.Image = _pic.Image;
                            break;
                        case 7:
                            pic17.Image = _pic.Image;
                            break;
                        default:
                            pic18.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (nRow)
                    {
                        case 1:
                            pic21.Image = _pic.Image;
                            break;
                        case 2:
                            pic22.Image = _pic.Image;
                            break;
                        case 3:
                            pic23.Image = _pic.Image;
                            break;
                        case 4:
                            pic24.Image = _pic.Image;
                            break;
                        case 5:
                            pic25.Image = _pic.Image;
                            break;
                        case 6:
                            pic26.Image = _pic.Image;
                            break;
                        case 7:
                            pic27.Image = _pic.Image;
                            break;
                        default:
                            pic28.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (nRow)
                    {
                        case 1:
                            pic31.Image = _pic.Image;
                            break;
                        case 2:
                            pic32.Image = _pic.Image;
                            break;
                        case 3:
                            pic33.Image = _pic.Image;
                            break;
                        case 4:
                            pic34.Image = _pic.Image;
                            break;
                        case 5:
                            pic35.Image = _pic.Image;
                            break;
                        case 6:
                            pic36.Image = _pic.Image;
                            break;
                        case 7:
                            pic37.Image = _pic.Image;
                            break;
                        default:
                            pic38.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:
                    switch (nRow)
                    {
                        case 1:
                            pic41.Image = _pic.Image;
                            break;
                        case 2:
                            pic42.Image = _pic.Image;
                            break;
                        case 3:
                            pic43.Image = _pic.Image;
                            break;
                        case 4:
                            pic44.Image = _pic.Image;
                            break;
                        case 5:
                            pic45.Image = _pic.Image;
                            break;
                        case 6:
                            pic46.Image = _pic.Image;
                            break;
                        case 7:
                            pic47.Image = _pic.Image;
                            break;
                        default:
                            pic48.Image = _pic.Image;
                            break;
                    }
                    break;
                case 5:
                    switch (nRow)
                    {
                        case 1:
                            pic51.Image = _pic.Image;
                            break;
                        case 2:
                            pic52.Image = _pic.Image;
                            break;
                        case 3:
                            pic53.Image = _pic.Image;
                            break;
                        case 4:
                            pic54.Image = _pic.Image;
                            break;
                        case 5:
                            pic55.Image = _pic.Image;
                            break;
                        case 6:
                            pic56.Image = _pic.Image;
                            break;
                        case 7:
                            pic57.Image = _pic.Image;
                            break;
                        default:
                            pic58.Image = _pic.Image;
                            break;
                    }
                    break;
                case 6:
                    switch (nRow)
                    {
                        case 1:
                            pic61.Image = _pic.Image;
                            break;
                        case 2:
                            pic62.Image = _pic.Image;
                            break;
                        case 3:
                            pic63.Image = _pic.Image;
                            break;
                        case 4:
                            pic64.Image = _pic.Image;
                            break;
                        case 5:
                            pic65.Image = _pic.Image;
                            break;
                        case 6:
                            pic66.Image = _pic.Image;
                            break;
                        case 7:
                            pic67.Image = _pic.Image;
                            break;
                        default:
                            pic68.Image = _pic.Image;
                            break;
                    }
                    break;
                case 7:
                    switch (nRow)
                    {
                        case 1:
                            pic71.Image = _pic.Image;
                            break;
                        case 2:
                            pic72.Image = _pic.Image;
                            break;
                        case 3:
                            pic73.Image = _pic.Image;
                            break;
                        case 4:
                            pic74.Image = _pic.Image;
                            break;
                        case 5:
                            pic75.Image = _pic.Image;
                            break;
                        case 6:
                            pic76.Image = _pic.Image;
                            break;
                        case 7:
                            pic77.Image = _pic.Image;
                            break;
                        default:
                            pic78.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (nRow)
                    {
                        case 1:
                            pic81.Image = _pic.Image;
                            break;
                        case 2:
                            pic82.Image = _pic.Image;
                            break;
                        case 3:
                            pic83.Image = _pic.Image;
                            break;
                        case 4:
                            pic84.Image = _pic.Image;
                            break;
                        case 5:
                            pic85.Image = _pic.Image;
                            break;
                        case 6:
                            pic86.Image = _pic.Image;
                            break;
                        case 7:
                            pic87.Image = _pic.Image;
                            break;
                        default:
                            pic88.Image = _pic.Image;
                            break;
                    }
                    break;
            }
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle3, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle3, 9);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 10);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 11);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 12);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 13);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 14);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 15);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 16);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle3, 17);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 18);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 19);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 20);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 21);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 22);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 23);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 24);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle3, 25);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 26);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 27);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 28);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 29);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 30);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 31);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 32);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle3, 33);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 34);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 35);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 36);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 37);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 38);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 39);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 40);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle3, 41);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 42);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 43);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 44);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 45);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 46);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 47);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 48);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle3, 49);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 50);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 51);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 52);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 53);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 54);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 55);
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 56);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = fHoletype(msShuffle3, 57);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 58);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 59);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 60);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 61);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 62);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 63);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 64);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;
        }


        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }


        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F col_blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F col_green.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F col_purple.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F col_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F computers.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F construction.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F farming.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F fishing.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F mining.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F prison.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                default:
                    _pic2 = picture12;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

    
        private void fSelectRow(int nMode)
        {
            int nType, nPos;

            mnRow = nMode;
            fUpdateStatus();

            nPos = (mnBar - 1) * 8 + mnRow;
            nType = fHoletype(msShuffle2, nPos);
            if (nType > 5)
            {
                fClick(mnBar, mnRow);
            }
        }
        private void fSelectBar(int nMode)
        {
            mnBar = nMode;

            btnBar1.BackColor = Color.Yellow;
            btnBar2.BackColor = Color.Yellow;
            btnBar3.BackColor = Color.Yellow;
            btnBar4.BackColor = Color.Yellow;
            btnBar5.BackColor = Color.Yellow;
            btnBar6.BackColor = Color.Yellow;
            btnBar7.BackColor = Color.Yellow;
            btnBar8.BackColor = Color.Yellow;

            switch (mnBar)
            {
                case 1:
                    btnBar1.BackColor = Color.Red;
                    break;
                case 2:
                    btnBar2.BackColor = Color.Red;
                    break;
                case 3:
                    btnBar3.BackColor = Color.Red;
                    break;
                case 4:
                    btnBar4.BackColor = Color.Red;
                    break;
                case 5:
                    btnBar5.BackColor = Color.Red;
                    break;
                case 6:
                    btnBar6.BackColor = Color.Red;
                    break;
                case 7:
                    btnBar7.BackColor = Color.Red;
                    break;
                default:
                    btnBar8.BackColor = Color.Red;
                    break;
            }
            fUpdateStatus();
        }

        public fSub2()
        {
            InitializeComponent();
        }

        private void FSub2_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnBar = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);

            fSelectBar(mnBar);
            fReset();
        }

        private void BtnBar1_Click(object sender, EventArgs e)
        {
            fSelectBar(1);
        }

        private void BtnBar2_Click(object sender, EventArgs e)
        {
            fSelectBar(2);
        }

        private void BtnBar3_Click(object sender, EventArgs e)
        {
            fSelectBar(3);
        }

        private void BtnBar4_Click(object sender, EventArgs e)
        {
            fSelectBar(4);
        }

        private void BtnBar5_Click(object sender, EventArgs e)
        {
            fSelectBar(5);
        }

        private void BtnBar6_Click(object sender, EventArgs e)
        {
            fSelectBar(6);
        }

        private void BtnBar7_Click(object sender, EventArgs e)
        {
            fSelectBar(7);
        }

        private void BtnBar8_Click(object sender, EventArgs e)
        {
            fSelectBar(8);
        }

        private void Pic11_Click(object sender, EventArgs e)
        {
            fSelectRow(1);
        }

        private void Pic12_Click(object sender, EventArgs e)
        {
            fSelectRow(2);
        }

        private void Pic13_Click(object sender, EventArgs e)
        {
            fSelectRow(3);
        }

        private void Pic14_Click(object sender, EventArgs e)
        {
            fSelectRow(4);
        }

        private void Pic15_Click(object sender, EventArgs e)
        {
            fSelectRow(5);
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            fPass1();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            fCheck();
        }

        private void Pic16_Click(object sender, EventArgs e)
        {
            fSelectRow(6);
        }

        private void Pic17_Click(object sender, EventArgs e)
        {
            fSelectRow(7);
        }

        private void BtnQNext_Click_1(object sender, EventArgs e)
        {
            fReset();

        }

        private void Pic18_Click(object sender, EventArgs e)
        {
            fSelectRow(8);
        }

    }
}
