using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLSHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            fSub4 _dlg = new fSub4();
            _dlg.ShowDialog();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            fSub5 _dlg = new fSub5();
               _dlg.ShowDialog();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fSub6 _dlg = new fSub6();
            _dlg.ShowDialog();


        }

        private void BtnOpen11_Click(object sender, EventArgs e)
        {
            fSub11 _dlg = new fSub11();
            _dlg.ShowDialog();

        }

        private void BtnOpen10_Click(object sender, EventArgs e)
        {
            fSub10 _dlg = new fSub10();
            _dlg.ShowDialog();

        }

        private void BtnOpen9_Click(object sender, EventArgs e)
        {
            fSub9 _dlg = new fSub9();
            _dlg.ShowDialog();

        }

        private void BtnOpen8_Click(object sender, EventArgs e)
        {
            fSub8 _dlg = new fSub8();
            _dlg.ShowDialog();

        }

        private void BtnOpen7_Click(object sender, EventArgs e)
        {
            fSub7 _dlg = new fSub7();
            _dlg.ShowDialog();

        }
    }
}
