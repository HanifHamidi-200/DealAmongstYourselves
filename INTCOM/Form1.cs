using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTCOM
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int mnMode;
        private int nNumber;
        private int mnFlip;
        private int mnCol, mnRow;
        private int mnPoints = 0;

        private void fCheck()
        {
            int nType;
            bool bFound = false;

            for(int i = 1; i <= 64; i++)
            {
                nType = fHoletype(msShuffle2, i);
                switch (nType)
                {
                    case 2:
                        bFound = true;
                        goto endline;
                     case 5:
                        bFound = true;
                        goto endline;
                    default:
                        break;
                }
            }

        endline:;
            if (!bFound)
            {
                mnPoints += 200;
                fReset();
            }
        }
        private void fUppoints()
        {
            Random rnd1 = new Random();
            int nAdd;

            if (mnMode == 1)
            {
                nAdd = rnd1.Next(1, 2001);
            }
            else
            {
                nAdd = rnd1.Next(1, 201);
            }

            mnPoints += nAdd;
            fUpdateStatus();
        }

        private int fLightning()
        {
            Random rnd1 = new Random();
            int nType;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                nType = 3;
            }
            else
            {
                nType = 4;
            }

            return nType;
        }

        private int fAdvance(int nMode)
        {
            Random rnd1 = new Random();

            nNumber = rnd1.Next(1, 10);

            switch (mnFlip)
            {
                case 1:
                    if (nNumber <= 5)
                    {
                        nMode--;
                    }
                    break;
                case 2:
                    if (nNumber <= 5)
                    {
                        nMode++;
                    }
                    break;
                default:
                    break;
            }

            if (nMode == 0)
            {
                nMode = 1;
            }
            if (nMode == 9)
            {
                nMode = 8;
            }

            return nMode;
        }

        private bool fPresent(int nMode)
        {
            switch (nMode)
            {
                case 2:
                    return true;
                case 5:
                    return true;
                default:
                    return false;
            }
        }
        private void fClick(int nMode)
        {
            Random rnd1 = new Random();
            int nPos,nType;
            bool bPresent;

            mnCol = 1;
            mnRow = nMode;
            nPos = (mnCol - 1) * 8 + mnRow;
            nType = fHoletype(msShuffle2, nPos);
            bPresent = fPresent(nType);
            if (bPresent)
            {
                fUppoints();
            }
            nType = fLightning();
            fPlace(nType, nPos);

            for (int i = 1; i <= 7; i++)
            {
                mnCol++;
                mnRow=fAdvance(mnRow);
                nPos = (mnCol - 1) * 8 + mnRow;
                nType = fHoletype(msShuffle2, nPos);
                bPresent = fPresent(nType);
                if (bPresent)
                {
                    fUppoints();
                }
                nType = fLightning();
                fPlace(nType, nPos);
            }

            fUpdateDisplay();
            fFlip();
        }
        private void fFlip()
        {
            Random rnd1 = new Random();

            mnFlip = rnd1.Next(1, 4);

            fUpdateStatus();
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo;
            int nCount = rnd1.Next(4, 21);
            int nPos;

            msShuffle1 = "010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506";
            msShuffle2 = null;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                mnMode = 1;
            }
            else
            {
                mnMode = 2;
            }

            sTwo = "01";
            for(int i = 1; i <= 64; i++)
            {
                msShuffle2 = msShuffle2 + sTwo;
            }

            if (mnMode == 1)
            {
                nPos = fFree();
                fPlace(2, nPos);
            }
            else
            {
                for(int i = 1; i <= nCount; i++)
                {
                    nPos = fFree();
                    fPlace(5, nPos);
                }
            }

            fUpdateDisplay();
            fFlip();
        }

        private int fFree()
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nPos, nType;

            do
            {
                nPos = rnd1.Next(1, 65);
                nType = fHoletype(msShuffle2, nPos);
                if (nType == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);

            return nPos;
        }
        private void fPlace(int nType, int nSquare)
        {
            String sTwo;

            sTwo = "0"+Convert.ToString(nType);
            msShuffle2 = msShuffle2.Substring(0, (nSquare*2) - 2) + sTwo + msShuffle2.Substring(nSquare*2, (64 - nSquare)*2);
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring((nSquare*2) - 2, 2));
            return nType;
        }

        private void fUpdateStatus()
        {
            switch (mnFlip)
            {
                case 1:
                    lblStatus.Text = "Status = GoingUp";
                    break;
                case 2:
                    lblStatus.Text = "Status = GoingDown";
                    break;
                default:
                    lblStatus.Text = "Status = LIGHTNING_ROD";
                    break;
            }

            lblPoints.Text = "Points = " + Convert.ToString(mnPoints);
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate=1;

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

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F pothole.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F computercompany.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F lightning1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F lightning2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F umbrellacompany.png"),
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void BtnStart3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void BtnStart4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void BtnStart5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void BtnStart6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void BtnStart7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void BtnStart8_Click(object sender, EventArgs e)
        {
            fClick(8);
        }

        private void BtnComply_Click(object sender, EventArgs e)
        {
            fCheck();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
