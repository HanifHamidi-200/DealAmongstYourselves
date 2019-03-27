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
    public partial class fSub1 : Form
    {
        private List<String> _metals = new List<String> { "Li","Be","Na","Mg","Al", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Cs", "Ba", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Fr", "Ra", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Nh", "Fl", "Mc", "Lv", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr" };
        private List<String> _metals2 = new List<String> { "1+", "2+", "1+", "2+", "3+", "1+", "2+", "2+", "2+", "2+", "1+", "2+", "2+", "2+", "2+", "1+", "2+", "3+", "1+", "2+", "2+", "2+", "1+", "1+", "2+", "1+", "1+", "18+", "1+", "2+", "3+", "4+", "1+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "1+", "1+", "2+", "3+", "4+", "5+", "1+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "3+", "4+", "5+", "6+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "2+", "3+" };
        private List<String> _gases = new List<String> { "C", "N", "O","F","P","S","Cl","Se", "Br", "I", "At", "Ts" };
        private List<String> _gases2 = new List<String> { "4-", "3-", "2-","1-","3-","2-","1-","2-", "1-", "1-", "1-", "1-" };
        private int mnMetals = 91;
        private int mnGases = 12;
        private int mnMetal, mnGas;

        private void fReset()
        {
            Random rnd1 = new Random();

            mnMetal = rnd1.Next(1, mnMetals + 1);
            mnGas = rnd1.Next(1, mnGases + 1);

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText;

            sText = _metals[mnMetal - 1] + " charge =";
            lbl1.Text = sText;
            sText = _metals2[mnMetal - 1];
            txt1.Text = sText;
            sText = _gases[mnGas - 1] + " charge =";
            lbl2.Text = sText;
            sText = _gases2[mnGas - 1];
            txt2.Text = sText;
            lbl3.Text = "ResultantChemicalEquation =";
            txt3.Text = null;

        }
        public fSub1()
        {
            InitializeComponent();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void FSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
