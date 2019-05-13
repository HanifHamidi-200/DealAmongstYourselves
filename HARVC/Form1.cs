using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARVC
{
    public partial class Form1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int mnBar, mnRow;
        private int nNumber;
        private List<int> _selected = new List<int> { 0, 0, 0, 0 };
        private List<String> _title = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _text = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _A = new List<String> { "Acknowledge", "Advents", "Adventure", "Advocate", "AI", "Annhilation", "Asincere", "Assembling", "Aware" };
        private List<String> _B = new List<String> { "BasinControl", "Borderline", "Borderrack", "Borehole" };
        private List<String> _C = new List<String> { "CaravanOutput", "Catalyst", "CrossoverBox", "CulmintionControl" };
        private List<String> _D = new List<String> { "DocksReforming"};
        private List<int> _count = new List<int> { 9, 4, 4, 1 };
        private int mnItem1, mnItem2;
        private void fSave(int nPos)
        {
            _text[nPos - 1] = txtText.Text;
        }

        private void fGo1(String sText)
        {
            txtText.Text = txtText.Text + sText;
        }

        private void fListFill()
        {
            Random rnd1 = new Random();
            int nPos,nCount = rnd1.Next(4, 21);
            int nValue, nRemove = 0;
            String sText;

            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }

            for(int i = 1; i <= nCount; i++)
            {
                nValue = rnd1.Next(1, 201);
                lst2.Items.Add(Convert.ToString(nValue));
            }

            lst2.Sorted = true;
            lst2.Sorted = false;

            for(int i = 1; i <= nCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    lst2.SelectedIndex = i - 1;
                    sText = lst2.Text;
                    sText = "(-" + sText + ")";
                     lst2.Items.Add(sText);
                    nRemove++;
                }
            }

            for(int i = 1; i <= nRemove; i++)
            {
                nCount = lst2.Items.Count;
                nPos = rnd1.Next(1, nCount + 1);
                lst2.Items.RemoveAt(nPos - 1);
            }

            lst2.Sorted = true;
            lst2.Sorted = false;
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo = "01";
            int nPos,nType;
            int nCount;

            msShuffle1 = "01020304050607080910010203040506070809100102030405060708091001020304050607080910";
            msShuffle2 = null;
            mnItem1 = 0;
            mnItem2 = 0;

            for (int i = 1; i <= 40; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sTwo = "01";
                }
                else
                {
                    nType = rnd1.Next(2, 6);
                    sTwo = "0" + Convert.ToString(nType);
                }
                msShuffle2 = msShuffle2 + sTwo;
            }

            for (int i = 1; i <= 40; i++)
            {
                nType = fHoletype(msShuffle2, i);
                switch (nType)
                {
                    case 1:
                        _title[i-1] = null;
                        _text[i - 1] = null;
                        break;
                    default:
                        nCount = _count[nType - 2];
                        nPos = rnd1.Next(1, nCount + 1);
                         _text[i - 1] = null;
                        switch (nType)
                        {
                            case 2:
                                _title[i - 1] = _A[nPos - 1];
                                break;
                            case 3:
                                _title[i - 1] = _B[nPos - 1];
                                break;
                            case 4:
                                _title[i - 1] = _C[nPos - 1];
                                break;
                            default:
                                _title[i - 1] = _D[nPos - 1];
                                break;
                        }
                        break;

                }
            }

            for (int i = 1; i <= 4; i++)
            {
                _selected[i - 1] = 1;
                nPos = (i - 1) * 10 + 1;
                nType = fHoletype(msShuffle2, nPos);
                if (nType == 1)
                {
                    nType = 10;
                }
                else
                {
                    nType += 4;
                }
                fPlace(nType, nPos);
            }

            fListFill();
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
            msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle2.Substring(nSquare * 2, (40 - nSquare) * 2);
        }

        private void fUpdateIcon(int nBar,int nRow)
        {
            PictureBox _pic = new PictureBox();
            int nPos = (nBar - 1) * 10 + nRow;
            int nType = fHoletype(msShuffle2,nPos), nRotate = 1;

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
                        case 8:
                            pic18.Image = _pic.Image;
                            break;
                        case 9:
                            pic18.Image = _pic.Image;
                            break;
                        default:
                            pic1a.Image = _pic.Image;
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
                        case 8:
                            pic28.Image = _pic.Image;
                            break;
                        case 9:
                            pic28.Image = _pic.Image;
                            break;
                        default:
                            pic2a.Image = _pic.Image;
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
                        case 8:
                            pic38.Image = _pic.Image;
                            break;
                        case 9:
                            pic38.Image = _pic.Image;
                            break;
                        default:
                            pic3a.Image = _pic.Image;
                            break;
                    }
                    break;
                default:
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
                        case 8:
                            pic48.Image = _pic.Image;
                            break;
                        case 9:
                            pic48.Image = _pic.Image;
                            break;
                        default:
                            pic4a.Image = _pic.Image;
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
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F D.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F selected_A.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F selected_B.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F selected_C.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F selected_D.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F selected_empty.png"),
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
                default:
                    _pic2 = picture11;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fClick(int nCol, int nRow)
        {
            int nRow2 = _selected[nCol - 1];
            int nPos, nType;
            String sTitle, sText;

            nPos = (nCol - 1) * 10 + nRow2;
            nType = fHoletype(msShuffle2, nPos);
            switch (nType)
            {
                case 10:
                    nType = 1;
                    break;
                case 6:
                    nType = 2;
                    break;
                case 7:
                    nType = 3;
                    break;
                case 8:
                    nType = 4;
                    break;
                case 9:
                    nType = 5;
                    break;
                default:
                    break;

            }
            fPlace(nType, nPos);
            fUpdateIcon(nCol, nRow2);

            nPos = (nCol - 1) * 10 + nRow;
            nType = fHoletype(msShuffle2, nPos);
            switch (nType)
            {
                case 1:
                    nType = 10;
                    break;
                case 2:
                    nType = 6;
                    break;
                case 3:
                    nType = 7;
                    break;
                case 4:
                    nType = 8;
                    break;
                case 5:
                    nType = 9;
                    break;
                default:
                    break;

            }
            fPlace(nType, nPos);
            fUpdateIcon(nCol, nRow);

            _selected[nCol - 1] = nRow;

            fra1.Text = "Selected = (" + Convert.ToString(nCol) + "," + Convert.ToString(nRow) + ")";
            lblTitle.Text = _title[nPos - 1];
            txtText.Text = _text[nPos - 1];
        }

        private void fSelectRow(int nMode)
        {
  
            mnRow = nMode;

            fClick(mnBar, mnRow);
       
        }
        private void fSelectBar(int nMode)
        {
            int nPos;

            mnBar = nMode;
            nPos = (mnBar - 1) * 10 + mnRow;

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

            fra1.Text = "Selected = (" + Convert.ToString(mnBar) + "," + Convert.ToString(mnRow) + ")";
            lblTitle.Text = _title[nPos - 1];
            txtText.Text = _text[nPos - 1];
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnBar = rnd1.Next(1, 5);
            mnRow = rnd1.Next(1, 11);

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

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void Pic18_Click(object sender, EventArgs e)
        {
            fSelectRow(8);
        }

        private void Pic19_Click(object sender, EventArgs e)
        {
            fSelectRow(9);
        }

        private void BtnVisualAD_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int nPos = (mnBar - 1) * 10 + mnRow;

            fSave(nPos);
        }

        private void Lst2_Click(object sender, EventArgs e)
        {
            mnItem2 = lst2.SelectedIndex + 1;

        }

        private void BtnGo1_Click(object sender, EventArgs e)
        {
            String sText = lst1.Text;

            if (mnItem1 != 0)
            {
                fGo1(sText);
            }
        }

        private void BtnGo2_Click(object sender, EventArgs e)
        {
            String sText = lst2.Text;
            int nPos = lst2.SelectedIndex + 1;

            if (mnItem2 != 0)
            {
                fGo1(sText+" ");
                lst2.Items.RemoveAt(nPos - 1);
            }

        }

        private void BtnComply_Click(object sender, EventArgs e)
        {
            if (lst2.Items.Count == 0)
            {
                fReset();
            }
        }

        private void Lst1_Click(object sender, EventArgs e)
        {
            mnItem1 = lst1.SelectedIndex + 1;

        }

        private void Pic1a_Click(object sender, EventArgs e)
        {
            fSelectRow(10);
        }

    }
}
