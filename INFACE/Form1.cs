using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFACE
{
    public partial class Form1 : Form
    {
        private List<String> _text = new List<string> { "Interfaces", "Namespaces", "PreprocessorDirective", "RegularExpressions", "ExceptionHandling", "FileIO", "Attributes", "Reflection", "Properties", "Indexers", "Delegates", "Events", "Collections", "Generics", "AnonymousMethods", "UnsafeCodes", "Multithreading" };
        private List<String> _usage = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _structure = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _code = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int mnCount = 17;
        private int mnItem;

        private void fShow(int nMode)
        {
            groupBox1.Text = _text[nMode - 1];
            textBox1.Text = _usage[nMode - 1];
            textBox2.Text = _structure[nMode - 1];
            textBox3.Text = _code[nMode - 1];
            mnItem = nMode;
        }

        private void fSave()
        {
            _usage[mnItem - 1]= textBox1.Text;
            _structure[mnItem - 1] = textBox2.Text;
            _code[mnItem - 1]= textBox3.Text;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue = rnd1.Next(1, mnCount + 1);

            fShow(nValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fShow(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fShow(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fShow(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fShow(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fShow(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fShow(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fShow(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fShow(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fShow(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fShow(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fShow(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fShow(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fShow(16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            fShow(17);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }
    }
}
