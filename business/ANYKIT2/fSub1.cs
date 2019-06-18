using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANYKIT2
{
    public partial class fSub1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int mnBar, mnRow, mnRotate;
        private int nNumber;
        private List<int> _wormcol = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _wormrow = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _wormdirection = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _wormgone = new List<bool> { false, false, false, false, false, false, false, false, false, false };
        private int mnCount;
        private bool mbDiagonal, mbFast;
        private int mnScore;

        private void fOffset(int nAcross,int nDown,ref int nCol,ref int nRow)
        {
            if (nAcross >= 0)
            {
                nCol += nAcross;
                if (nCol > 8)
                {
                    nCol -= 8;
                }
            }
            else
            {
                nCol += nAcross;
                if (nCol < 1)
                {
                    nCol += 8;
                }
            }

            if (nDown >= 0)
            {
                nRow += nDown;
                if (nRow > 8)
                {
                    nRow -= 8;
                }
            }
            else
            {
                nRow += nDown;
                if (nRow < 1)
                {
                    nRow += 8;
                }
            }
        }

        private void fShoot()
        {
            int nPos,nType;

            if (mbFast)
            {
                for(int i = 1; i <= 8; i++)
                {
                    if (i != mnBar)
                    {
                        nPos = (i - 1) * 8 + mnRow;
                        nType = fHoletype(msShuffle2, nPos);
                        if (nType != 1)
                        {
                            mnScore += 20;
                            fUpdateStatus();
                        }
                        fPlace(4, nPos);
                        fUpdateReveal(i, mnRow);
                    }
                }
                for (int i = 1; i <= 8; i++)
                {
                    if (i != mnRow)
                    {
                        nPos = (mnBar - 1) * 8 + i;
                        nType = fHoletype(msShuffle2, nPos);
                        if (nType != 1)
                        {
                            mnScore += 20;
                            fUpdateStatus();
                        }
                        fPlace(4, nPos);
                        fUpdateReveal(mnBar, i);
                    }
                }
            }
            else
            {
                switch (mnRotate)
                {
                    case 1:
                        for (int i = 1; i <= 8; i++)
                        {
                            if (i != mnRow)
                            {
                                nPos = (mnBar - 1) * 8 + i;
                                nType = fHoletype(msShuffle2, nPos);
                                if (nType != 1)
                                {
                                    mnScore += 20;
                                    fUpdateStatus();
                                }
                                fPlace(4, nPos);
                                fUpdateReveal(mnBar, i);
                            }
                        }
                        break;
                    case 3:
                        for (int i = 1; i <= 8; i++)
                        {
                            if (i != mnRow)
                            {
                                nPos = (mnBar - 1) * 8 + i;
                                nType = fHoletype(msShuffle2, nPos);
                                if (nType != 1)
                                {
                                    mnScore += 20;
                                    fUpdateStatus();
                                }
                                fPlace(4, nPos);
                                fUpdateReveal(mnBar, i);
                            }
                        }
                        break;
                    default:
                        for (int i = 1; i <= 8; i++)
                        {
                            if (i != mnBar)
                            {
                                nPos = (i - 1) * 8 + mnRow;
                                nType = fHoletype(msShuffle2, nPos);
                                if (nType != 1)
                                {
                                    mnScore += 20;
                                    fUpdateStatus();
                                }
                                fPlace(4, nPos);
                                fUpdateReveal(i, mnRow);
                            }
                        }
                        break;
                }
            }

            tmrClear.Enabled = true;
        }

        private void fBomb()
        {
            int nCol, nRow;
            int nSavecol = mnBar;
            int nSaverow = mnRow;
            int nPos, nType;

            if (mbFast)
            {
                for(int i =  - 2; i <=  2; i++)
                {
                    for(int j =  - 2; j <=  2; j++)
                    {
                        nCol = nSavecol;
                        nRow = nSaverow;
                        fOffset(i, j, ref nCol, ref nRow);
                        nPos = (nCol - 1) * 8 + nRow;
                        nType = fHoletype(msShuffle2, nPos);
                        if (nType != 1)
                        {
                            mnScore += 20;
                            fUpdateStatus();
                        }
                        fPlace(2, nPos);
                        fUpdateReveal(nCol, nRow);
                    }
                }
            }
            else
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        nCol = nSavecol;
                        nRow = nSaverow;
                        fOffset(i, j, ref nCol, ref nRow);
                        nPos = (nCol - 1) * 8 + nRow;
                        nType = fHoletype(msShuffle2, nPos);
                        if (nType != 1)
                        {
                            mnScore += 20;
                            fUpdateStatus();
                        }
                        fPlace(2, nPos);
                        fUpdateReveal(nCol, nRow);
                    }
                }

            }

            fUpdateIcon();
        }

        private int fWormCount()
        {
            int nCount = 0;

            for(int i = 1; i <= mnCount; i++)
            {
                if (_wormgone[i - 1] == false)
                {
                    nCount++;
                }
            }

            return nCount;
        }

        private void fSquareNext(int nDirection,ref int nCol,ref int nRow)
        {
            switch (nDirection)
            {
                case 1:
                    nRow--;
                    if (nRow == 0)
                    {
                        nRow = 8;
                    }
                    break;
                case 2:
                    nCol++;
                    if (nCol == 9)
                    {
                        nCol = 1;
                    }
                    nRow--;
                    if (nRow == 0)
                    {
                        nRow = 8;
                    }
                    break;
                case 3:
                    nCol++;
                    if (nCol == 9)
                    {
                        nCol = 1;
                    }
                    break;
                case 4:
                    nCol++;
                    if (nCol == 9)
                    {
                        nCol = 1;
                    }
                    nRow++;
                    if (nRow == 9)
                    {
                        nRow = 1;
                    }
                    break;
                case 5:
                    nRow++;
                    if (nRow == 9)
                    {
                        nRow = 1;
                    }
                    break;
                case 6:
                    nCol--;
                    if (nCol == 0)
                    {
                        nCol = 8;
                    }
                    nRow++;
                    if (nRow == 9)
                    {
                        nRow = 1;
                    }
                    break;
                case 7:
                    nCol--;
                    if (nCol == 0)
                    {
                        nCol = 8;
                    }
                    break;
                default:
                    nCol--;
                    if (nCol == 0)
                    {
                        nCol = 8;
                    }
                    nRow--;
                    if (nRow == 0)
                    {
                        nRow = 8;
                    }
                    break;
            }
        }

        private void fWormReset()
        {
            for(int i = 1; i <= 10; i++)
            {
                _wormcol[i - 1] = 0;
                _wormrow[i - 1] = 0;
                _wormdirection[i - 1] = 0;
                _wormgone[i - 1] = true;
            }
        }
        private void fNav(int nMode)
        {
            Random rnd1 = new Random();
            int nSavebar = mnBar;
            int nSaverow = mnRow;
            int nPos, nType;

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

            nPos = (mnBar - 1) * 8 + mnRow;
            nType = fHoletype(msShuffle2, nPos);
            if (nType != 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("You lose", "GEnd");
                fReset();
                goto endline;
            }

            fUpdateReveal(nSavebar, nSaverow);
            fUpdateIcon();

        endline:;
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nCol = 0, nRow = 0;
            int nCount = rnd1.Next(4, 11);
            int nPos;

            timer1.Enabled=false;
            tmrClear.Enabled = false;

            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304";
            msShuffle2 = null;
            mnCount = nCount;
            fWormReset();

            for (int i = 1; i <= 64; i++)
            {
                 msShuffle2 = msShuffle2 + sTwo;
            }

            for(int i = 1; i <= nCount; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                fPlace(6, nPos);
                _wormcol[i - 1] = nCol;
                _wormrow[i - 1] = nRow;
                if (mbDiagonal)
                {
                    _wormdirection[i - 1] = rnd1.Next(1, 9);
                }
                else
                {
                    _wormdirection[i - 1] = (rnd1.Next(1, 5)-1)*2+1;
                }
                _wormgone[i - 1] = false;
            }

            fFree(ref nCol, ref nRow);
            mnBar = nCol;
            mnRow = nRow;
            mnRotate = rnd1.Next(1, 5);

            fUpdateDisplay();
            fUpdateIcon();

            timer1.Enabled = true;
        }

        private void fPlace(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle2.Substring(nSquare * 2, (64 - nSquare) * 2);
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
            int nType = 7, nRotate = mnRotate;

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

            //2
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 41);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 42);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 43);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 44);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 45);
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 46);
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 47);
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 48);
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 49);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 50);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 51);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 52);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 53);
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 54);
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 55);
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 56);
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            //8
            nType = fHoletype(msShuffle2, 57);
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 58);
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 59);
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 60);
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 61);
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 62);
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 63);
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 64);
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;
        }

        private void fUpdateStatus()
        {
            lblScore.Text = "Score = " + Convert.ToString(mnScore);
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
                Image = Image.FromFile(@"F bomb.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F crystal.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F shoot.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F wall.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F worm.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
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
                default:
                    _pic2 = picture8;
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int nCol, nRow;
            int nPos1,nPos2, nType;
            int nCount = fWormCount();

            if (nCount == 0)
            {
                timer1.Enabled = false;
                mnScore += 100;
                fUpdateStatus();
                goto endline;
            }

            for(int i = 1; i <= mnCount; i++)
            {
                if (_wormgone[i - 1] == false)
                {
                    nCol = _wormcol[i - 1];
                    nRow = _wormrow[i - 1];
                    nPos1 = (nCol - 1) * 8 + nRow;
                    fSquareNext(_wormdirection[i - 1], ref nCol, ref nRow);
                    nPos2 = (nCol - 1) * 8 + nRow;
                    nType = fHoletype(msShuffle2, nPos2);
                    if (nType != 1)
                    {
                        _wormgone[i - 1] = true;
                        fPlace(1, nPos1);
                        fUpdateReveal(_wormcol[i - 1], _wormrow[i - 1]);
                    }
                    else
                    {
                        fPlace(1, nPos1);
                        fUpdateReveal(_wormcol[i - 1], _wormrow[i - 1]);
                        _wormcol[i - 1] = nCol;
                        _wormrow[i - 1] = nRow;
                        fPlace(6, nPos2);
                        fUpdateReveal(_wormcol[i - 1], _wormrow[i - 1]);
                    }
                }
            }

        endline:;
        }

        private void BtnDiagonal_Click(object sender, EventArgs e)
        {
            if (mbDiagonal)
            {
                mbDiagonal=false;
                btnDiagonal.Text = "diagonal = OFF";
            }
            else
            {
                mbDiagonal = true;
                btnDiagonal.Text = "diagonal = ON";
            }
        }

        private void TmrClear_Tick(object sender, EventArgs e)
        {
            int nType;

            for(int i = 1; i <= 64; i++)
            {
                nType = fHoletype(msShuffle2, i);
                if (nType != 1)
                {
                    fPlace(1, i);
                }
            }

            fUpdateDisplay();
            fUpdateIcon();
            tmrClear.Enabled = false;
        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            fShoot();
        }

        private void BtnBomb_Click(object sender, EventArgs e)
        {
            fBomb();
        }

        private void BtnFast_Click(object sender, EventArgs e)
        {
            if (mbFast)
            {
                mbFast = false;
                btnFast.Text = "Fast = OFF";
            }
            else
            {
                mbFast = true;
                btnFast.Text = "Fast = ON";
            }

        }

        public fSub1()
        {
            InitializeComponent();
            mbDiagonal=false;
            mbFast=false;
            mnScore = 0;
            fUpdateStatus();
        }

        private void FSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
