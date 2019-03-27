using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTRIB
{
    public partial class fSub1 : Form
    {
        private List<String> _Elements = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _Points = new List<string> { null, null, null, null, null, null, null, null };
        private List<int> _spaces = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private List<String> _text = new List<string> { "H", "He", "Li", "Be", "B", "C", "N", "O", "Fl", "Ar", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca" };
        private int mnItem;
        private bool mbClear = false;

        private void fClick(int nMode)
        {
            Random rnd1 = new Random();
            String sItem = lst1.Text;
            int nLength;

            if (mbClear)
            {
                mbClear = false;
                _Elements[nMode - 1] = null;
            }
            else
            {
                if (_count[nMode - 1]== _spaces[nMode - 1])
                {
                    goto endline;
                }
                _Elements[nMode - 1] = _Elements[nMode - 1] + sItem;
                _count[nMode - 1] += 1;
                lst1.Items.RemoveAt(mnItem - 1);
                nLength = lst1.Items.Count;
                mnItem = rnd1.Next(1, nLength + 1);
            }

            fUpdateDisplay();

            endline:;

        }
        private void fReset()
        {
            Random rnd1 = new Random();

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
                for (int i = 1; i <= 20; i++)
                {
                    lst1.Items.Add(_text[i - 1]);
                }
            }
            mnItem = rnd1.Next(1, 21);
            for (int i = 1; i <= 8; i++)
            {
                _Elements[i - 1] = null;
                _Points[i - 1] = null;
                _spaces[i - 1] = rnd1.Next(1, 5)+1;
                _count[i - 1] = 0;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText;

            for(int i = 1; i <= 8; i++)
            {
                if (_Elements[i - 1] == null)
                {
                    sText = "-";
                }
                else
                {
                    sText = _Elements[i - 1];
                }
                switch (i)
                {
                    case 1:
                        lbl1.Text = sText;
                        txt1.Text = _Points[i - 1];
                        break;
                    case 2:
                        lbl2.Text = sText;
                        txt2.Text = _Points[i - 1];
                        break;
                    case 3:
                        lbl3.Text = sText;
                        txt3.Text = _Points[i - 1];
                        break;
                    case 4:
                        lbl4.Text = sText;
                        txt4.Text = _Points[i - 1];
                        break;
                    case 5:
                        lbl5.Text = sText;
                        txt5.Text = _Points[i - 1];
                        break;
                    case 6:
                        lbl6.Text = sText;
                        txt6.Text = _Points[i - 1];
                        break;
                    case 7:
                        lbl7.Text = sText;
                        txt7.Text = _Points[i - 1];
                        break;
                    default:
                        lbl8.Text = sText;
                        txt8.Text = _Points[i - 1];
                        break;
                }
            }

            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            nType = _spaces[0];
            fPeek(nType, nRotate, ref _pic);
            pic1.Image = _pic.Image;
            nType = _spaces[1];
            fPeek(nType, nRotate, ref _pic);
            pic2.Image = _pic.Image;
            nType = _spaces[2];
            fPeek(nType, nRotate, ref _pic);
            pic3.Image = _pic.Image;
            nType = _spaces[3];
            fPeek(nType, nRotate, ref _pic);
            pic4.Image = _pic.Image;
            nType = _spaces[4];
            fPeek(nType, nRotate, ref _pic);
            pic5.Image = _pic.Image;
            nType = _spaces[5];
            fPeek(nType, nRotate, ref _pic);
            pic6.Image = _pic.Image;
            nType = _spaces[6];
            fPeek(nType, nRotate, ref _pic);
            pic7.Image = _pic.Image;
            nType = _spaces[7];
            fPeek(nType, nRotate, ref _pic);
            pic8.Image = _pic.Image;

        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F unused.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F spaces1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F spaces2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F spaces3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F spaces4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
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
                default:
                    _pic2 = picture6;
                    break;
            }
        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst1_Click(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            fClick(8);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mbClear = true;
        }
    }
}
