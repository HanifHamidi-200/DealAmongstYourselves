using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAZERN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void BtnDefine1_Click(object sender, EventArgs e)
        {
            fDefine1 _dlg = new fDefine1();
            _dlg.ShowDialog();

        }

        private void BtnDefine2_Click(object sender, EventArgs e)
        {
            fDefine2 _dlg = new fDefine2();
            _dlg.ShowDialog();

        }

        private void BtnPlay1_Click(object sender, EventArgs e)
        {
            fPlay1 _dlg = new fPlay1();
            _dlg.ShowDialog();

        }

        private void BtnPlay2_Click(object sender, EventArgs e)
        {
            fPlay2 _dlg = new fPlay2();
            _dlg.ShowDialog();

        }
    }
}