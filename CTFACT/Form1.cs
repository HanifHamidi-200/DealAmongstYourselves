using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTFACT
{
    public partial class Form1 : Form
    {
        private int mnMode = 1;
        private String msShuffle;
        private String msShuffle2;
        private String msShuffle3;
        private int nNumber;

        private void fReset(int nMode)
        {
            Random rnd1 = new Random();
            String sTwo=null;
            int nPos, nType;

            mnMode = nMode;
            if (mnMode == 1)
            {

            }

            msShuffle = "010203040506070809100102030405060708091001020304050607080910313233343536";
            msShuffle2 = null;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    nNumber = rnd1.Next(1, 4);
                    sTwo = "0" + Convert.ToString(nNumber);
                    msShuffle2 = msShuffle2 + sTwo;
                }
            }
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    nNumber = rnd1.Next(8, 11);
                    sTwo = Convert.ToString(nNumber);
                    if (sTwo.Length == 1)
                    {
                        sTwo = "0" + sTwo;
                    }
                    msShuffle3 = msShuffle3 + sTwo;
                }
            }
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            PictureBox _picA = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _picA);
            picA11.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _picA);
            picA12.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _picA);
            picA13.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _picA);
            picA14.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _picA);
            picA15.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _picA);
            picA16.Image = _picA.Image;
          
            //2
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _picA);
            picA21.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _picA);
            picA22.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _picA);
            picA23.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _picA);
            picA24.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _picA);
            picA25.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _picA);
            picA26.Image = _picA.Image;
          
            //3
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _picA);
            picA31.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _picA);
            picA32.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _picA);
            picA33.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _picA);
            picA34.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _picA);
            picA35.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _picA);
            picA36.Image = _picA.Image;
       
            //4
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _picA);
            picA41.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _picA);
            picA42.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _picA);
            picA43.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _picA);
            picA44.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _picA);
            picA45.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _picA);
            picA46.Image = _picA.Image;
       
            //5
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _picA);
            picA51.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _picA);
            picA52.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _picA);
            picA53.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _picA);
            picA54.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _picA);
            picA55.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _picA);
            picA56.Image = _picA.Image;
        
            //6
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _picA);
            picA61.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _picA);
            picA62.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _picA);
            picA63.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _picA);
            picA64.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _picA);
            picA65.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _picA);
            picA66.Image = _picA.Image;

            //B
            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _picA);
            picB11.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _picA);
            picB12.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _picA);
            picB13.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _picA);
            picB14.Image = _picA.Image;
       
            //2
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _picA);
            picB21.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _picA);
            picB22.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _picA);
            picB23.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _picA);
            picB24.Image = _picA.Image;
         
            //3
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _picA);
            picB31.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _picA);
            picB32.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _picA);
            picB33.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _picA);
            picB34.Image = _picA.Image;
          
            //4
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _picA);
            picB41.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _picA);
            picB42.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _picA);
            picB43.Image = _picA.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _picA);
            picB44.Image = _picA.Image;
            }
        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }
     
        private void fPlace(String sText, int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (36 - nPos) * 2);
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F land1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F land2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Allies1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Allies2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Allies3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F concentrationblock.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F oil.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F RussianCity.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F RussianLand.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F RussianOil.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    _pic2 = picture5;
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
            fReset(1);
        }

        private void BtnQNext1_Click(object sender, EventArgs e)
        {
            fReset(1);
        }

        private void BtnQNext2_Click(object sender, EventArgs e)
        {
            fReset(2);
        }
    }
}
