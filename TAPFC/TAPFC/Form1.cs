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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnJacobi_Click(object sender, EventArgs e)
        {
            fJacobi _dlg = new fJacobi();
            _dlg.ShowDialog();

        }

        private void BtnHele_Click(object sender, EventArgs e)
        {
            fHele _dlg = new fHele();
            _dlg.ShowDialog();

        }
    }
}
