using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEURSK
{
    public partial class Form1 : Form
    {
        private List<String> _col1 = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null, null, null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null };
        private int mnItem;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 9; i++)
            {
                _col1[i - 1] = Convert.ToString(rnd1.Next(1, 401));
                _col2[i - 1] = Convert.ToString(rnd1.Next(1, 401));
                _col3[i - 1] = Convert.ToString(rnd1.Next(1, 401));
            }
            for (int i = 1; i <= 3; i++)
            {
                _col4[i - 1] = Convert.ToString(rnd1.Next(1, 401));
            }

            mnItem = rnd1.Next(1, 4);
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            switch (mnItem)
            {
                case 1:
                    txta1.Text = _col1[0];
                    txta2.Text = _col1[1];
                    txta3.Text = _col1[2];
                    txta4.Text = _col1[3];
                    txta5.Text = _col1[4];
                    txta6.Text = _col1[5];
                    txta7.Text = _col1[6];
                    txta8.Text = _col1[7];
                    txta9.Text = _col1[8];
                    break;
                case 2:
                    txta1.Text = _col2[0];
                    txta2.Text = _col2[1];
                    txta3.Text = _col2[2];
                    txta4.Text = _col2[3];
                    txta5.Text = _col2[4];
                    txta6.Text = _col2[5];
                    txta7.Text = _col2[6];
                    txta8.Text = _col2[7];
                    txta9.Text = _col2[8];
                    break;
                default:
                    txta1.Text = _col3[0];
                    txta2.Text = _col3[1];
                    txta3.Text = _col3[2];
                    txta4.Text = _col3[3];
                    txta5.Text = _col3[4];
                    txta6.Text = _col3[5];
                    txta7.Text = _col3[6];
                    txta8.Text = _col3[7];
                    txta9.Text = _col3[8];
                    break;
            }

            txtb1.Text = _col4[0];
            txtb2.Text = _col4[1];
            txtb3.Text = _col4[2];

        }

        private void fSave()
        {
            switch (mnItem)
            {
                case 1:
                    _col1[0] = txta1.Text;
                    _col1[1] = txta2.Text;
                    _col1[2] = txta3.Text;
                    _col1[3] = txta4.Text;
                    _col1[4] = txta5.Text;
                    _col1[5] = txta6.Text;
                    _col1[6] = txta7.Text;
                    _col1[7] = txta8.Text;
                    _col1[8] = txta9.Text;
                    break;
                case 2:
                    _col2[0] = txta1.Text;
                    _col2[1] = txta2.Text;
                    _col2[2] = txta3.Text;
                    _col2[3] = txta4.Text;
                    _col2[4] = txta5.Text;
                    _col2[5] = txta6.Text;
                    _col2[6] = txta7.Text;
                    _col2[7] = txta8.Text;
                    _col2[8] = txta9.Text;
                    break;
                default:
                    _col3[0] = txta1.Text;
                    _col3[1] = txta2.Text;
                    _col3[2] = txta3.Text;
                    _col3[3] = txta4.Text;
                    _col3[4] = txta5.Text;
                    _col3[5] = txta6.Text;
                    _col3[6] = txta7.Text;
                    _col3[7] = txta8.Text;
                    _col3[8] = txta9.Text;
                    break;
            }

            _col4[0] = txtb1.Text;
            _col4[1] = txtb2.Text;
            _col4[2] = txtb3.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst1_Click(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
            fUpdateDisplay();
        }
    }
}
