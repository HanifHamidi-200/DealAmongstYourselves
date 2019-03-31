using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMIEM2
{
    public partial class fSub3 : Form
    {
        private int mnMax, mnMin,mnCount;
        private List<int> _numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private String msFile;
        private int mnItem;

        private void fCopy()
        {
            String sText = null;

            for (int i = 1; i <= mnCount; i++)
            {
                sText = sText + lst1.Items[i - 1] + " ";
            }
            Clipboard.SetText(sText);

        }
        private void fEdit()
        {
            _numbers[mnItem - 1] = Convert.ToInt32(txtEdit.Text);
            fUpdateDisplay();
        }
        private void fFSave()
        {

            msFile = txtFile.Text;
            mnItem = 1;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@msFile))
            {

                file.WriteLine("LIST");
                file.WriteLine(Convert.ToString(mnCount));
                for (int i = 1; i <= mnCount; i++)
                {
                    file.WriteLine(_numbers[i - 1]);
                }
                file.WriteLine("END");
                file.Close();
            }

        }

        private void fFLoad()
        {
            String sLine;

            msFile = txtFile.Text;
            mnItem = 1;

            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@msFile))
                {

                    sLine = file.ReadLine();
                    sLine = file.ReadLine();
                    mnCount = Convert.ToInt32(sLine);
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        _numbers[i - 1] = Convert.ToInt32(sLine);
                    }
                    file.Close();
                    fUpdateDisplay();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();

            mnItem = 1;

            mnMax = Convert.ToInt32(txtNumbers.Text);
            if (mnMax > 200)
            {
                mnMax = 200;
            }
            mnMin = mnMax / 2;
            mnCount = rnd1.Next(mnMin, mnMax + 1);

            for(int i = 1; i <= mnCount; i++)
            {
                _numbers[i - 1] = rnd1.Next(1, 201);
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for(int i = 1; i <= mnCount; i++)
            {
                sText = "[" + Convert.ToString(i) + "] " + Convert.ToString(_numbers[i - 1]);
                lst1.Items.Add(sText);
            }

        }

        private void BtnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            fFSave();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            fFLoad();
        }

        private void Lst1_Click(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            fEdit();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            fCopy();
        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void FSub3_Load(object sender, EventArgs e)
        {
            txtNumbers.Text = "100";
            fReset();
        }
    }
}
