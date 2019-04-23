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

        private void fSave()
        {
            String sText;
            String s1 = txtProbability1.Text;
            String s2 = txtProbability2.Text;
            String s3 = txtProbability3.Text;
            bool b1, b2, b3, b4, b5;

            sText = txtPossibility1.Text;
            if (sText.ToUpper() == "TRUE")
            {
                b1 = true;
            }
            else
            {
                b1 = false;
            }
            sText = txtPossibility2.Text;
            if (sText.ToUpper() == "TRUE")
            {
                b2 = true;
            }
            else
            {
                b2 = false;
            }
            sText = txtPossibility3.Text;
            if (sText.ToUpper() == "TRUE")
            {
                b3 = true;
            }
            else
            {
                b3 = false;
            }
            sText = txtPossibility4.Text;
            if (sText.ToUpper() == "TRUE")
            {
                b4 = true;
            }
            else
            {
                b4 = false;
            }
            sText = txtPossibility5.Text;
            if (sText.ToUpper() == "TRUE")
            {
                b5 = true;
            }
            else
            {
                b5 = false;
            }

            _db.fSaveElement2(mnItem, b1, b2, b3, b4, b5);
            _db.fSaveElement3(mnItem, s1, s2, s3);
            _db.fFSave();

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
            fPSub2 _dlg = new fPSub2();
            _dlg.ShowDialog();
        }

        private void FMSub3_Load(object sender, EventArgs e)
        {
            fUpdateDisplay();
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fPSub1 _dlg = new fPSub1();
            _dlg.ShowDialog();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }
    }
}
