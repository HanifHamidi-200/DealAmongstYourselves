﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMERG
{
    public partial class fSub3 : Form
    {
        public fSub3()
        {
            InitializeComponent();
        }

        private void BtnOpen1b_Click(object sender, EventArgs e)
        {
            fGSub1b _dlg = new fGSub1b();
            _dlg.ShowDialog();
        }
    }
}
