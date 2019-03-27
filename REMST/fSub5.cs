using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMST
{
    public partial class fSub5 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int mnBar, mnRow;
        private int nNumber;
        private int mnYOUCol, mnYOURow;
        private List<int> _save = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        private void fClick(int nCol, int nRow)
        {

        }


        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "04";
            int nCount = rnd1.Next(4, 11);
            int nCol = 0, nRow = 0;
            int nPos,nType;

            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304";
            msShuffle2 = null;

            for (int i = 1; i <= 64; i++)
            {
                nNumber = rnd1.Next(1, 10);
                switch (nNumber)
                {
                    case 1:
                        sTwo = "04";
                        break;
                    case 2:
                        sTwo = "04";
                        break;
                    case 3:
                        sTwo = "04";
                        break;
                    case 4:
                        sTwo = "22";
                        break;
                    case 5:
                        sTwo = "22";
                        break;
                    case 6:
                        sTwo = "22";
                        break;
                    default:
                        sTwo = "23";
                        break;
                }
                msShuffle2 = msShuffle2 + sTwo;
            }

            for (int i = 1; i <= 4; i++)
            {
                nRow = rnd1.Next(1, 9);
                for (int j = 1; j <= 8; j++)
                {
                    nCol = j;
                    nPos = (nCol - 1) * 8 + nRow;
                    nType = fHoletype(msShuffle2, nPos);
                    _save[j - 1] = nType;
                }
                nRow = rnd1.Next(1, 9);
                for (int j = 1; j <= 8; j++)
                {
                    nCol = j;
                    nPos = (nCol - 1) * 8 + nRow;
                    nType = _save[j - 1];
                    fPlace(nType, nPos);
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                nCol = rnd1.Next(1, 9);
                for (int j = 1; j <= 8; j++)
                {
                    nRow = j;
                    nPos = (nCol - 1) * 8 + nRow;
                    nType = fHoletype(msShuffle2, nPos);
                    _save[j - 1] = nType;
                }
                nCol = rnd1.Next(1, 9);
                for (int j = 1; j <= 8; j++)
                {
                    nRow = j;
                    nPos = (nCol - 1) * 8 + nRow;
                    nType = _save[j - 1];
                    fPlace(nType, nPos);
                }
            }

            fFree(ref nCol, ref nRow);
            mnYOUCol = nCol;
            mnYOURow = nRow;

            fUpdateDisplay();
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
                if (nType <= 6)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
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

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back_brown.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back_grey.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F back_pink.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F back_purple.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F back_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F back_yellow.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F balloon.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F bomb.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F ControlBox.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F eyes.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F gun.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F ignored.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F lake.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F mine.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F places_A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F places_B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F places_C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F places_D.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F recharging.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F shoot1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F shoot2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F sliders_blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F sliders_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F volcanoes_o.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F volcanoes_x.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
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
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                case 16:
                    _pic2 = picture16;
                    break;
                case 17:
                    _pic2 = picture17;
                    break;
                case 18:
                    _pic2 = picture18;
                    break;
                case 19:
                    _pic2 = picture19;
                    break;
                case 20:
                    _pic2 = picture20;
                    break;
                case 21:
                    _pic2 = picture21;
                    break;
                case 22:
                    _pic2 = picture22;
                    break;
                case 23:
                    _pic2 = picture23;
                    break;
                case 24:
                    _pic2 = picture24;
                    break;
                case 25:
                    _pic2 = picture25;
                    break;
                case 26:
                    _pic2 = picture26;
                    break;
                default:
                    _pic2 = picture27;
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

            nPos = (mnBar - 1) * 8 + mnRow;
            nType = fHoletype(msShuffle2, nPos);

            fClick(mnBar, mnRow);
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

        public fSub5()
        {
            InitializeComponent();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void FSub5_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
