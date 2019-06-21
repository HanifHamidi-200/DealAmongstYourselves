using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARBC800
{
    public partial class fShow : Form
    {
        private void fUpdateList()
        {
            String sName = "Data.txt";
            String sLine;

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

           
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    do
                    {
                        sLine = sr.ReadLine();
                        lst1.Items.Add(sLine);
                    } while (sr.EndOfStream != true);
                    sr.Close();
                }


            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

            sName = "Data2.txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    do
                    {
                        sLine = sr.ReadLine();
                        lst2.Items.Add(sLine);
                    } while (sr.EndOfStream != true);
                    sr.Close();
                }


            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

            sName = "Data3.txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    do
                    {
                        sLine = sr.ReadLine();
                        lst3.Items.Add(sLine);
                    } while (sr.EndOfStream != true);
                    sr.Close();
                }


            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

            sName = "Data4.txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    do
                    {
                        sLine = sr.ReadLine();
                        lst4.Items.Add(sLine);
                    } while (sr.EndOfStream != true);
                    sr.Close();
                }


            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

        }
        public fShow()
        {
            InitializeComponent();
        }

        private void fShow_Load(object sender, EventArgs e)
        {
            fUpdateList();
        }
    }
}
