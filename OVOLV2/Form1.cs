using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVOLV2
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msShuffle3;
        private int mnBar, mnRow;
        private int mnMode;
        private List<String> _mode = new List<String> { "2Electronics1", "2TechAI1", "3Infront1", "Eachworld1", "FutureShop1" };
        private List<int> _weightings = new List<int> { 1, 2, 3, 4 };
        private List<int> _addsto = new List<int> { 0, 0, 0, 0 };

        private int fMod(int nLarge,int nSmall)
        {
            bool bFound = false;

            do
            {
                if (nLarge < nSmall)
                {
                    bFound = true;
                    return nLarge;
                }
                nLarge -= nSmall;
            } while (bFound == false);
            return 0;
        }

        private bool fEven(int nLarge)
        {
            bool bFound = false;

            do
            {
                if (nLarge ==0)
                {
                    bFound = true;
                    return true;
                }
                else
                {
                    if (nLarge == 1)
                    {
                        bFound = true;
                        return false;
                    }
                }
                nLarge -= 2;
            } while (bFound == false);
            return true;
        }

        private void fUpdateAddsto(ref Label lbl1,ref Label lbl2,String sText1,String sText2)
        {
            lbl1.Text = sText1;
            lbl2.Text = sText2;
        }

        private void fAddsto()
        {
            int nPos, nType;
            int nAddsto = 0;
            bool bEven = false;
            String sText1, sText2;

            for(int i = 1; i <= 4; i++)
            {
                nAddsto = 0;
                for(int j = 1; j <= 4; j++)
                {
                    nPos = (j - 1) * 4 + i;
                    nType = fHoletype(msShuffle2, nPos)-3;
                    nType = fMod(nType, 4);
                    if (nType == 0)
                    {
                        nType = 4;
                    }
                    nAddsto += _weightings[nType - 1];
                }
                sText1 = "addsto" + Convert.ToString(nAddsto);
                bEven = fEven(nAddsto);
                if (bEven)
                {
                    sText2 = "EVEN";
                }
                else
                {
                   sText2 = "ODD";
                }
                switch (i)
                {
                    case 1:
                        fUpdateAddsto(ref lblAddsto1, ref lblEven1, sText1, sText2);
                        break;
                    case 2:
                        fUpdateAddsto(ref lblAddsto2, ref lblEven2, sText1, sText2);
                        break;
                    case 3:
                        fUpdateAddsto(ref lblAddsto3, ref lblEven3, sText1, sText2);
                        break;
                    default:
                        fUpdateAddsto(ref lblAddsto4, ref lblEven4, sText1, sText2);
                        break;
                }
            }
        }
        private void fClick(int nCol, int nRow)
        {
            int nType, nPos = (nCol - 1) * 4 + nRow;

            nType = fHoletype(msShuffle3, nPos);
            if (nType == 1)
            {
                fPlace(3, nPos);
            }
            else
            {
                fPlace(1, nPos);
            }

            fUpdateIcon();
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nItem,nMode,nPos;
            int nCol = 0, nRow = 0;
            int nCount = rnd1.Next(2, 7);

            msShuffle1 = "01020304050607080910010203040506";
            msShuffle2 = null;
            msShuffle3 = null;
            mnMode = rnd1.Next(1, 6);
            nMode = (mnMode - 1) * 4 + 3;

            for (int i = 1; i <= 16; i++)
            {
                nItem = rnd1.Next(1, 5);
                nItem = nMode + nItem;
                sTwo = Convert.ToString(nItem);
                if (sTwo.Length == 1)
                {
                    sTwo = "0" + sTwo;
                }
                msShuffle2 = msShuffle2 + sTwo;
                sTwo = "01";
                msShuffle3 = msShuffle3 + sTwo;
            }

            for(int i = 1; i <= nCount; i++)
            {
                fFree(ref nCol, ref nRow);
                nPos = (nCol - 1) * 4 + nRow;
                fPlace(2, nPos);
            }

            fAddsto();
            fUpdateDisplay();
            fUpdateStatus();
        }

        private void fPlace(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msShuffle3 = msShuffle3.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle3.Substring(nSquare * 2, (16 - nSquare) * 2);
        }

        private void fFree(ref int nCol, ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nType, nPos;

            do
            {
                nCol = rnd1.Next(1, 5);
                nRow = rnd1.Next(1, 5);
                nPos = (nCol - 1) * 4 + nRow;
                nType = fHoletype(msShuffle3, nPos);
                if (nType == 1)
                {
                    bFound = true;
                }
            } while (bFound == false);
        }


        private void fUpdateStatus()
        {
            String sText = _mode[mnMode - 1];

            lblMode.Text = "Mode = "+sText;
        }

        private void fUpdateIcon()
        {
            PictureBox _pic = new PictureBox();
            int nType = 3, nRotate = 1;

            fPeek(nType, nRotate, ref _pic);

            switch (mnBar)
            {
                case 1:
                    switch (mnRow)
                    {
                        case 1:
                            picB11.Image = _pic.Image;
                            break;
                        case 2:
                            picB12.Image = _pic.Image;
                            break;
                        case 3:
                            picB13.Image = _pic.Image;
                            break;
                        default:
                            picB14.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (mnRow)
                    {
                        case 1:
                            picB21.Image = _pic.Image;
                            break;
                        case 2:
                            picB22.Image = _pic.Image;
                            break;
                        case 3:
                            picB23.Image = _pic.Image;
                            break;
                        default:
                            picB24.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (mnRow)
                    {
                        case 1:
                            picB31.Image = _pic.Image;
                            break;
                        case 2:
                            picB32.Image = _pic.Image;
                            break;
                        case 3:
                            picB33.Image = _pic.Image;
                            break;
                        default:
                            picB34.Image = _pic.Image;
                            break;
                             }
                    break;
                default:
                    switch (mnRow)
                    {
                        case 1:
                            picB41.Image = _pic.Image;
                            break;
                        case 2:
                            picB42.Image = _pic.Image;
                            break;
                        case 3:
                            picB43.Image = _pic.Image;
                            break;
                        default:
                            picB44.Image = _pic.Image;
                            break;
                    }
                    break;
            }
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //SQUARE_A
            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            picA11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            picA12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            picA13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            picA14.Image = _pic.Image;
          
            //2
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            picA21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            picA22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            picA23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            picA24.Image = _pic.Image;
         
            //3
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            picA31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            picA32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            picA33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            picA34.Image = _pic.Image;
         
            //4
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            picA41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            picA42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            picA43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            picA44.Image = _pic.Image;

            //SQUARE_B
            //1
            nType = fHoletype(msShuffle3, 1);
            fPeek(nType, nRotate, ref _pic);
            picB11.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 2);
            fPeek(nType, nRotate, ref _pic);
            picB12.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 3);
            fPeek(nType, nRotate, ref _pic);
            picB13.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 4);
            fPeek(nType, nRotate, ref _pic);
            picB14.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle3, 5);
            fPeek(nType, nRotate, ref _pic);
            picB21.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 6);
            fPeek(nType, nRotate, ref _pic);
            picB22.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 7);
            fPeek(nType, nRotate, ref _pic);
            picB23.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 8);
            fPeek(nType, nRotate, ref _pic);
            picB24.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle3, 9);
            fPeek(nType, nRotate, ref _pic);
            picB31.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 10);
            fPeek(nType, nRotate, ref _pic);
            picB32.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 11);
            fPeek(nType, nRotate, ref _pic);
            picB33.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 12);
            fPeek(nType, nRotate, ref _pic);
            picB34.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle3, 13);
            fPeek(nType, nRotate, ref _pic);
            picB41.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 14);
            fPeek(nType, nRotate, ref _pic);
            picB42.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 15);
            fPeek(nType, nRotate, ref _pic);
            picB43.Image = _pic.Image;
            nType = fHoletype(msShuffle3, 16);
            fPeek(nType, nRotate, ref _pic);
            picB44.Image = _pic.Image;

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
                Image = Image.FromFile(@"F result_blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F result_CratesManagement.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F result_switch.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F 2Electronics1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F 2Electronics2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F 2Electronics3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F 2Electronics4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F 2TechAI1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F 2TechAI2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F 2TechAI3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F 2TechAI4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F 3Infront1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F 3Infront2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F 3Infront3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F 3Infront4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F Eachworld1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F Eachworld2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F Eachworld3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F Eachworld4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F FutureShop1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F FutureShop2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F FutureShop3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F FutureShop4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
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
                default:
                    _pic2 = picture24;
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

            nPos = (mnBar - 1) * 4 + mnRow;
            nType = fHoletype(msShuffle3, nPos);

            if (nType != 2)
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
                default:
                    btnBar4.BackColor = Color.Red;
                    break;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnBar = rnd1.Next(1, 5);
            mnRow = rnd1.Next(1, 5);

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

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void Pic14_Click(object sender, EventArgs e)
        {
            fSelectRow(4);
        }

    }
}
