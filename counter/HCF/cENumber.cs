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
        private int mnMode;
        private bool mbPrecise;
        private String msFile;

        public int fGet()
        {
            String sLine;

             msFile = "ENumber.txt";

            using (System.IO.StreamReader file = new System.IO.StreamReader(@msFile))
            {

                sLine = file.ReadLine();
                mnItem = Convert.ToInt32(sLine);
                sLine = file.ReadLine();
                mnMode = Convert.ToInt32(sLine);
                sLine = file.ReadLine();
                if (sLine == "TRUE")
                {
                    mbPrecise = true;
                }
                else
                {
                    mbPrecise = false;
                }
                file.Close();
            }
            return mnItem;
        }

        public int fGetMode()
        {
            return mnMode;
        }

        public bool fGetPrecise()
        {
            return mbPrecise;
        }

        public void fSave(int nNumber1,int nNumber2,bool bSwitch)
        {
            mnItem = nNumber1;
            mnMode = nNumber2;
            mbPrecise = bSwitch;
            msFile = "ENumber.txt";

             using (System.IO.StreamWriter file = new System.IO.StreamWriter(@msFile))
             {

                file.WriteLine(mnItem);
                file.WriteLine(mnMode);
                if (mbPrecise)
                {
                    file.WriteLine("TRUE");
                }
                else
                {
                    file.WriteLine("FALS");
                }
                file.Close();
            }
        }

        
    }
}