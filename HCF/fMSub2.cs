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
        private int mnMetals = 91;
        private int mnGases = 12;
        private int mnMetal, mnGas;
        private int mnAmount1;

        private void fReset()
        {
            Random rnd1 = new Random();

            mnMetal = rnd1.Next(1, mnMetals + 1);
            mnGas = rnd1.Next(1, mnGases + 1);

            mnAmount1 = rnd1.Next(100, 1001);

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
            InitializeComponent();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void fMSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
