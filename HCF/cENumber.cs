using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCF
{
    class cENumber
    {
        private int mnItem;
        private String msFile;

        public int fGet()
        {
            String sLine;

             msFile = "ENumber.txt";

            using (System.IO.StreamReader file = new System.IO.StreamReader(@msFile))
            {

                sLine = file.ReadLine();
                mnItem = Convert.ToInt32(sLine);
                file.Close();
            }
            return mnItem;
        }

        public void fSave(int nNumber)
        {
            mnItem = nNumber;
            msFile = "ENumber.txt";

             using (System.IO.StreamWriter file = new System.IO.StreamWriter(@msFile))
             {

                file.WriteLine(nNumber);
                file.Close();
            }
        }

        
    }
}