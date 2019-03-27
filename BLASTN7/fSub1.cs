using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLASTN7
{
    public partial class fSub1 : Form
    {
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount;

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
            if (lst3.Items.Count > 0)
            {
                do
                {
                    lst3.Items.RemoveAt(0);
                } while (lst3.Items.Count > 0);
            }

            nCount = rnd1.Next(1, 11);
            for (int i = 1; i <= nCount; i++)
            {
                nNumber = rnd1.Next(1, 101);
                lst1.Items.Add(Convert.ToString(nNumber));
            }
            nCount = rnd1.Next(1, 11);
            for (int i = 1; i <= nCount; i++)
            {
                nNumber = rnd1.Next(1, 101);
                lst2.Items.Add(Convert.ToString(nNumber));
            }
            nCount = rnd1.Next(1, 11);
            for (int i = 1; i <= nCount; i++)
            {
                nNumber = rnd1.Next(1, 101);
                lst3.Items.Add(Convert.ToString(nNumber));
            }
            txtPlant1.Text = null;
            txtPlant2.Text = null;
            txtPlant3.Text = null;
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;
            txt5.Text = null;
            txt6.Text = null;
            txt7.Text = null;
            txt8.Text = null;
            txt9.Text = null;
            txt10.Text = null;

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
    }
}
