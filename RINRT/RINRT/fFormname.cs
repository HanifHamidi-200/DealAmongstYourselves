using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RINRT
{
    public partial class fFormname : Form
    {
        private List<int> _category = new List<int> { 0, 0, 0, 0,0};
        private List<int> _lettering = new List<int> { 0, 0, 0, 0 ,0};
        private List<int> _RangeFrom = new List<int> { 5, 13, 26, 32 };
        private List<int> _RangeTo = new List<int> {12,25,31,37 };

        private int fNumber(int nCategory)
        {
            Random rnd1 = new Random();
            int nFrom = _RangeFrom[nCategory - 1];
            int nTo = _RangeTo[nCategory - 1];
            int nNumber = rnd1.Next(nFrom, nTo + 1);

            return nNumber;
        }

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 5; i++)
            {
                _category[i - 1] = rnd1.Next(1, 5);
                _lettering[i - 1] = fNumber(_category[i - 1]);
            }

            fUpdateDisplay();
        }

        private void fSave(bool bSave)
        {
            String sName = "data.txt";
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamWriter sw = new StreamWriter(sName))
                {

                    if (bSave)
                    {
                        sw.WriteLine("TRUE");
                        for(int i = 1; i <= 5; i++)
                        {
                            sLine =Convert.ToString( _lettering[i - 1]);
                            sw.WriteLine(sLine);
                        }
                    }
                    else
                    {
                        sw.WriteLine("FALSE");
                    }
                    sw.Close();
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            nType = _category[0];
            fPeek(nType, nRotate, ref _pic);
            picCategory1.Image = _pic.Image;
            nType = _category[1];
            fPeek(nType, nRotate, ref _pic);
            picCategory2.Image = _pic.Image;
            nType = _category[2];
            fPeek(nType, nRotate, ref _pic);
            picCategory3.Image = _pic.Image;
            nType = _category[3];
            fPeek(nType, nRotate, ref _pic);
            picCategory4.Image = _pic.Image;
            nType = _category[4];
            fPeek(nType, nRotate, ref _pic);
            picCategory5.Image = _pic.Image;

            nType = _lettering[0];
            fPeek(nType, nRotate, ref _pic);
            picLettering1.Image = _pic.Image;
            nType = _lettering[1];
            fPeek(nType, nRotate, ref _pic);
            picLettering2.Image = _pic.Image;
            nType = _lettering[2];
            fPeek(nType, nRotate, ref _pic);
            picLettering3.Image = _pic.Image;
            nType = _lettering[3];
            fPeek(nType, nRotate, ref _pic);
            picLettering4.Image = _pic.Image;
            nType = _lettering[4];
            fPeek(nType, nRotate, ref _pic);
            picLettering5.Image = _pic.Image;
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F category1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F category2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F category3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F category4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F A1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F A2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F A3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F A4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F A5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F A6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F A7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F A8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F B1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F B2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F B3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F B4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F B5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F B6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F B7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F B8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F B9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F B10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F B11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F B12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F B13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F C1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F C2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"F C3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"F C4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"F C5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"F C6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"F D1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"F D2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"F D3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"F D4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"F D5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"F D6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
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
                case 27:
                    _pic2 = picture27;
                    break;
                case 28:
                    _pic2 = picture28;
                    break;
                case 29:
                    _pic2 = picture29;
                    break;
                case 30:
                    _pic2 = picture30;
                    break;
                case 31:
                    _pic2 = picture31;
                    break;
                case 32:
                    _pic2 = picture32;
                    break;
                case 33:
                    _pic2 = picture33;
                    break;
                case 34:
                    _pic2 = picture34;
                    break;
                case 35:
                    _pic2 = picture35;
                    break;
                case 36:
                    _pic2 = picture36;
                    break;
                case 37:
                    _pic2 = picture37;
                    break;
                default:
                    _pic2 = picture38;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        public fFormname()
        {
            InitializeComponent();
        }

        private void FFormname_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnClose1_Click(object sender, EventArgs e)
        {
            fSave(true);
            this.Close();
        }

        private void BtnClose2_Click(object sender, EventArgs e)
        {
            fSave(false);
            this.Close();

        }
    }
}
