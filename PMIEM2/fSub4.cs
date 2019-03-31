using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMIEM2
{
    public partial class fSub4 : Form
    {
        private List<String> _text = new List<String> { "Name", "Address", "Date", "ID", "ColourScheme", "Password", "StudentID/WorkID" };
        private int mnMode;
        private List<String> _list1 = new List<String> { null };
        private List<String> _list2 = new List<String> { null, null, null, null };
        private List<String> _list3 = new List<String> { null, null };
        private List<int> _list4a = new List<int> { 0 };
        private List<String> _list4b = new List<String> { null };
        private List<int> _list5 = new List<int> { 0, 0, 0 };
        private List<String> _list6 = new List<String> { null };
        private List<int> _list7 = new List<int> { 0, 0 };
        private String msFile = "Info.txt";
        private int mnColour = 0;
        private void fChange(int nMode)
        {
            Random rnd1 = new Random();
            int nNewcode = rnd1.Next(1000, 10000);

            switch (nMode)
            {
                case 11:
                    _list1[0] = txt1.Text;
                    fUpdatePanel(1);
                    break;
                case 21:
                    _list2[0] = txt2.Text;
                    fUpdatePanel(2);
                    break;
                case 22:
                    _list2[1] = txt2.Text;
                    fUpdatePanel(2);
                    break;
                case 23:
                    _list2[2] = txt2.Text;
                    fUpdatePanel(2);
                    break;
                case 24:
                    _list2[3] = txt2.Text;
                    fUpdatePanel(2);
                    break;
                case 31:
                    _list3[1] = txt3.Text;
                    fUpdatePanel(3);
                    break;
                case 41:
                    _list4a[0]++;
                    fUpdatePanel(4);
                    break;
                case 42:
                    _list4b[0] = txt4.Text;
                    fUpdatePanel(4);
                    break;
                case 51:
                    _list5[0] = mnColour;
                    fUpdatePanel(5);
                    break;
                case 52:
                    _list5[1] = mnColour;
                    fUpdatePanel(5);
                    break;
                case 53:
                    _list5[2] = mnColour;
                    fUpdatePanel(5);
                    break;
                case 61:
                    _list6[0] = txt6.Text;
                    fUpdatePanel(6);
                    break;
                case 71:
                    _list7[0] = nNewcode;
                    fUpdatePanel(7);
                    break;
                case 72:
                    _list7[1] = nNewcode;
                    fUpdatePanel(7);
                    break;
            }
        }
        private void fFLoad()
        {
            String sLine;

            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@msFile))
                {

                    sLine = file.ReadLine();
                    _list1[0] = file.ReadLine();
                    sLine = file.ReadLine();
                    for (int i = 1; i <= 4; i++)
                    {
                        _list2[i - 1] = file.ReadLine();
                    }
                    sLine = file.ReadLine();
                    for (int i = 1; i <= 2; i++)
                    {
                        _list3[i - 1] = file.ReadLine();
                    }
                    sLine = file.ReadLine();
                    sLine = file.ReadLine();
                    _list4a[0] = Convert.ToInt32(sLine);
                    _list4b[0] = file.ReadLine();
                    sLine = file.ReadLine();
                    for (int i = 1; i <= 3; i++)
                    {
                        sLine = file.ReadLine();
                        _list5[i - 1] = Convert.ToInt32(sLine);
                    }
                    sLine = file.ReadLine();
                    _list6[0] = file.ReadLine();
                    sLine = file.ReadLine();
                    for (int i = 1; i <= 2; i++)
                    {
                        sLine = file.ReadLine();
                        _list7[i - 1] = Convert.ToInt32(sLine);
                    }
                    file.Close();
                    fUpdateDisplay();
                    fColourall();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void fFSave()
        {
            String sLine;

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@msFile))
                {

                    file.WriteLine("LIST1");
                    file.WriteLine(_list1[0]);
                    file.WriteLine("LIST2");
                    for (int i = 1; i <= 4; i++)
                    {
                        file.WriteLine(_list2[i-1]);
                    }
                    file.WriteLine("LIST3");
                    for (int i = 1; i <= 2; i++)
                    {
                        file.WriteLine(_list3[i - 1]);
                    }
                    file.WriteLine("LIST4");
                    file.WriteLine(_list4a[0]);
                    file.WriteLine(_list4b[0]);
                     file.WriteLine("LIST5");
                    for (int i = 1; i <= 3; i++)
                    {
                        file.WriteLine(_list5[i - 1]);
                    }
                    file.WriteLine("LIST6");
                    file.WriteLine(_list6[0]);
                    file.WriteLine("LIST7");
                    for (int i = 1; i <= 2; i++)
                    {
                        file.WriteLine(_list7[i - 1]);
                    }
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void fUpdatePanel(int nMode)
        {
            PictureBox _pic = new PictureBox();
            bool bError = false;

            fPicture(ref _pic, ref bError);
            if (bError)
            {
                fPicture(ref _pic, ref bError);
            }

            switch (nMode)
            {
                case 1:
                    lbl1Name.Text = _list1[0];
                    txt1.Text = null;
                    break;
                case 2:
                    lbl21.Text = "Line1 = " + _list2[0];
                    lbl22.Text = "Line2 = " + _list2[1];
                    lbl23.Text = "Line3 = " + _list2[2];
                    lbl24.Text = "Postcode = " + _list2[3];
                    txt2.Text = null;
                    break;
                case 3:
                    lbl3Date.Text = "Date = " + DateTime.Now.ToShortDateString();
                    lbl3Target.Text = "TargetDate = " + _list3[1];
                    txt3.Text = null;
                    break;
                case 4:
                    pic1.Image = _pic.Image;
                    pic4.Image = _pic.Image;
                    pic6.Image = _pic.Image;
                    pic7.Image = _pic.Image;
                    lbl4ID.Text = "ID = " + Convert.ToString(_list4b[0]);
                    txt4.Text = null;
                    break;
                case 5:
                    lbl51.Text = "BackColour = " + fColour(_list5[0]);
                    lbl52.Text = "ButtonColour = " + fColour(_list5[1]);
                    lbl53.Text = "CoverColour = " + fColour(_list5[2]);
                    fColourall();
                    break;
                case 6:
                    lbl6Password.Text = "Password = " + fPassword();
                    txt6.Text = null;
                    break;
                default:
                    lbl7Student.Text = "StudentID = " + Convert.ToString(_list7[0]);
                    lbl7Work.Text = "WorlkID = " + Convert.ToString(_list7[1]);
                    break;
            }
        }

        private void fPicture(ref PictureBox _pic2, ref bool bError)
        {
            int nFace = _list4a[0];
            String sFile = "F face" + Convert.ToString(nFace) + ".png";
            PictureBox _pic = new PictureBox();

            try
            {
                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(@sFile),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                _pic = picture1;
                _pic2 = _pic;
            }
            catch
            {
                bError = true;
                _list4a[0] = 1;
                _pic2 = null;
            }
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            bool bError = false;

            fPicture(ref _pic, ref bError);
            if (bError)
            {
                fPicture(ref _pic, ref bError);
            }

            pic1.Image = _pic.Image;
            lbl1Name.Text = _list1[0];
            txt1.Text = null;

            lbl21.Text = "Line1 = " + _list2[0];
            lbl22.Text = "Line2 = " + _list2[1];
            lbl23.Text = "Line3 = " + _list2[2];
            lbl24.Text = "Postcode = " + _list2[3];
            txt2.Text = null;

            lbl3Date.Text = "Date = " + DateTime.Now.ToShortDateString();
            lbl3Target.Text = "TargetDate = " + _list3[1];
            txt3.Text = null;

            pic4.Image = _pic.Image;
            lbl4ID.Text = "ID = "+Convert.ToString(_list4b[0]);
            txt4.Text = null;

            lbl51.Text = "BackColour = " + fColour(_list5[0]);
            lbl52.Text = "ButtonColour = " + fColour(_list5[1]);
            lbl53.Text = "CoverColour = " + fColour(_list5[2]);

            pic6.Image = _pic.Image;
            lbl6Password.Text = "Password = " + fPassword();
            txt6.Text = null;

            pic7.Image = _pic.Image;
            lbl7Student.Text = "StudentID = " + Convert.ToString(_list7[0]);
            lbl7Work.Text = "WorlkID = " + Convert.ToString(_list7[1]);
        }

        private void fColourall()
        {
            fra1.BackColor = fColour2(_list5[0]);
            fra2.BackColor = fColour2(_list5[0]);
            fra3.BackColor = fColour2(_list5[0]);
            fra4.BackColor = fColour2(_list5[0]);
            fra5.BackColor = fColour2(_list5[0]);
            fra6.BackColor = fColour2(_list5[0]);
            fra7.BackColor = fColour2(_list5[0]);

            btn1.BackColor = fColour2(_list5[1]);
            btn2.BackColor = fColour2(_list5[1]);
            btn3.BackColor = fColour2(_list5[1]);
            btn4.BackColor = fColour2(_list5[1]);
            btn5.BackColor = fColour2(_list5[1]);
            btn6.BackColor = fColour2(_list5[1]);
            btn7.BackColor = fColour2(_list5[1]);
            lblName.BackColor = fColour2(_list5[1]);

            this.BackColor = fColour2(_list5[2]);

        }
        private String fPassword()
        {
            String sPassword = _list6[0];
            int nLength = sPassword.Length;
            String sText = null;

            for (int i = 1; i <= nLength; i++)
            {
                sText = sText + "*";
            }

            return sText;
        }
        private String fColour(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    return "green";
                case 2:
                    return "yellow";
                case 3:
                    return "black";
                case 4:
                    return "blue";
                case 5:
                    return "purple";
                case 6:
                    return "orange";
                default:
                    return "green";


            }
        }
        private Color fColour2(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Black;
                case 4:
                    return Color.Blue;
                case 5:
                    return Color.Purple;
                case 6:
                    return Color.Orange;
                default:
                    return Color.Green;


            }
        }

        private void fShow(int nMode)
        {
            mnMode = nMode;

            fra1.Visible = false;
            fra2.Visible = false;
            fra3.Visible = false;
            fra4.Visible = false;
            fra5.Visible = false;
            fra6.Visible = false;
            fra7.Visible = false;

            btn1.BackColor = fColour2(_list5[1]);
            btn2.BackColor = fColour2(_list5[1]);
            btn3.BackColor = fColour2(_list5[1]);
            btn4.BackColor = fColour2(_list5[1]);
            btn5.BackColor = fColour2(_list5[1]);
            btn6.BackColor = fColour2(_list5[1]);
            btn7.BackColor = fColour2(_list5[1]);
            lblName.BackColor = fColour2(_list5[1]);

            switch (mnMode)
            {
                case 1:
                    fra1.Visible = true;
                    btn1.BackColor = Color.Red;
                    break;
                case 2:
                    fra2.Visible = true;
                    btn2.BackColor = Color.Red;
                    break;
                case 3:
                    fra3.Visible = true;
                    btn3.BackColor = Color.Red;
                    break;
                case 4:
                    fra4.Visible = true;
                    btn4.BackColor = Color.Red;
                    break;
                case 5:
                    fra5.Visible = true;
                    btn5.BackColor = Color.Red;
                    break;
                case 6:
                    fra6.Visible = true;
                    btn6.BackColor = Color.Red;
                    break;
                default:
                    fra7.Visible = true;
                    btn7.BackColor = Color.Red;
                    break;
            }

            lblName.Text = "---" + _text[mnMode - 1] + "---";
        }
        public fSub4()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;
            fra3.Left = fra1.Left;
            fra3.Top = fra1.Top;
            fra4.Left = fra1.Left;
            fra4.Top = fra1.Top;
            fra5.Left = fra1.Left;
            fra5.Top = fra1.Top;
            fra6.Left = fra1.Left;
            fra6.Top = fra1.Top;
            fra7.Left = fra1.Left;
            fra7.Top = fra1.Top;

        }

        private void FSub4_Load(object sender, EventArgs e)
        {
            fShow(4);
            fFLoad();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            fShow(4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            fShow(5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            fShow(6);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            fShow(7);
        }

        private void Pic51_Click(object sender, EventArgs e)
        {
            mnColour = 1;
        }
        private void Pic52_Click(object sender, EventArgs e)
        {
            mnColour = 2;
        }
        private void Pic53_Click(object sender, EventArgs e)
        {
            mnColour = 3;
        }
        private void Pic54_Click(object sender, EventArgs e)
        {
            mnColour = 4;
        }
        private void Pic55_Click(object sender, EventArgs e)
        {
            mnColour = 5;
        }
        private void Pic56_Click(object sender, EventArgs e)
        {
            mnColour = 6;
        }

        private void Btn1Name_Click(object sender, EventArgs e)
        {
            fChange(11);
        }

        private void Btn21Change_Click(object sender, EventArgs e)
        {
            fChange(21);
        }

        private void Btn22Change_Click(object sender, EventArgs e)
        {
            fChange(22);
        }

        private void Btn23Change_Click(object sender, EventArgs e)
        {
            fChange(23);
        }

        private void Btn24Change_Click(object sender, EventArgs e)
        {
            fChange(24);
        }

        private void Btn3Target_Click(object sender, EventArgs e)
        {
            fChange(31);
        }

        private void Btn4Face_Click(object sender, EventArgs e)
        {
            fChange(41);
        }

        private void Btn4ID_Click(object sender, EventArgs e)
        {
            fChange(42);
        }

        private void Btn51_Click(object sender, EventArgs e)
        {
            fChange(51);
        }

        private void Btn52_Click(object sender, EventArgs e)
        {
            fChange(52);
        }

        private void Btn53_Click(object sender, EventArgs e)
        {
            fChange(53);
        }

        private void Btn6Password_Click(object sender, EventArgs e)
        {
            fChange(61);
        }

        private void Btn7Student_Click(object sender, EventArgs e)
        {
            fChange(71);
        }

        private void Btn7Work_Click(object sender, EventArgs e)
        {
            fChange(72);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            fFSave();
        }
    }
}
