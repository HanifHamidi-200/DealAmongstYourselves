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
    public partial class fMSub3 : Form
    {
        private cMDatabase _db = new cMDatabase();
        private cENumber _element = new cENumber();
        private int mnItem;
        private int mnCount;
        private String msElement;

        private void fUpdateDisplay()
        {
            lblPossibility1.Text = msElement + " + H2O";
            lblPossibility2.Text = msElement + " + O2";
            lblPossibility3.Text = msElement + " + HCl";
            lblPossibility4.Text = msElement + " + H2SO4";
            lblPossibility5.Text = msElement + " + NaOH";
        }


        public fMSub3()
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
            }
        }

        private void BtnProperties_Click(object sender, EventArgs e)
        {
            fPSub1 _dlg = new fPSub1();
            _dlg.ShowDialog();
        }

        private void FMSub3_Load(object sender, EventArgs e)
        {
            fUpdateDisplay();
        }
    }
}
