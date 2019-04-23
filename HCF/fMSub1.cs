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
    public partial class fMSub1 : Form
    {
        private List<String> _Element = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<bool> _ElementExists = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<String> _combination = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _reactamount = new List<int>{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        private List<int> _reactwithamount = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _possibility1 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility2 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility3 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility4 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility5 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<String> _probability1 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _probability2 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _probability3 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _count = new List<int> { 0, 0, 0, 0 };

        private cMDatabase _db = new cMDatabase();
        private cENumber _element = new cENumber();
        private int mnCount;
        private int nNumber;
        private int mnItem = 0;

        private void fView()
        {
            bool bCondition;
            String sCombination;
            String sAmount1;
            String sAmount2;
            bool bPossibility;

            bCondition = _db.fGetElementUsed(mnItem);
            if (bCondition == false)
            {
                goto endline;
            }

            sCombination = _db.fGetCombination(mnItem);
            sAmount1 = Convert.ToString(_db.fGetAmount1(mnItem));
            sAmount2 = Convert.ToString(_db.fGetAmount2(mnItem));

            lbl4.Text = "combination = " + sCombination;
            lbl56.Text = sAmount1 + "g reacts with " + sAmount2 + "g";

            bPossibility = _db.fGetPossibility1(mnItem);
            if (bPossibility)
            {
                lbl7.Text = "Possibility(H20) = TRUE";
            }
            else
            {
                lbl7.Text = "Possibility(H20) = FALSE";
            }

            bPossibility = _db.fGetPossibility2(mnItem);
            if (bPossibility)
            {
                lbl8.Text = "Possibility(O2) = TRUE";
            }
            else
            {
                lbl8.Text = "Possibility(O2) = FALSE";
            }

            bPossibility = _db.fGetPossibility3(mnItem);
            if (bPossibility)
            {
                lbl9.Text = "Possibility(HCl) = TRUE";
            }
            else
            {
                lbl9.Text = "Possibility(HCl) = FALSE";
            }

            bPossibility = _db.fGetPossibility4(mnItem);
            if (bPossibility)
            {
                lbl10.Text = "Possibility(H2SO4) = TRUE";
            }
            else
            {
                lbl10.Text = "Possibility(H2SO4) = FALSE";
            }

            bPossibility = _db.fGetPossibility5(mnItem);
            if (bPossibility)
            {
                lbl11.Text = "Possibility(NaOH) = TRUE";
            }
            else
            {
                lbl11.Text = "Possibility(NaOH) = FALSE";
            }

            lbl12.Text = "Probability(FeasilityStudy) = " + _db.fGetProbability1(mnItem);
            lbl13.Text = "Probability(Manufacture) = " + _db.fGetProbability2(mnItem);
            lbl14.Text = "Probability(PopularUsage) = " + _db.fGetProbability3(mnItem);

            _element.fSave(mnItem);
        endline:;

        }
        private void fUpdateList()
        {
            String sText;
            bool bCondition;
            
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }
            _count[0] = 0;
            _count[1] = 0;
            _count[2] = 0;
            _count[3] = 0;

            for (int i = 1; i <= mnCount; i++)
            {
                sText = _db.fGetElement(i) + " ";
                nNumber = _db.fGetElementExists(i);
                switch (nNumber)
                {
                    case 2:
                        sText = sText + "N/A";
                        _count[1]++;
                        break;
                    case 3:
                        sText = sText + "gas";
                        _count[0]++;
                        break;
                    default:
                        _count[2]++;
                        break;
                }
                lst1.Items.Add(sText);
            }
            for (int i = 1; i <= mnCount; i++)
            {
                sText = _db.fGetElement(i) + " ";
                bCondition = _db.fGetElementUsed(i);
                if (bCondition == true)
                {
                    sText = sText + "- true";
                    _count[3]++;
                }
                else
                {
                    sText = sText + "- false";
                }
                lst2.Items.Add(sText);
            }

            lblCount1.Text = "gas = " + Convert.ToString(_count[0]);
            lblCount2.Text = "N/A = " + Convert.ToString(_count[1]);
            lblCount3.Text = "metal = " + Convert.ToString(_count[2]);
            lblCount4.Text = "TRUE = " + Convert.ToString(_count[3]);

        }
        public fMSub1()
        {
            bool bError;

            InitializeComponent();
            bError=_db.fFLoad();
            if (bError)
            {
                MessageBox.Show("There was an error reading the File", "Error!");
            }
            else
            {
                mnCount = _db.fGetCount();
            }
        }

        private void FMSub1_Load(object sender, EventArgs e)
        {
            fUpdateList();
        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fUpdateList();
        }

        private void Lst2_Click(object sender, EventArgs e)
        {
            mnItem = lst2.SelectedIndex + 1;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            fView();
        }
    }
}
