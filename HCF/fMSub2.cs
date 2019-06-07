using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCF
{
    public partial class fMSub2 : Form
    {
        private List<String> _metals = new List<String> { "Li", "Be", "Na", "Mg", "Al", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Cs", "Ba", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Fr", "Ra", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Nh", "Fl", "Mc", "Lv", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr" };
        private List<String> _metals2 = new List<String> { "1+", "2+", "1+", "2+", "3+", "1+", "2+", "2+", "2+", "2+", "1+", "2+", "2+", "2+", "2+", "1+", "2+", "3+", "1+", "2+", "2+", "2+", "1+", "1+", "2+", "1+", "1+", "18+", "1+", "2+", "3+", "4+", "1+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "1+", "1+", "2+", "3+", "4+", "5+", "1+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "3+", "4+", "5+", "6+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "3+" };
        private List<String> _metals3 = new List<String> { "3Li7", "4Be9", "11Na23", "12Mg24", "13Al27", "19K39", "20Ca40", "21Sc45", "22Ti48", "23V51", "24Cr52", "25Mn55", "26Fe56", "27Co59", "28Ni59", "29Cu64", "30Zn65", "31Ga70", "37Rb85", "38Sr88", "39Y89", "40Zr91", "41Nb93", "42Mo96", "43Tc98", "44Ru101", "45Rh103", "46Pd107", "47Ag108", "48Cd112", "49In115", "50Sn119", "55Cs133", "56Ba137", "72Hf178", "73Ta181", "74W184", "75Re186", "76Os190", "77Ir192", "78Pt195", "79Au197", "80Hg201", "81Tl204", "82Pb207", "83Bi209", "87Fr223", "88Ra226", "104Rf267", "105Db268", "106Sg269", "107Bh270", "108Hs269", "109Mt278", "110Ds281", "111Rg281", "112Cn285", "113Nh286", "114Fl289", "115Mc288", "116Lv293", "57La139", "58Ce140", "59Pr141", "60Nd144", "61Pm145", "62Sm150", "63Eu152", "64Gd157", "65Tb159", "66Dy163", "67Ho165", "68Er167", "69Tm169", "70Yb173", "71Lu175", "89Ac227", "90Th232", "91Pa231", "92U238", "93Np237", "94Pu244", "95Am243", "96Cm247", "97Bk247", "98Cf251", "99Es252", "100Fm257", "101Md258", "102No259", "103Lr262" };
        private List<String> _gases = new List<String> { "C", "N", "O", "F", "P", "S", "Cl", "Se", "Br", "I", "At", "Ts" };
        private List<String> _gases2 = new List<String> { "4-", "3-", "2-", "1-", "3-", "2-", "1-", "2-", "1-", "1-", "1-", "1-" };
        private List<String> _gases3 = new List<String> { "6C12", "7N14", "8O16", "9F19", "15P31", "16S32", "17Cl35", "34Se79", "35Br80", "53I127", "85At210", "117Ts294" };
        private List<int> _signage = new List<int> { 3, 4, 11, 12, 13, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118 };
        private int mnMetals = 91;
        private int mnGases = 12;
        private int mnMetal, mnGas;
        private int mnAmount1;

        private cMDatabase _db = new cMDatabase();
        private cENumber _element = new cENumber();
        private int mnItem;
        private int mnCount;
        private String msElement;
        private int mnMode;
        private bool mbPrecise;
        private int nNumber;
        private bool mbMExists;
        private int mnCalc = 1;

        private int fSignage(int nNumber)
        {
            int nPos = 0;
            bool bFound = false;

            do
            {
                nPos++;
                if (nNumber == _signage[nPos - 1])
                {
                    bFound = true;
                }
            } while (bFound == false);

            return nPos;
        }

        private void fAnswer(int nMode)
        {
            double d1, d2,d3,dAnswer;
            Single nAnswer2;

            switch (nMode)
            {
                case 1:
                    d1 = Convert.ToDouble(txtCalc11.Text);
                    dAnswer = 7.2264E24 / d1;
                    txtAnswer1.Text = Convert.ToString(dAnswer);
                    break;
                case 2:
                    d1 = Convert.ToDouble(txtCalc21.Text);
                    d2 = Convert.ToDouble(txtCalc22.Text);
                    dAnswer = d1 / d2;
                    txtAnswer2.Text = Convert.ToString(dAnswer);
                    break;
                case 3:
                    d1 = Convert.ToDouble(txtCalc31.Text);
                    nAnswer2 = Convert.ToSingle(d1/6.022E23);
                    txtAnswer3.Text = Convert.ToString(nAnswer2);
                    break;
                case 4:
                    d1 = Convert.ToDouble(txtCalc41.Text);
                    dAnswer = d1 * 12;
                    txtAnswer4.Text = Convert.ToString(dAnswer);
                    break;
                case 5:
                    d1 = Convert.ToDouble(txtCalc51.Text);
                    d2 = Convert.ToDouble(txtCalc52.Text);
                    dAnswer = d1 / d2;
                    txtAnswer5.Text = Convert.ToString(dAnswer);
                    break;
                default:
                    d1 = Convert.ToDouble(txtCalc61.Text);
                    d2 = Convert.ToDouble(txtCalc62.Text);
                    d3 = Convert.ToDouble(txtCalc63.Text);
                    dAnswer = d1 * d2 * d3;
                    txtAnswer6.Text = Convert.ToString(dAnswer);
                    break;
            }
        }
        private void fShowCalc(int nMode)
        {
            fraCalc1.Visible = false;
            fraCalc2.Visible = false;
            fraCalc3.Visible = false;
            fraCalc4.Visible = false;
            fraCalc5.Visible = false;
            fraCalc6.Visible = false;

            mnCalc = nMode;

            switch (nMode)
            {
                case 1:
                    fraCalc1.Visible = true;
                    break;
                case 2:
                    fraCalc2.Visible = true;
                    break;
                case 3:
                    fraCalc3.Visible = true;
                    break;
                case 4:
                    fraCalc4.Visible = true;
                    break;
                case 5:
                    fraCalc5.Visible = true;
                    break;
                default:
                    fraCalc6.Visible = true;
                    break;
            }
        }
        private void fItemNumber()
        {
            String sMetal = _metals[mnMetal - 1];
            String sText;

            mnItem = 0;
            for(int i = 1; i <= mnCount; i++)
            {
                sText = _db.fGetElement(i);
                if (sMetal == sText)
                {
                    mnItem = i;
                    goto endline;
                }
            }

        endline:;
            mbMExists = _db.fGetElementUsed(mnItem);
            if (mbMExists)
            {
                lblMExists.Text = "MetalExists = TRUE";
            }
            else
            {
                lblMExists.Text = "MetalExists = FALSE";
            }
        }

        private void fSave()
        {
            String sCombination = txt3.Text;
            String sAmount1 = Convert.ToString(mnAmount1);
            String sAmount2 = txt6.Text;

            _db.fSaveElement(mnItem, sCombination, sAmount1, sAmount2);
            _db.fFSave();
        }

        private void fClearScreen()
        {
            txtScreen1.Text = "12 x 6.022 x 10 ^23" + Convert.ToChar(13) + "7.2264 x 10 ^ 24" + Convert.ToChar(13) + "Ihave[] mass";
            txtScreen2.Text = "butthere are [] ofthem";
            txtScreen3.Text = "[]/6.022 x 10 ^23" + Convert.ToChar(13) + "= %";
            txtScreen4.Text = "Ihad []g";
            txtScreen5.Text = "12 x 6.022 x 10 ^23" + Convert.ToChar(13) + "= 7.2264 x 10 ^ 24" + Convert.ToChar(13) + "Ihave[] mass";
            txtScreen6.Text = "butthere are [] ofthem";
            txtScreen7.Text = "[]/6.022 x 10 ^23" + Convert.ToChar(13) + "= %";
            txtScreen8.Text = "Ihad[] x[] such combinations";
        }
        private void fReset()
        {
            Random rnd1 = new Random();

            mnMetal = rnd1.Next(1, mnMetals + 1);
            mnGas = rnd1.Next(1, mnGases + 1);
            fra1.Visible = true;

            mnAmount1 = rnd1.Next(100, 1001);

            fItemNumber();
            fUpdateDisplay();
            fClearScreen();
        }
        private void fReset2()
        {
            Random rnd1 = new Random();

            mnMetal = fSignage(mnItem);
            mnGas = mnMode;
            fra1.Visible = false;

            mnAmount1 = rnd1.Next(100, 1001);

            fItemNumber();
            fUpdateDisplay();
            fClearScreen();
        }

        private void fSelect()
        {
            Random rnd1 = new Random();
            String sElement = txtSelect.Text;

            mnMetal = 0;
            for(int i = 1; i <= _metals.Count(); i++)
            {
                if (sElement == _metals[i - 1])
                {
                    mnMetal = i;
                }
            }
            if (mnMetal == 0)
            {
                mnMetal = rnd1.Next(1, mnMetals + 1);
            }
            mnGas = rnd1.Next(1, mnGases + 1);

            mnAmount1 = rnd1.Next(100, 1001);

            fItemNumber();
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText;

            sText = Convert.ToString(mnAmount1) + "g of " + _metals[mnMetal - 1] + " reacts with " + _gases[mnGas - 1];
            lblReaction.Text = sText;

            sText = _metals[mnMetal - 1] + " charge =";
            lbl1.Text = sText;
            sText = _metals2[mnMetal - 1];
            txt1.Text = sText;
            sText = _gases[mnGas - 1] + " charge =";
            lbl2.Text = sText;
            sText = _gases2[mnGas - 1];
            txt2.Text = sText;
            lbl3.Text = "OverallFormula =";
            txt3.Text = null;

            sText = _metals[mnMetal - 1] + " formula =";
            lbl4.Text = sText;
            sText = _metals3[mnMetal - 1];
            txt4.Text = sText;
            sText = _gases[mnGas - 1] + " formula =";
            lbl5.Text = sText;
            sText = _gases3[mnGas - 1];
            txt5.Text = sText;

        }
        public fMSub2()
        {
            bool bError;

            InitializeComponent();
            bError = _db.fFLoad();
            if (bError)
            {
                MessageBox.Show("There was an error reading the File", "Error!");
            }
            else
            {
                mnCount = _db.fGetCount();
                mnItem = _element.fGet();
                msElement = _db.fGetCombination(mnItem);
                mnMode = _element.fGetMode();
                mbPrecise = _element.fGetPrecise();
            }
        }
    

    private void BtnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            fSelect();
        }

        private void BtnQNext_Click_1(object sender, EventArgs e)
        {
            fReset();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtGo12.Text = txtGo11.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtGo22.Text = txtGo21.Text + "(" + txt3.Text + ")";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtGo32.Text = txtGo31.Text;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNull1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtGo22_TextChanged(object sender, EventArgs e)
        {

        }

        private void LstCalc_Click(object sender, EventArgs e)
        {
            fShowCalc(lstCalc.SelectedIndex + 1);
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            fAnswer(mnCalc);
        }

        private void fMSub2_Load(object sender, EventArgs e)
        {
            fraCalc2.Left = fraCalc1.Left;
            fraCalc2.Top = fraCalc1.Top;
            fraCalc3.Left = fraCalc1.Left;
            fraCalc3.Top = fraCalc1.Top;
            fraCalc4.Left = fraCalc1.Left;
            fraCalc4.Top = fraCalc1.Top;
            fraCalc5.Left = fraCalc1.Left;
            fraCalc5.Top = fraCalc1.Top;
            fraCalc6.Left = fraCalc1.Left;
            fraCalc6.Top = fraCalc1.Top;
            fShowCalc(1);
            if (mbPrecise)
            {
                fReset2();
            }
            else
            {
                fReset();
            }
        }
    }
}
