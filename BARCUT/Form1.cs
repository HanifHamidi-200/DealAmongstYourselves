using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARCUT
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int mnBar, mnRow, mnRotate;
        private int nNumber;
        private bool mbStart;

        private bool fValid()
        {
            int nPos = (mnBar - 1) * 10 + mnRow;
            int nType = fHoletype(msShuffle2, nPos);

            if (nType != 5)
            {
                return false;
            }

            if (mnBar >= 7)
            {
                if (mnRow == 1)
                {
                    return true;
                }
                else
                {
                    nPos = (mnBar - 1) * 10 + mnRow-1;
                    nType = fHoletype(msShuffle2, nPos);
                    if (nType == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        private void fClick(int nBar,int nRow)
        {
            fra1.Text = "Selected = (" + Convert.ToString(nBar) + "," + Convert.ToString(nRow) + ")";
        }

        private void fNav(int nMode)
        {
            Random rnd1 = new Random();
            int nSavebar = mnBar;
            int nSaverow = mnRow;

            mnRotate = nMode;
            switch (nMode)
            {
                case 1:
                    mnRow--;
                    if (mnRow == 0)
                    {
                        mnRow = 8;
                    }
                    break;
                case 2:
                    mnBar++;
                    if (mnBar == 9)
                    {
                        mnBar = 1;
                    }
                    break;
                case 3:
                    mnRow++;
                    if (mnRow == 9)
                    {
                        mnRow = 1;
                    }
                    break;
                default:
                    mnBar--;
                    if (mnBar == 0)
                    {
                        mnBar = 8;
                    }
                    break;
            }

            fUpdateReveal(nSavebar, nSaverow);
            fUpdateIcon();
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nTop,nColour;
            int nPos;

            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304050607080910";
            msShuffle2 = null;
            fra2.Visible = false;
            mbStart = false;

            for (int i = 1; i <= 100; i++)
            {
                msShuffle2 = msShuffle2 + sTwo;
            }

            for(int i = 1; i <= 6; i++)
            {
                nTop = rnd1.Next(5, 11);
                nColour = rnd1.Next(2, 5);
                for(int j = nTop; j <= 10; j++)
                {
                    nPos = (i - 1) * 10 + j;
                    fPlace(nColour, nPos);
                }
            }
            nColour = 5;
            for (int i = 7; i <= 10; i++)
            {
                nTop = rnd1.Next(1, 11);
                for (int j = nTop; j <= 10; j++)
                {
                    nPos = (i - 1) * 10 + j;
                    fPlace(nColour, nPos);
                }
            }

            fUpdateDisplay();
        }

        private void fPlace(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle2.Substring(nSquare * 2, (100 - nSquare) * 2);
        }

        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType, nPos;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                if (nType == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }
        private void fUpdateReveal(int nBar, int nRow)
        {
            PictureBox _pic = new PictureBox();
            int nPos = (nBar - 1) * 8 + nRow;
            int nType = fHoletype(msShuffle2, nPos), nRotate = 1;

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


        private void fUpdateIcon()
        {
            PictureBox _pic = new PictureBox();
            int nType = 3, nRotate = mnRotate;

            fPeek(nType, nRotate, ref _pic);

            switch (mnBar)
            {
                case 1:
                    switch (mnRow)
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
                    switch (mnRow)
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
                    switch (mnRow)
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
                    switch (mnRow)
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
                    switch (mnRow)
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
                    switch (mnRow)
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
                    switch (mnRow)
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
                    switch (mnRow)
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
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic19.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic1a.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic29.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic2a.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic39.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic3a.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            fPeek(nType, nRotate, ref _pic);
            pic49.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            fPeek(nType, nRotate, ref _pic);
            pic4a.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 41);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 42);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 43);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 44);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 45);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 46);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 47);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 48);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 49);
            fPeek(nType, nRotate, ref _pic);
            pic59.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 50);
            fPeek(nType, nRotate, ref _pic);
            pic5a.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 51);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 52);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 53);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 54);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 55);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 56);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 57);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 58);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 59);
            fPeek(nType, nRotate, ref _pic);
            pic69.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 60);
            fPeek(nType, nRotate, ref _pic);
            pic6a.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 61);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 62);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 63);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 64);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 65);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 66);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 67);
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 68);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 69);
            fPeek(nType, nRotate, ref _pic);
            pic79.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 70);
            fPeek(nType, nRotate, ref _pic);
            pic7a.Image = _pic.Image;

            //8
            nType = fHoletype(msShuffle2, 71);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 72);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 73);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 74);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 75);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 76);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 77);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 78);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 79);
            fPeek(nType, nRotate, ref _pic);
            pic89.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 80);
            fPeek(nType, nRotate, ref _pic);
            pic8a.Image = _pic.Image;

            //9
            nType = fHoletype(msShuffle2, 81);
            fPeek(nType, nRotate, ref _pic);
            pic91.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 82);
            fPeek(nType, nRotate, ref _pic);
            pic92.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 83);
            fPeek(nType, nRotate, ref _pic);
            pic93.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 84);
            fPeek(nType, nRotate, ref _pic);
            pic94.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 85);
            fPeek(nType, nRotate, ref _pic);
            pic95.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 86);
            fPeek(nType, nRotate, ref _pic);
            pic96.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 87);
            fPeek(nType, nRotate, ref _pic);
            pic97.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 88);
            fPeek(nType, nRotate, ref _pic);
            pic98.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 89);
            fPeek(nType, nRotate, ref _pic);
            pic99.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 90);
            fPeek(nType, nRotate, ref _pic);
            pic9a.Image = _pic.Image;

            //10
            nType = fHoletype(msShuffle2, 91);
            fPeek(nType, nRotate, ref _pic);
            pica1.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 92);
            fPeek(nType, nRotate, ref _pic);
            pica2.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 93);
            fPeek(nType, nRotate, ref _pic);
            pica3.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 94);
            fPeek(nType, nRotate, ref _pic);
            pica4.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 95);
            fPeek(nType, nRotate, ref _pic);
            pica5.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 96);
            fPeek(nType, nRotate, ref _pic);
            pica6.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 97);
            fPeek(nType, nRotate, ref _pic);
            pica7.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 98);
            fPeek(nType, nRotate, ref _pic);
            pica8.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 99);
            fPeek(nType, nRotate, ref _pic);
            pica9.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 100);
            fPeek(nType, nRotate, ref _pic);
            picaa.Image = _pic.Image;

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
                Image = Image.FromFile(@"F blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F green.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F purple.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
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
                default:
                    _pic2 = picture6;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void BtnNav1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void BtnNav2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void BtnNav4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnBar = rnd1.Next(1, 11);
            mnRow = rnd1.Next(1, 11);

            fSelectBar(mnBar);
            fReset();
        }
        private void fSelectRow(int nMode)
        {
            int nType, nPos;

            mnRow = nMode;

            nPos = (mnBar - 1) * 10 + mnRow;
            nType = fHoletype(msShuffle2, nPos);

            if (nType == 5)
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
            btnBar9.BackColor = Color.Yellow;
            btnBara.BackColor = Color.Yellow;

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
                case 8:
                    btnBar8.BackColor = Color.Red;
                    break;
                case 9:
                    btnBar9.BackColor = Color.Red;
                    break;
                default:
                    btnBara.BackColor = Color.Red;
                    break;
            }
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

        private void BtnBar9_Click(object sender, EventArgs e)
        {
            fSelectBar(9);
        }

        private void BtnBara_Click(object sender, EventArgs e)
        {
            fSelectBar(10);
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

        private void Pic16_Click(object sender, EventArgs e)
        {
            fSelectRow(6);
        }

        private void Pic17_Click(object sender, EventArgs e)
        {
            fSelectRow(7);
        }

       
        private void Pic18_Click(object sender, EventArgs e)
        {
            fSelectRow(8);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            bool bValid = fValid();

            if (mbStart)
            {
                goto endline;
            }

            if (bValid)
            {
                mbStart = true;
                fra2.Visible = true;
            }

        endline:;
        }

        private void Pic19_Click(object sender, EventArgs e)
        {
            fSelectRow(9);
        }

        private void Pic1a_Click(object sender, EventArgs e)
        {
            fSelectRow(10);
        }

    }
}

