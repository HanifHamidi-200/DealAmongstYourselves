using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLUMG
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private String msRotate1;
        private String msRotate2;
        private int mnOutTile,mnOutPos,mnOutNumber,mnOutRotate;
        private List<int> _in = new List<int> { 0, 0, 0, 0 };
        private List<int> _out = new List<int> { 0, 0, 0, 0 };
        private int mnDone, mnDoneTotal;
        private int mnPoints;

        private int fTotal()
        {
            int nTotal = 0;

            for(int i = 1; i <= 4; i++)
            {
                nTotal += _in[i - 1];
            }

            return nTotal;
        }
        private void fSnapshot()
        {
            mnPoints += fTotal();
            fUpdateDisplay();
        }
        private void fClick(int nMode)
        {
            fPlace(mnOutTile, nMode);
            fPlace2(mnOutRotate, nMode);
            fFlip();

            mnDone++;

            fUpdateDisplay();

            if (mnDone == mnDoneTotal)
            {
                MessageBox.Show("You win", "GWin");
                fReset();
            }
        }

        private void fFlip()
        {
            Random rnd1 = new Random();

            mnOutTile = rnd1.Next(1, 5);
            mnOutPos = rnd1.Next(1, 5);
            mnOutNumber = rnd1.Next(1, 21);
            mnOutRotate = rnd1.Next(1, 5);
            fCheckin();

        }

        private void fReset()
        {
            Random rnd1=new Random();
            int nType;
            String sTwo;

            msShuffle1 = null;
            msShuffle2 = null;
            mnDone = 0;
            mnDoneTotal = rnd1.Next(4, 21);

            for(int i = 1; i <= 4; i++)
            {
                nType = rnd1.Next(1, 5);
                sTwo = Convert.ToString(nType);
                msShuffle1 = msShuffle1 + sTwo;
                nType = rnd1.Next(1, 5);
                sTwo = Convert.ToString(nType);
                msRotate1 = msRotate1 + sTwo;
                _in[i - 1] = rnd1.Next(1, 21);
            }

            mnOutTile = rnd1.Next(1, 5);
            mnOutPos = rnd1.Next(1, 5);
            mnOutNumber = rnd1.Next(1, 21);
            mnOutRotate = rnd1.Next(1, 5);
            fCheckin();

            fUpdateDisplay();
        }

        private void fCheckin()
        {
            String sTwo = Convert.ToString(mnOutTile);

            msShuffle2 = "5555";
            msShuffle2 = msShuffle2.Substring(0, mnOutPos - 1) + sTwo + msShuffle2.Substring(mnOutPos, 4 - mnOutPos);

            for(int i = 1; i <= 4; i++)
            {
                if (i == mnOutPos)
                {
                    _out[i - 1] = mnOutNumber;
                }
                else
                {
                    _out[i - 1] = 0;
                }
            }
        }

        private void fUpdateStatus()
        {
            lblDone.Text = "Done = " + Convert.ToString(mnDone) + "/" + Convert.ToString(mnDoneTotal);
            lblPoints.Text = "PointsCollected = " + Convert.ToString(mnPoints);
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            nType = fHoletype(msShuffle1, 1);
            nRotate = fHoletype(msRotate1, 1);
            fPeek(nType, nRotate, ref _pic);
            picIn1.Image = _pic.Image;
            nType = fHoletype(msShuffle1, 2);
            nRotate = fHoletype(msRotate1, 2);
            fPeek(nType, nRotate, ref _pic);
            picIn2.Image = _pic.Image;
            nType = fHoletype(msShuffle1, 3);
            nRotate = fHoletype(msRotate1, 3);
            fPeek(nType, nRotate, ref _pic);
            picIn3.Image = _pic.Image;
            nType = fHoletype(msShuffle1, 4);
            nRotate = fHoletype(msRotate1, 4);
            fPeek(nType, nRotate, ref _pic);
            picIn4.Image = _pic.Image;

            nType = 5;
            nRotate = 1;
            fPeek(nType, nRotate, ref _pic);
            picOut1.Image = _pic.Image;
            picOut2.Image = _pic.Image;
            picOut3.Image = _pic.Image;
            picOut4.Image = _pic.Image;

            nType = mnOutTile;
            nRotate = mnOutRotate;
            fPeek(nType, nRotate, ref _pic);
            switch (mnOutPos)
            {
                case 1:
                    picOut1.Image = _pic.Image;
                    break;
                case 2:
                    picOut2.Image = _pic.Image;
                    break;
                case 3:
                    picOut3.Image = _pic.Image;
                    break;
                default:
                    picOut4.Image = _pic.Image;
                    break;
            }

            lblIn1.Text = Convert.ToString(_in[0]);
            lblIn2.Text = Convert.ToString(_in[1]);
            lblIn3.Text = Convert.ToString(_in[2]);
            lblIn4.Text = Convert.ToString(_in[3]);

            lblOut1.Text = Convert.ToString(_out[0]);
            lblOut2.Text = Convert.ToString(_out[1]);
            lblOut3.Text = Convert.ToString(_out[2]);
            lblOut4.Text = Convert.ToString(_out[3]);

            fUpdateStatus();
        }

        private void fPlace(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            msShuffle1 = msShuffle1.Substring(0, nSquare  - 1) + sTwo + msShuffle1.Substring(nSquare , (4 - nSquare));
        }
        private void fPlace2(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            msRotate1 = msRotate1.Substring(0, nSquare - 1) + sTwo + msRotate1.Substring(nSquare, (4 - nSquare));
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare  - 1, 1));
            return nType;
        }

        private void PicIn1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void PicIn2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void PicIn3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void PicIn4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void BtnSnapshot_Click(object sender, EventArgs e)
        {
            fSnapshot();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
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
            mnPoints = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
