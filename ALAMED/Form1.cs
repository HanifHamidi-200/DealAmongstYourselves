using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALAMED
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msUnderneath;
        private int mnBar, mnRow;
        private bool mbChain = false;
        private String msFound;
        private int mnJustfound;

        private void fElectrify(int nMode)
        {
            int nType;

            for(int i = 1; i <= 64; i++)
            {
                nType = fHoletype(msShuffle2, i);
                if (nType == nMode)
                {
                    fPlace(nMode, i);
                }
            }
            fUpdateDisplay();
        }

        private void fAdd()
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(1,5);
            int nCol = 0, nRow = 0;
            int nPos, nColour;

            for (int i = 1; i <= nCount; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                nColour = rnd1.Next(3, 7);
                fPlace2(nColour, nPos);
            }

            fUpdateDisplay();

        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nCount = rnd1.Next(8, 21);
            int nCol=0, nRow=0;
            int nPos,nColour;

            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910010203040506070809100102030405060708091001020304";
            msShuffle2 = null;
            msUnderneath = null;
            mbChain = false;
            msFound = "NNNNNN";
            mnJustfound = 0;

            for(int i = 1; i <= 64; i++)
            {
                msShuffle2 = msShuffle2 + sTwo;
                msUnderneath = msUnderneath + sTwo;
            }

            for(int i = 1; i <= nCount; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                nColour = rnd1.Next(3, 7);
                fPlace2(nColour, nPos);
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
            msUnderneath = msUnderneath.Substring(0, nSquare * 2 - 2) + sTwo + msUnderneath.Substring(nSquare * 2, (64 - nSquare) * 2);
        }
        private void fPlace3(String sType, int nSquare)
        {
            msFound = msFound.Substring(0, nSquare  - 1) + sType + msFound.Substring(nSquare , 6 - nSquare);
        }

        private void fFree(ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType,nPos;

            do
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msUnderneath, nPos);
                if (nType == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }

        private void fUpdateStatus()
        {
            String sText = msFound.Substring(2, 4);

            lblFound.Text = "Found = " + sText;
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

            fUpdateStatus();
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
                Image = Image.FromFile(@"F back.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blankfound.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F col1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F col2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F col3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F col4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
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
                default:
                    _pic2 = picture7;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private bool fPresent(int nMode)
        {
            String sLetter = msFound.Substring(nMode - 1, 1);

            if (sLetter == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void fClick(int nCol,int nRow)
        {
            Random rnd1 = new Random();
            int nType, nPos;
            int nCount = rnd1.Next(4, 11);
            int nColour;

            nPos = (mnBar - 1) * 8 + mnRow;
            nType = fHoletype(msUnderneath , nPos);
            if (nType == 1)
            {
                nType = 2;
                mnJustfound = 0;
            }
            else
            {
                if (fPresent(nType))
                {
                    fPlace3("Y", nType);
                    fPlace(nType, nPos);
                    fUpdateDisplay();
                    MessageBox.Show("You win","GWin");;
                    fReset();
                    goto endline;
                }
                else
                {
                    fPlace3("Y", nType);
                    mnJustfound = nType;
                }
            }
            fPlace(nType, nPos);
       
            for (int i = 1; i <= nCount; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 8 + nRow;
                nColour = rnd1.Next(3, 7);
                fPlace2(nColour, nPos);
            }

            fUpdateDisplay();

        endline:;
        }

        private void fSelectRow(int nMode)
        {
            int nType, nPos;

            mnRow = nMode;

            nPos = (mnBar - 1) * 8 + mnRow;
            nType = fHoletype(msShuffle2,nPos);

            if (mbChain)
            {

            }
            else
            {
                if (nType == 1)
                {
                    fClick(mnBar, mnRow);
                    fAdd();
                }
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
        }
        public Form1()
        {
            InitializeComponent();
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

        private void BtnElectrify_Click(object sender, EventArgs e)
        {
            if (mnJustfound != 0)
            {
                fElectrify(mnJustfound);
            }
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnBar = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);

            fSelectBar(mnBar);
            fReset();
        }
    }
}
