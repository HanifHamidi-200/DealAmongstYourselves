using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBUOY
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msShuffle3;
        private int mnBar, mnRow;
        private String msResume,msSofar;
        private bool mbWin;

        private void fClickBar(int nMode)
        {
            Random rnd1 = new Random();
            int nRow=0,nCol=0, nPos=0;
            int nType,nType2=0;
            int nLength, nPrick;

            msShuffle3 = msShuffle2;
            msSofar = null;
            msResume = null;
            mbWin = false;

            for(int i = 1; i <= 8; i++)
            {
                if (i == 1)
                {
                    nCol = nMode;
                    nPos = (nCol - 1) * 8 + i;
                    fHighlight(nPos);
                    nType = fHoletype(msShuffle2, nPos);
                    nType2 = nType;
                }
                else
                {
                     switch (nType2)
                    {
                        case 1:
                            break;
                        case 2:
                            nCol++;
                            if (nCol == 9)
                            {
                                nCol = 1;
                            }
                            break;
                        case 3:
                            nCol--;
                            if (nCol == 0)
                            {
                                nCol = 8;
                            }
                            break;
                        default:
                            msResume = msResume + Convert.ToString(i-1);
                            nCol++;
                            if (nCol == 9)
                            {
                                nCol = 1;
                            }
                            break;
                     }
                    nPos = (nCol - 1) * 8 + i;
                    nType = fHoletype(msShuffle2, nPos);
                    fHighlight(nPos);
                    nType2 = nType;
                    }
                msSofar = msSofar + Convert.ToString(nCol);
            }
            if (nType2 == 4)
            {
                msResume = msResume + Convert.ToString(8);
            }
            else
            {
                if (nType2 > 8)
                {
                    mbWin = true;
                }
            }

            lbl1.Text = "msResume";
            lbl2.Text = "msSofar";
            lbl3.Text = "mnRow";

            if (msResume != null)
            {
                nLength = msResume.Length;
                nPos = rnd1.Next(1, nLength + 1);
                nPrick = Convert.ToInt32(msResume.Substring(nPos - 1, 1));
                nRow = nPrick+1;
                fUpdateStatus(msResume, msSofar, nRow-1);
                nCol = Convert.ToInt32(msSofar.Substring(nLength - 1, 1));
                msResume = msResume.Substring(0, nLength - 1);
                msSofar = msSofar.Substring(0, nRow - 1);
                if (nCol!= 8)
                {
                    for (int i = nRow; i <= 8; i++)
                    {
                    if (i == nRow)
                    {
                        nPos = (nCol - 1) * 8 + i;
                        fHighlight(nPos);
                        nType = fHoletype(msShuffle2, nPos);
                        nType2 = nType;
                    }
                    else
                    {
                        switch (nType2)
                        {
                            case 1:
                                break;
                            case 2:
                                nCol++;
                                if (nCol == 9)
                                {
                                    nCol = 1;
                                }
                                break;
                            case 3:
                                nCol--;
                                if (nCol == 0)
                                {
                                    nCol = 8;
                                }
                                break;
                            default:
                                msResume = msResume + Convert.ToString(i-1);
                                nCol++;
                                if (nCol == 9)
                                {
                                    nCol = 1;
                                }
                                break;
                        }
                        nPos = (nCol - 1) * 8 + i;
                        nType = fHoletype(msShuffle2, nPos);
                        fHighlight(nPos);
                        nType2 = nType;
                    }
                    msSofar = msSofar + Convert.ToString(nCol);
                    }
                }
            }

            if (nType2 == 4)
            {
                msResume = msResume + Convert.ToString(8);
            }
            else
            {
                if (nType2 > 8)
                {
                    mbWin = true;
                }
            }

            fUpdateDisplay();
        }

        private void fHighlight(int nPos)
        {
            int nType;

            nType = fHoletype(msShuffle2, nPos);
            if (nType <= 4)
            {
                nType += 4;
                fPlace2(nType, nPos);

            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nCol=rnd1.Next(1,9),nPos=(nCol-1)*8+8,nType;

            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304";
            msShuffle2 = null;
            msShuffle3 = null;

            for (int i = 1; i <= 64; i++)
            {
                nType = rnd1.Next(1, 5);
                sTwo = "0" + Convert.ToString(nType);
                msShuffle2 = msShuffle2 + sTwo;
                msShuffle3 = msShuffle3 + sTwo;
            }

            nType = fHoletype(msShuffle2, nPos);
            nType += 8;
            fPlace(nType, nPos);
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
            msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle2.Substring(nSquare * 2, (64 - nSquare) * 2);
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

        private void fUpdateStatus(String s1,String s2,int n3)
        {
            lbl1.Text = "msResume = " + s1;
            lbl2.Text = "msSofar = " + s2;
            lbl3.Text = "mnRow = " + Convert.ToString(n3);

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
                Image = Image.FromFile(@"F pipe1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pipe2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pipe3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pipe4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F highlighted1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F highlighted2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F highlighted3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F highlighted4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F target1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F target2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F target3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F target4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
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
                case 12:
                    _pic2 = picture12;
                    break;
                default:
                    _pic2 = picture13;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fClick(int nCol, int nRow)
        {
            MessageBox.Show("You win", "GWin");
            fReset();
        }

        private void fSelectRow(int nMode)
        {
            int nType, nPos;

            mnRow = nMode;

            nPos = (mnBar - 1) * 8 + mnRow;
            nType = fHoletype(msShuffle2, nPos);

            if (nType == 2)
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

            fClickBar(mnBar);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnBar = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);

             fReset();
            fSelectBar(mnBar);
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

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnComply_Click(object sender, EventArgs e)
        {
            if (mbWin)
            {
                fReset();
            }
        }


    }
}
