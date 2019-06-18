using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4LHOUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            fSub7 _dlg = new fSub7();
            _dlg.ShowDialog();

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();
        }

        private void BtnOpen6_Click(object sender, EventArgs e)
        {
            fSub6 _dlg = new fSub6();
            _dlg.ShowDialog();

        }
    }
}
