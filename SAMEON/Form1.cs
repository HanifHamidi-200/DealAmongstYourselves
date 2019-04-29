using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMEON
{
    public partial class Form1 : Form
    {
        private List<String> _poss = new List<String> { "BH", "H2O", "O2", "HCl", "H2SO4", "NaOH" };
        private String msShuffle1;
        private String msShuffle2;
        private String msRotate;
        private int mnHeader, mnRow;
        private int nNumber;
        private List<int> _row = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _rowposs1 = new List<int> { 0, 0, 0, 0, 0 ,0};
        private List<int> _rowposs2 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _rowposs3 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _rowposs4 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _rowposs5 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _col = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnMode;
        private int mnCopy1,mnCopy2;

        private void fCheck()
        {
            int nPos, nType,nRotate;
            String sText,sCode;
            int nHeader;

            for(int i = 1; i <= 5; i++)
            {
                _rowposs1[i - 1] = 0;
                _rowposs2[i - 1] = 0;
                _rowposs3[i - 1] = 0;
                _rowposs4[i - 1] = 0;
                _rowposs5[i - 1] = 0;
            }

            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    nHeader = _col[j - 1];
                    nPos = (i - 1) * 10 + j;
                    nType = fHoletype(msShuffle2, nPos);
                    nRotate = fHoletype(msRotate, nPos);
                    sText = Convert.ToString(nType) + Convert.ToString(nRotate);
                    switch (i)
                    {
                        case 1:
                            if (_rowposs1[nHeader - 1] == 0)
                            {
                                _rowposs1[nHeader - 1] = Convert.ToInt32(sText);
                            }
                            else
                            {
                                if (_rowposs1[nHeader - 1] == Convert.ToInt32(sText))
                                {

                                }
                                else
                                {
                                    sCode = Convert.ToString(i) + Convert.ToString(j);
                                    goto ErrLabel;
                                }
                            }
                            break;
                        case 2:
                            if (_rowposs2[nHeader - 1] == 0)
                            {
                                _rowposs2[nHeader - 1] = Convert.ToInt32(sText);
                            }
                            else
                            {
                                if (_rowposs2[nHeader - 1] == Convert.ToInt32(sText))
                                {

                                }
                                else
                                {
                                    sCode = Convert.ToString(i) + Convert.ToString(j);
                                    goto ErrLabel;
                                }
                            }
                            break;
                        case 3:
                            if (_rowposs3[nHeader - 1] == 0)
                            { 
                                _rowposs3[nHeader - 1] = Convert.ToInt32(sText);
                            }
                            else
                            {
                                if (_rowposs3[nHeader - 1] == Convert.ToInt32(sText))
                                {

                                }
                                else
                                {
                                    sCode = Convert.ToString(i) + Convert.ToString(j);
                                    goto ErrLabel;
                                }
                            }
                            break;
                        case 4:
                            if (_rowposs4[nHeader - 1] == 0)
                            {
                                _rowposs4[nHeader - 1] = Convert.ToInt32(sText);
                            }
                            else
                            {
                                if (_rowposs4[nHeader - 1] == Convert.ToInt32(sText))
                                {

                                }
                                else
                                {
                                    sCode = Convert.ToString(i) + Convert.ToString(j);
                                    goto ErrLabel;
                                }
                            }
                            break;
                        default:
                            if (_rowposs5[nHeader - 1] == 0)
                            {
                                _rowposs5[nHeader - 1] = Convert.ToInt32(sText);
                            }
                            else
                            {
                                if (_rowposs5[nHeader - 1] == Convert.ToInt32(sText))
                                {

                                }
                                else
                                {
                                    sCode = Convert.ToString(i) + Convert.ToString(j);
                                    goto ErrLabel;
                                }
                            }
                            break;
                    }

                }
            }

            fReset();
            return;

        ErrLabel:
            MessageBox.Show("Error" + sCode,"ErrorAccessing");
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nCount = rnd1.Next(4, 13);
        
            msShuffle1 = "0102030405060708091001020304050607080910010203040506070809100102030405060708091001020304050607080910";
            msShuffle2 = null;
            msRotate = null;
            mnMode = 1;

            for(int i = 1; i <= 5; i++)
            {
                _row[i - 1] = rnd1.Next(3, 7);
            }
            for (int i = 1; i <= 10; i++)
            {
                _col[i - 1] = rnd1.Next(1, 7);
            }

            for (int i = 1; i <= 50; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sTwo = "01";
                }
                else
                {
                    sTwo = "02";
                }
                msShuffle2 = msShuffle2 + sTwo;
                nNumber = rnd1.Next(1,5);
                sTwo = "0" + Convert.ToString(nNumber);
                msRotate = msRotate + sTwo;
            }

            fUpdateDisplay0();
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
            msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle2.Substring(nSquare * 2, (50 - nSquare) * 2);
        }
        private void fPlace2(int nType, int nSquare)
        {
            String sTwo;

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msRotate = msRotate.Substring(0, nSquare * 2 - 2) + sTwo + msRotate.Substring(nSquare * 2, (50 - nSquare) * 2);
        }
        private void fUpdateDisplay0()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;
         
            //1
            nType = _row[0];
            fPeek(nType, nRotate, ref _pic);
            picRow1.Image = _pic.Image;
            nType = _row[1];
            fPeek(nType, nRotate, ref _pic);
            picRow2.Image = _pic.Image;
            nType = _row[2];
            fPeek(nType, nRotate, ref _pic);
            picRow3.Image = _pic.Image;
            nType = _row[3];
            fPeek(nType, nRotate, ref _pic);
            picRow4.Image = _pic.Image;
            nType = _row[4];
            fPeek(nType, nRotate, ref _pic);
            picRow5.Image = _pic.Image;

            lbl1.Text = _poss[_col[0] - 1];
            lbl2.Text = _poss[_col[1] - 1];
            lbl3.Text = _poss[_col[2] - 1];
            lbl4.Text = _poss[_col[3] - 1];
            lbl5.Text = _poss[_col[4] - 1];
            lbl6.Text = _poss[_col[5] - 1];
            lbl7.Text = _poss[_col[6] - 1];
            lbl8.Text = _poss[_col[7] - 1];
            lbl9.Text = _poss[_col[8] - 1];
            lbla.Text = _poss[_col[9] - 1];

        }

        private void fUpdateIcon()
        {
            PictureBox _pic = new PictureBox();
            int nType=mnCopy1, nRotate = mnCopy2;

            fPeek(nType, nRotate, ref _pic);

            switch (mnRow)
            {
                case 1:
                    switch (mnHeader)
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
                        case 8:
                            pic18.Image = _pic.Image;
                            break;
                        case 9:
                            pic19.Image = _pic.Image;
                            break;
                        default:
                            pic1a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 2:
                    switch (mnHeader)
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
                        case 8:
                            pic28.Image = _pic.Image;
                            break;
                        case 9:
                            pic29.Image = _pic.Image;
                            break;
                        default:
                            pic2a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 3:
                    switch (mnHeader)
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
                        case 8:
                            pic38.Image = _pic.Image;
                            break;
                        case 9:
                            pic39.Image = _pic.Image;
                            break;
                        default:
                            pic3a.Image = _pic.Image;
                            break;
                    }
                    break;
                case 4:
                    switch (mnHeader)
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
                        case 8:
                            pic48.Image = _pic.Image;
                            break;
                        case 9:
                            pic49.Image = _pic.Image;
                            break;
                        default:
                            pic4a.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
                    switch (mnHeader)
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
                        case 8:
                            pic58.Image = _pic.Image;
                            break;
                        case 9:
                            pic59.Image = _pic.Image;
                            break;
                        default:
                            pic5a.Image = _pic.Image;
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
            nRotate = fHoletype(msRotate, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            nRotate = fHoletype(msRotate, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            nRotate = fHoletype(msRotate, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            nRotate = fHoletype(msRotate, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 5);
            nRotate = fHoletype(msRotate, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            nRotate = fHoletype(msRotate, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            nRotate = fHoletype(msRotate, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            nRotate = fHoletype(msRotate, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 9);
            nRotate = fHoletype(msRotate, 9);
            fPeek(nType, nRotate, ref _pic);
            pic19.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            nRotate = fHoletype(msRotate, 10);
            fPeek(nType, nRotate, ref _pic);
            pic1a.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 11);
            nRotate = fHoletype(msRotate, 11);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            nRotate = fHoletype(msRotate, 12);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            nRotate = fHoletype(msRotate, 13);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            nRotate = fHoletype(msRotate, 14);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            nRotate = fHoletype(msRotate, 15);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            nRotate = fHoletype(msRotate, 16);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 17);
            nRotate = fHoletype(msRotate, 17);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            nRotate = fHoletype(msRotate, 18);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            nRotate = fHoletype(msRotate, 19);
            fPeek(nType, nRotate, ref _pic);
            pic29.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            nRotate = fHoletype(msRotate, 20);
            fPeek(nType, nRotate, ref _pic);
            pic2a.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 21);
            nRotate = fHoletype(msRotate, 21);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            nRotate = fHoletype(msRotate, 22);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            nRotate = fHoletype(msRotate, 23);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            nRotate = fHoletype(msRotate, 24);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 25);
            nRotate = fHoletype(msRotate, 25);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            nRotate = fHoletype(msRotate, 26);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            nRotate = fHoletype(msRotate, 27);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            nRotate = fHoletype(msRotate, 28);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            nRotate = fHoletype(msRotate, 29);
            fPeek(nType, nRotate, ref _pic);
            pic39.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            nRotate = fHoletype(msRotate, 30);
            fPeek(nType, nRotate, ref _pic);
            pic3a.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 31);
            nRotate = fHoletype(msRotate, 31);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            nRotate = fHoletype(msRotate, 32);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 33);
            nRotate = fHoletype(msRotate, 33);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            nRotate = fHoletype(msRotate, 34);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            nRotate = fHoletype(msRotate, 35);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            nRotate = fHoletype(msRotate, 36);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            nRotate = fHoletype(msRotate, 37);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            nRotate = fHoletype(msRotate, 38);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            nRotate = fHoletype(msRotate, 39);
            fPeek(nType, nRotate, ref _pic);
            pic49.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            nRotate = fHoletype(msRotate, 40);
            fPeek(nType, nRotate, ref _pic);
            pic4a.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 41);
            nRotate = fHoletype(msRotate, 41);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 42);
            nRotate = fHoletype(msRotate, 42);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 43);
            nRotate = fHoletype(msRotate, 43);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 44);
            nRotate = fHoletype(msRotate, 44);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 45);
            nRotate = fHoletype(msRotate, 45);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 46);
            nRotate = fHoletype(msRotate, 46);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 47);
            nRotate = fHoletype(msRotate, 47);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 48);
            nRotate = fHoletype(msRotate, 48);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 49);
            nRotate = fHoletype(msRotate, 49);
            fPeek(nType, nRotate, ref _pic);
            pic59.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 50);
            nRotate = fHoletype(msRotate, 50);
            fPeek(nType, nRotate, ref _pic);
            pic5a.Image = _pic.Image;

        }

        private void fUpdateStatus()
        {
            String sText = "Selected = (" + Convert.ToString(mnRow) + "," + Convert.ToString(mnHeader) + ")";

            fra1.Text = sText;
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
                Image = Image.FromFile(@"F arrow1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F arrow2.png"),
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
                    _pic2 = picture3;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fClick(int nCol, int nRow)
        {
            int nPos, nType,nRotate;

            if (mnRow == 0)
            {
                return;
            }
            if (mnHeader == 0)
            {
                return;
            }
            if (mnMode == 2)
            {
                nPos = (mnRow - 1) * 10 + mnHeader;
                nType = fHoletype(msShuffle2, nPos);
                nRotate = fHoletype(msRotate, nPos);
                mnCopy1 = nType;
                mnCopy2 = nRotate;
                mnMode = 1;
            }
            else
            {
                nPos = (mnRow - 1) * 10 + mnHeader;
                fPlace(mnCopy1, nPos);
                fPlace2(mnCopy2, nPos);
                fUpdateIcon();
                mnMode = 1;
            }
        }

        private void fSelectRow(int nMode)
        {   
            mnRow = nMode;

            fUpdateStatus();

            if (mnMode!= 1)
            {
                fClick(mnRow,mnHeader);
            }
        }
        private void fSelectHeader(int nMode)
        {
            mnHeader = nMode;

            fUpdateStatus();

            if (mnMode != 1)
            {
                fClick(mnRow, mnHeader);
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

        private void PicRow1_Click(object sender, EventArgs e)
        {
            fSelectRow(1);
        }

        private void PicRow2_Click(object sender, EventArgs e)
        {
            fSelectRow(2);
        }

        private void PicRow3_Click(object sender, EventArgs e)
        {
            fSelectRow(3);
        }

        private void PicRow4_Click(object sender, EventArgs e)
        {
            fSelectRow(4);
        }

        private void PicRow5_Click(object sender, EventArgs e)
        { 
            fSelectRow(5);
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
            fSelectHeader(1);
        }

        private void Lbl2_Click(object sender, EventArgs e)
        {
            fSelectHeader(2);
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {
            fSelectHeader(3);
        }

        private void Lbl4_Click(object sender, EventArgs e)
        {
            fSelectHeader(4);
        }

        private void Lbl5_Click(object sender, EventArgs e)
        {
            fSelectHeader(5);
        }

        private void Lbl6_Click(object sender, EventArgs e)
        {
            fSelectHeader(6);
        }

        private void Lbl7_Click(object sender, EventArgs e)
        {
            fSelectHeader(7);
        }

        private void Lbl8_Click(object sender, EventArgs e)
        {
            fSelectHeader(8);
        }

        private void Lbl9_Click(object sender, EventArgs e)
        {
            fSelectHeader(9);
        }

        private void Lbla_Click(object sender, EventArgs e)
        {
            fSelectHeader(10);
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fClick(mnRow, mnHeader);
        }

        private void BtnComply_Click(object sender, EventArgs e)
        {
            fCheck();
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fClick(mnRow, mnHeader);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
