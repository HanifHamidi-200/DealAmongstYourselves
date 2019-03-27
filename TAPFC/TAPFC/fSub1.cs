using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPFC
{
    public partial class fSub1 : Form
    {
        private int mnMode;
        private List<String> _col1 = new List<string> { null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null, null };

        private void fSave()
        {
            switch (mnMode)
            {
                case 1:
                    _col1[0] = txt1.Text;
                    _col1[1] = txt2.Text;
                    _col1[2] = txt3.Text;
                    _col1[3] = txt4.Text;
                    break;
                case 2:
                    _col2[0] = txt1.Text;
                    _col2[1] = txt2.Text;
                    _col2[2] = txt3.Text;
                    _col2[3] = txt4.Text;
                    break;
                default:
                    _col3[0] = txt1.Text;
                    _col3[1] = txt2.Text;
                    _col3[2] = txt3.Text;
                    _col3[3] = txt4.Text;
                    break;
            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nValue;

            for (int i = 1; i <= 3; i++)
            {
                nValue = rnd1.Next(1, 201);
                _col1[i - 1] = Convert.ToString(nValue);
            }
            _col1[3] = null;

            for (int i = 1; i <= 3; i++)
            {
                nValue = rnd1.Next(1, 201);
                _col2[i - 1] = Convert.ToString(nValue);
            }
            _col2[3] = null;

            for (int i = 1; i <= 3; i++)
            {
                nValue = rnd1.Next(1, 201);
                _col3[i - 1] = Convert.ToString(nValue);
            }
            _col3[3] = null;

            mnMode = rnd1.Next(1, 4);

            fUpdateDisplay();
        }


        private void fUpdateDisplay()
        {
            switch (mnMode)
            {
                case 1:
                    fra1.Text = "Construction";
                    txt1.Text = _col1[0];
                    txt2.Text = _col1[1];
                    txt3.Text = _col1[2];
                    txt4.Text = _col1[3];
                    break;
                case 2:
                    fra1.Text = "Farming";
                    txt1.Text = _col2[0];
                    txt2.Text = _col2[1];
                    txt3.Text = _col2[2];
                    txt4.Text = _col2[3];
                    break;
                default:
                    fra1.Text = "Mining";
                    txt1.Text = _col3[0];
                    txt2.Text = _col3[1];
                    txt3.Text = _col3[2];
                    txt4.Text = _col3[3];
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }
    }
}
