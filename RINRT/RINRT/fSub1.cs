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
    public partial class fSub1 : Form
    {
        private int mnMode, mnWord;
        private List<int> _mode1_L1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode1_L2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode1_L3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode1_L4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode1_L5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode2_L1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode2_L2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode2_L3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode2_L4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode2_L5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode3_L1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode3_L2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode3_L3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode3_L4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode3_L5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode4_L1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode4_L2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode4_L3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode4_L4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _mode4_L5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _get = new List<int> { 0, 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            for(int i = 1; i <= 8; i++)
            {
                _mode1_L1[i - 1] = 38;
                _mode1_L2[i - 1] = 38;
                _mode1_L3[i - 1] = 38;
                _mode1_L4[i - 1] = 38;
                _mode1_L5[i - 1] = 38;
            }
            for (int i = 1; i <= 8; i++)
            {
                _mode2_L1[i - 1] = 38;
                _mode2_L2[i - 1] = 38;
                _mode2_L3[i - 1] = 38;
                _mode2_L4[i - 1] = 38;
                _mode2_L5[i - 1] = 38;
            }
            for (int i = 1; i <= 8; i++)
            {
                _mode3_L1[i - 1] = 38;
                _mode3_L2[i - 1] = 38;
                _mode3_L3[i - 1] = 38;
                _mode3_L4[i - 1] = 38;
                _mode3_L5[i - 1] = 38;
            }
            for (int i = 1; i <= 8; i++)
            {
                _mode4_L1[i - 1] = 38;
                _mode4_L2[i - 1] = 38;
                _mode4_L3[i - 1] = 38;
                _mode4_L4[i - 1] = 38;
                _mode4_L5[i - 1] = 38;
            }

            for (int i = 1; i <= 4; i++)
            {
                mnMode = i;
                fUpdateDisplay();
            }

            mnMode = rnd1.Next(1, 5);
            mnWord = 1;
        }

        private void fGet()
        {
            String sName ="data.txt";
            String sLine;
     
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    if (sLine == "FALSE")
                    {

                    }
                    else
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            sLine = sr.ReadLine();
                            _get[i - 1] = Convert.ToInt32(sLine);
                        }
                    }
                    sr.Close();
                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

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


        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            switch (mnMode)
            {
                case 1:
                    nType = _mode1_L1[0];
                    fPeek(nType, nRotate, ref _pic);
                    picA11.Image = _pic.Image;
                    nType = _mode1_L2[0];
                    fPeek(nType, nRotate, ref _pic);
                    picA12.Image = _pic.Image;
                    nType = _mode1_L3[0];
                    fPeek(nType, nRotate, ref _pic);
                    picA13.Image = _pic.Image;
                    nType = _mode1_L4[0];
                    fPeek(nType, nRotate, ref _pic);
                    picA14.Image = _pic.Image;
                    nType = _mode1_L5[0];
                    fPeek(nType, nRotate, ref _pic);
                    picA15.Image = _pic.Image;

                    nType = _mode1_L1[1];
                    fPeek(nType, nRotate, ref _pic);
                    picA21.Image = _pic.Image;
                    nType = _mode1_L2[1];
                    fPeek(nType, nRotate, ref _pic);
                    picA22.Image = _pic.Image;
                    nType = _mode1_L3[1];
                    fPeek(nType, nRotate, ref _pic);
                    picA23.Image = _pic.Image;
                    nType = _mode1_L4[1];
                    fPeek(nType, nRotate, ref _pic);
                    picA24.Image = _pic.Image;
                    nType = _mode1_L5[1];
                    fPeek(nType, nRotate, ref _pic);
                    picA25.Image = _pic.Image;

                    nType = _mode1_L1[2];
                    fPeek(nType, nRotate, ref _pic);
                    picA31.Image = _pic.Image;
                    nType = _mode1_L2[2];
                    fPeek(nType, nRotate, ref _pic);
                    picA32.Image = _pic.Image;
                    nType = _mode1_L3[2];
                    fPeek(nType, nRotate, ref _pic);
                    picA33.Image = _pic.Image;
                    nType = _mode1_L4[2];
                    fPeek(nType, nRotate, ref _pic);
                    picA34.Image = _pic.Image;
                    nType = _mode1_L5[2];
                    fPeek(nType, nRotate, ref _pic);
                    picA35.Image = _pic.Image;

                    nType = _mode1_L1[3];
                    fPeek(nType, nRotate, ref _pic);
                    picA41.Image = _pic.Image;
                    nType = _mode1_L2[3];
                    fPeek(nType, nRotate, ref _pic);
                    picA42.Image = _pic.Image;
                    nType = _mode1_L3[3];
                    fPeek(nType, nRotate, ref _pic);
                    picA43.Image = _pic.Image;
                    nType = _mode1_L4[3];
                    fPeek(nType, nRotate, ref _pic);
                    picA44.Image = _pic.Image;
                    nType = _mode1_L5[3];
                    fPeek(nType, nRotate, ref _pic);
                    picA45.Image = _pic.Image;

                    nType = _mode1_L1[4];
                    fPeek(nType, nRotate, ref _pic);
                    picA51.Image = _pic.Image;
                    nType = _mode1_L2[4];
                    fPeek(nType, nRotate, ref _pic);
                    picA52.Image = _pic.Image;
                    nType = _mode1_L3[4];
                    fPeek(nType, nRotate, ref _pic);
                    picA53.Image = _pic.Image;
                    nType = _mode1_L4[4];
                    fPeek(nType, nRotate, ref _pic);
                    picA54.Image = _pic.Image;
                    nType = _mode1_L5[4];
                    fPeek(nType, nRotate, ref _pic);
                    picA55.Image = _pic.Image;

                    nType = _mode1_L1[5];
                    fPeek(nType, nRotate, ref _pic);
                    picA61.Image = _pic.Image;
                    nType = _mode1_L2[5];
                    fPeek(nType, nRotate, ref _pic);
                    picA62.Image = _pic.Image;
                    nType = _mode1_L3[5];
                    fPeek(nType, nRotate, ref _pic);
                    picA63.Image = _pic.Image;
                    nType = _mode1_L4[5];
                    fPeek(nType, nRotate, ref _pic);
                    picA64.Image = _pic.Image;
                    nType = _mode1_L5[5];
                    fPeek(nType, nRotate, ref _pic);
                    picA65.Image = _pic.Image;

                    nType = _mode1_L1[6];
                    fPeek(nType, nRotate, ref _pic);
                    picA71.Image = _pic.Image;
                    nType = _mode1_L2[6];
                    fPeek(nType, nRotate, ref _pic);
                    picA72.Image = _pic.Image;
                    nType = _mode1_L3[6];
                    fPeek(nType, nRotate, ref _pic);
                    picA73.Image = _pic.Image;
                    nType = _mode1_L4[6];
                    fPeek(nType, nRotate, ref _pic);
                    picA74.Image = _pic.Image;
                    nType = _mode1_L5[6];
                    fPeek(nType, nRotate, ref _pic);
                    picA75.Image = _pic.Image;
                    break;
                case 2:
                    nType = _mode2_L1[0];
                    fPeek(nType, nRotate, ref _pic);
                    picB11.Image = _pic.Image;
                    nType = _mode2_L2[0];
                    fPeek(nType, nRotate, ref _pic);
                    picB12.Image = _pic.Image;
                    nType = _mode2_L3[0];
                    fPeek(nType, nRotate, ref _pic);
                    picB13.Image = _pic.Image;
                    nType = _mode2_L4[0];
                    fPeek(nType, nRotate, ref _pic);
                    picB14.Image = _pic.Image;
                    nType = _mode2_L5[0];
                    fPeek(nType, nRotate, ref _pic);
                    picB15.Image = _pic.Image;

                    nType = _mode2_L1[1];
                    fPeek(nType, nRotate, ref _pic);
                    picB21.Image = _pic.Image;
                    nType = _mode2_L2[1];
                    fPeek(nType, nRotate, ref _pic);
                    picB22.Image = _pic.Image;
                    nType = _mode2_L3[1];
                    fPeek(nType, nRotate, ref _pic);
                    picB23.Image = _pic.Image;
                    nType = _mode2_L4[1];
                    fPeek(nType, nRotate, ref _pic);
                    picB24.Image = _pic.Image;
                    nType = _mode2_L5[1];
                    fPeek(nType, nRotate, ref _pic);
                    picB25.Image = _pic.Image;

                    nType = _mode2_L1[2];
                    fPeek(nType, nRotate, ref _pic);
                    picB31.Image = _pic.Image;
                    nType = _mode2_L2[2];
                    fPeek(nType, nRotate, ref _pic);
                    picB32.Image = _pic.Image;
                    nType = _mode2_L3[2];
                    fPeek(nType, nRotate, ref _pic);
                    picB33.Image = _pic.Image;
                    nType = _mode2_L4[2];
                    fPeek(nType, nRotate, ref _pic);
                    picB34.Image = _pic.Image;
                    nType = _mode2_L5[2];
                    fPeek(nType, nRotate, ref _pic);
                    picB35.Image = _pic.Image;

                    nType = _mode2_L1[3];
                    fPeek(nType, nRotate, ref _pic);
                    picB41.Image = _pic.Image;
                    nType = _mode2_L2[3];
                    fPeek(nType, nRotate, ref _pic);
                    picB42.Image = _pic.Image;
                    nType = _mode2_L3[3];
                    fPeek(nType, nRotate, ref _pic);
                    picB43.Image = _pic.Image;
                    nType = _mode2_L4[3];
                    fPeek(nType, nRotate, ref _pic);
                    picB44.Image = _pic.Image;
                    nType = _mode2_L5[3];
                    fPeek(nType, nRotate, ref _pic);
                    picB45.Image = _pic.Image;

                    nType = _mode2_L1[4];
                    fPeek(nType, nRotate, ref _pic);
                    picB51.Image = _pic.Image;
                    nType = _mode2_L2[4];
                    fPeek(nType, nRotate, ref _pic);
                    picB52.Image = _pic.Image;
                    nType = _mode2_L3[4];
                    fPeek(nType, nRotate, ref _pic);
                    picB53.Image = _pic.Image;
                    nType = _mode2_L4[4];
                    fPeek(nType, nRotate, ref _pic);
                    picB54.Image = _pic.Image;
                    nType = _mode2_L5[4];
                    fPeek(nType, nRotate, ref _pic);
                    picB55.Image = _pic.Image;
                    break;
               case 3:
                    nType = _mode3_L1[0];
                    fPeek(nType, nRotate, ref _pic);
                    picC11.Image = _pic.Image;
                    nType = _mode3_L2[0];
                    fPeek(nType, nRotate, ref _pic);
                    picC12.Image = _pic.Image;
                    nType = _mode3_L3[0];
                    fPeek(nType, nRotate, ref _pic);
                    picC13.Image = _pic.Image;
                    nType = _mode3_L4[0];
                    fPeek(nType, nRotate, ref _pic);
                    picC14.Image = _pic.Image;
                    nType = _mode3_L5[0];
                    fPeek(nType, nRotate, ref _pic);
                    picC15.Image = _pic.Image;

                    nType = _mode3_L1[1];
                    fPeek(nType, nRotate, ref _pic);
                    picC21.Image = _pic.Image;
                    nType = _mode3_L2[1];
                    fPeek(nType, nRotate, ref _pic);
                    picC22.Image = _pic.Image;
                    nType = _mode3_L3[1];
                    fPeek(nType, nRotate, ref _pic);
                    picC23.Image = _pic.Image;
                    nType = _mode3_L4[1];
                    fPeek(nType, nRotate, ref _pic);
                    picC24.Image = _pic.Image;
                    nType = _mode3_L5[1];
                    fPeek(nType, nRotate, ref _pic);
                    picC25.Image = _pic.Image;

                    nType = _mode3_L1[2];
                    fPeek(nType, nRotate, ref _pic);
                    picC31.Image = _pic.Image;
                    nType = _mode3_L2[2];
                    fPeek(nType, nRotate, ref _pic);
                    picC32.Image = _pic.Image;
                    nType = _mode3_L3[2];
                    fPeek(nType, nRotate, ref _pic);
                    picC33.Image = _pic.Image;
                    nType = _mode3_L4[2];
                    fPeek(nType, nRotate, ref _pic);
                    picC34.Image = _pic.Image;
                    nType = _mode3_L5[2];
                    fPeek(nType, nRotate, ref _pic);
                    picC35.Image = _pic.Image;

                    nType = _mode3_L1[3];
                    fPeek(nType, nRotate, ref _pic);
                    picC41.Image = _pic.Image;
                    nType = _mode3_L2[3];
                    fPeek(nType, nRotate, ref _pic);
                    picC42.Image = _pic.Image;
                    nType = _mode3_L3[3];
                    fPeek(nType, nRotate, ref _pic);
                    picC43.Image = _pic.Image;
                    nType = _mode3_L4[3];
                    fPeek(nType, nRotate, ref _pic);
                    picC44.Image = _pic.Image;
                    nType = _mode3_L5[3];
                    fPeek(nType, nRotate, ref _pic);
                    picC45.Image = _pic.Image;

                    nType = _mode3_L1[4];
                    fPeek(nType, nRotate, ref _pic);
                    picC51.Image = _pic.Image;
                    nType = _mode3_L2[4];
                    fPeek(nType, nRotate, ref _pic);
                    picC52.Image = _pic.Image;
                    nType = _mode3_L3[4];
                    fPeek(nType, nRotate, ref _pic);
                    picC53.Image = _pic.Image;
                    nType = _mode3_L4[4];
                    fPeek(nType, nRotate, ref _pic);
                    picC54.Image = _pic.Image;
                    nType = _mode3_L5[4];
                    fPeek(nType, nRotate, ref _pic);
                    picC55.Image = _pic.Image;

                    nType = _mode3_L1[5];
                    fPeek(nType, nRotate, ref _pic);
                    picC61.Image = _pic.Image;
                    nType = _mode3_L2[5];
                    fPeek(nType, nRotate, ref _pic);
                    picC62.Image = _pic.Image;
                    nType = _mode3_L3[5];
                    fPeek(nType, nRotate, ref _pic);
                    picC63.Image = _pic.Image;
                    nType = _mode3_L4[5];
                    fPeek(nType, nRotate, ref _pic);
                    picC64.Image = _pic.Image;
                    nType = _mode3_L5[5];
                    fPeek(nType, nRotate, ref _pic);
                    picC65.Image = _pic.Image;

                    nType = _mode3_L1[6];
                    fPeek(nType, nRotate, ref _pic);
                    picC71.Image = _pic.Image;
                    nType = _mode3_L2[6];
                    fPeek(nType, nRotate, ref _pic);
                    picC72.Image = _pic.Image;
                    nType = _mode3_L3[6];
                    fPeek(nType, nRotate, ref _pic);
                    picC73.Image = _pic.Image;
                    nType = _mode3_L4[6];
                    fPeek(nType, nRotate, ref _pic);
                    picC74.Image = _pic.Image;
                    nType = _mode3_L5[6];
                    fPeek(nType, nRotate, ref _pic);
                    picC75.Image = _pic.Image;

                    nType = _mode3_L1[7];
                    fPeek(nType, nRotate, ref _pic);
                    picC81.Image = _pic.Image;
                    nType = _mode3_L2[7];
                    fPeek(nType, nRotate, ref _pic);
                    picC82.Image = _pic.Image;
                    nType = _mode3_L3[7];
                    fPeek(nType, nRotate, ref _pic);
                    picC83.Image = _pic.Image;
                    nType = _mode3_L4[7];
                    fPeek(nType, nRotate, ref _pic);
                    picC84.Image = _pic.Image;
                    nType = _mode3_L5[7];
                    fPeek(nType, nRotate, ref _pic);
                    picC85.Image = _pic.Image;
                    break;
                default:
                    nType = _mode4_L1[0];
                    fPeek(nType, nRotate, ref _pic);
                    picD11.Image = _pic.Image;
                    nType = _mode4_L2[0];
                    fPeek(nType, nRotate, ref _pic);
                    picD12.Image = _pic.Image;
                    nType = _mode4_L3[0];
                    fPeek(nType, nRotate, ref _pic);
                    picD13.Image = _pic.Image;
                    nType = _mode4_L4[0];
                    fPeek(nType, nRotate, ref _pic);
                    picD14.Image = _pic.Image;
                    nType = _mode4_L5[0];
                    fPeek(nType, nRotate, ref _pic);
                    picD15.Image = _pic.Image;

                    nType = _mode4_L1[1];
                    fPeek(nType, nRotate, ref _pic);
                    picD21.Image = _pic.Image;
                    nType = _mode4_L2[1];
                    fPeek(nType, nRotate, ref _pic);
                    picD22.Image = _pic.Image;
                    nType = _mode4_L3[1];
                    fPeek(nType, nRotate, ref _pic);
                    picD23.Image = _pic.Image;
                    nType = _mode4_L4[1];
                    fPeek(nType, nRotate, ref _pic);
                    picD24.Image = _pic.Image;
                    nType = _mode4_L5[1];
                    fPeek(nType, nRotate, ref _pic);
                    picD25.Image = _pic.Image;

                    nType = _mode4_L1[2];
                    fPeek(nType, nRotate, ref _pic);
                    picD31.Image = _pic.Image;
                    nType = _mode4_L2[2];
                    fPeek(nType, nRotate, ref _pic);
                    picD32.Image = _pic.Image;
                    nType = _mode4_L3[2];
                    fPeek(nType, nRotate, ref _pic);
                    picD33.Image = _pic.Image;
                    nType = _mode4_L4[2];
                    fPeek(nType, nRotate, ref _pic);
                    picD34.Image = _pic.Image;
                    nType = _mode4_L5[2];
                    fPeek(nType, nRotate, ref _pic);
                    picD35.Image = _pic.Image;

                    nType = _mode4_L1[3];
                    fPeek(nType, nRotate, ref _pic);
                    picD41.Image = _pic.Image;
                    nType = _mode4_L2[3];
                    fPeek(nType, nRotate, ref _pic);
                    picD42.Image = _pic.Image;
                    nType = _mode4_L3[3];
                    fPeek(nType, nRotate, ref _pic);
                    picD43.Image = _pic.Image;
                    nType = _mode4_L4[3];
                    fPeek(nType, nRotate, ref _pic);
                    picD44.Image = _pic.Image;
                    nType = _mode4_L5[3];
                    fPeek(nType, nRotate, ref _pic);
                    picD45.Image = _pic.Image;

                    nType = _mode4_L1[4];
                    fPeek(nType, nRotate, ref _pic);
                    picD51.Image = _pic.Image;
                    nType = _mode4_L2[4];
                    fPeek(nType, nRotate, ref _pic);
                    picD52.Image = _pic.Image;
                    nType = _mode4_L3[4];
                    fPeek(nType, nRotate, ref _pic);
                    picD53.Image = _pic.Image;
                    nType = _mode4_L4[4];
                    fPeek(nType, nRotate, ref _pic);
                    picD54.Image = _pic.Image;
                    nType = _mode4_L5[4];
                    fPeek(nType, nRotate, ref _pic);
                    picD55.Image = _pic.Image;

                    nType = _mode4_L1[5];
                    fPeek(nType, nRotate, ref _pic);
                    picD61.Image = _pic.Image;
                    nType = _mode4_L2[5];
                    fPeek(nType, nRotate, ref _pic);
                    picD62.Image = _pic.Image;
                    nType = _mode4_L3[5];
                    fPeek(nType, nRotate, ref _pic);
                    picD63.Image = _pic.Image;
                    nType = _mode4_L4[5];
                    fPeek(nType, nRotate, ref _pic);
                    picD64.Image = _pic.Image;
                    nType = _mode4_L5[5];
                    fPeek(nType, nRotate, ref _pic);
                    picD65.Image = _pic.Image;

                    nType = _mode4_L1[6];
                    fPeek(nType, nRotate, ref _pic);
                    picD71.Image = _pic.Image;
                    nType = _mode4_L2[6];
                    fPeek(nType, nRotate, ref _pic);
                    picD72.Image = _pic.Image;
                    nType = _mode4_L3[6];
                    fPeek(nType, nRotate, ref _pic);
                    picD73.Image = _pic.Image;
                    nType = _mode4_L4[6];
                    fPeek(nType, nRotate, ref _pic);
                    picD74.Image = _pic.Image;
                    nType = _mode4_L5[6];
                    fPeek(nType, nRotate, ref _pic);
                    picD75.Image = _pic.Image;
                    break;
            }
        }

        private void fGo()
        {
            fFormname _dlg = new fFormname();
            _dlg.ShowDialog();

            fGet();

            switch (mnMode)
            {
                case 1:
                    _mode1_L1[mnWord - 1] = _get[0];
                    _mode1_L2[mnWord - 1] = _get[1];
                    _mode1_L3[mnWord - 1] = _get[2];
                    _mode1_L4[mnWord - 1] = _get[3];
                    _mode1_L5[mnWord - 1] = _get[4];
                    break;
                case 2:
                    _mode2_L1[mnWord - 1] = _get[0];
                    _mode2_L2[mnWord - 1] = _get[1];
                    _mode2_L3[mnWord - 1] = _get[2];
                    _mode2_L4[mnWord - 1] = _get[3];
                    _mode2_L5[mnWord - 1] = _get[4];
                    break;
                case 3:
                    _mode3_L1[mnWord - 1] = _get[0];
                    _mode3_L2[mnWord - 1] = _get[1];
                    _mode3_L3[mnWord - 1] = _get[2];
                    _mode3_L4[mnWord - 1] = _get[3];
                    _mode3_L5[mnWord - 1] = _get[4];
                    break;
                default:
                    _mode4_L1[mnWord - 1] = _get[0];
                    _mode4_L2[mnWord - 1] = _get[1];
                    _mode4_L3[mnWord - 1] = _get[2];
                    _mode4_L4[mnWord - 1] = _get[3];
                    _mode4_L5[mnWord - 1] = _get[4];
                    break;
            }

            fUpdateDisplay();

        }
        private void fShow(int nMode)
        {
            fra1.Visible = false;
            fra2.Visible = false;
            fra3.Visible = false;
            fra4.Visible = false;

            switch (nMode)
            {
                case 1:
                    fra1.Visible = true;
                    break;
                case 2:
                    fra2.Visible = true;
                    break;
                case 3:
                    fra3.Visible = true;
                    break;
                default:
                    fra4.Visible = true;
                    break;
            }
        }
        public fSub1()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;
            fra3.Left = fra1.Left;
            fra3.Top = fra1.Top;
            fra4.Left = fra1.Left;
            fra4.Top = fra1.Top;

        }

        private void FSub1_Load(object sender, EventArgs e)
        {
             fReset();
            fShow(mnMode);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
            fShow(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fShow(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fShow(3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            mnMode = 4;
            fShow(4);
        }

        private void Fra3_Enter(object sender, EventArgs e)
        {

        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            mnWord = 1;
            fGo();
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            mnWord = 2;
            fGo();

        }

        private void BtnA3_Click(object sender, EventArgs e)
        {
            mnWord = 3;
            fGo();

        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            mnWord = 4;
            fGo();

        }

        private void BtnA5_Click(object sender, EventArgs e)
        {
            mnWord = 5;
            fGo();

        }

        private void BtnA6_Click(object sender, EventArgs e)
        {
            mnWord = 6;
            fGo();

        }

        private void BtnA7_Click(object sender, EventArgs e)
        {
            mnWord = 7;
            fGo();

        }

        private void BtnA8_Click(object sender, EventArgs e)
        {
            mnWord = 8;
            fGo();

        }
        private void Fra4_Enter(object sender, EventArgs e)
        {

        }
    }
}
