using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCF
{
    class cMDatabase
    {
        private List<String> _Element = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _ElementsType = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _ElementUsed = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<String> _combination = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _reactamount = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _reactwithamount = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<bool> _possibility1 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility2 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility3 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility4 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<bool> _possibility5 = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        private List<String> _probability1 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _probability2 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _probability3 = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int mnCount;
        private String msFile;

        public void fFSave()
        {
            String sLine;

            msFile = "Data.txt";
         
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@msFile))
            {

                file.WriteLine("ElementsMetal");
                sLine = Convert.ToString(mnCount);
                file.WriteLine(sLine);
                for (int i = 1; i <= mnCount; i++)
                {
                    file.WriteLine(_Element[i - 1]);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    sLine = Convert.ToString(_ElementsType[i-1]);
                    file.WriteLine(sLine);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    if (_ElementUsed[i - 1])
                    {
                        file.WriteLine("TRUE");
                    }
                    else
                    {
                        file.WriteLine("FALS");
                    }
                }
                for (int i = 1; i <= mnCount; i++)
                {
                      file.WriteLine(_combination[i - 1]);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    sLine = Convert.ToString(_reactamount[i-1]);
                    file.WriteLine(sLine);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    sLine = Convert.ToString(_reactwithamount[i-1]);
                    file.WriteLine(sLine);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    if (_possibility1[i - 1])
                    {
                        file.WriteLine("TRUE");
                    }
                    else
                    {
                        file.WriteLine("FALS");
                    }
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    if (_possibility2[i - 1])
                    {
                        file.WriteLine("TRUE");
                    }
                    else
                    {
                        file.WriteLine("FALS");
                    }
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    if (_possibility3[i - 1])
                    {
                        file.WriteLine("TRUE");
                    }
                    else
                    {
                        file.WriteLine("FALS");
                    }
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    if (_possibility4[i - 1])
                    {
                        file.WriteLine("TRUE");
                    }
                    else
                    {
                        file.WriteLine("FALS");
                    }
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    if (_possibility5[i - 1])
                    {
                        file.WriteLine("TRUE");
                    }
                    else
                    {
                        file.WriteLine("FALS");
                    }
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    file.WriteLine(_probability1);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    file.WriteLine(_probability2);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    file.WriteLine(_probability3);
                }
                file.WriteLine("END");
                file.Close();

            }


        }

        public bool fFLoad()
        {
            String sLine;

            msFile = "Data.txt";
      
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@msFile))
                {

                    sLine = file.ReadLine();
                    sLine = file.ReadLine();
                    mnCount = Convert.ToInt32(sLine);
                    for (int i = 1; i <= mnCount; i++)
                    {
                        _Element[i - 1] = file.ReadLine();
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        _ElementsType[i-1] = Convert.ToInt32(sLine);
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        if (sLine == "TRUE")
                        {
                            _ElementUsed[i - 1] = true;
                        }
                        else
                        {
                            _ElementUsed[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        _combination[i - 1] = file.ReadLine();
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        _reactamount[i - 1] = Convert.ToInt32(sLine);
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        _reactwithamount[i - 1] = Convert.ToInt32(sLine);
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        if (sLine == "TRUE")
                        {
                            _possibility1[i - 1] = true;
                        }
                        else
                        {
                            _possibility1[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        if (sLine == "TRUE")
                        {
                            _possibility2[i - 1] = true;
                        }
                        else
                        {
                            _possibility2[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        if (sLine == "TRUE")
                        {
                            _possibility3[i - 1] = true;
                        }
                        else
                        {
                            _possibility3[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        if (sLine == "TRUE")
                        {
                            _possibility4[i - 1] = true;
                        }
                        else
                        {
                            _possibility4[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        sLine = file.ReadLine();
                        if (sLine == "TRUE")
                        {
                            _possibility5[i - 1] = true;
                        }
                        else
                        {
                            _possibility5[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        _probability1[i - 1] = file.ReadLine();
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        _probability2[i - 1] = file.ReadLine();
                    }
                    for (int i = 1; i <= mnCount; i++)
                    {
                        _probability3[i - 1] = file.ReadLine();
                    }
                    file.Close();
                }
                
            }
            catch 
            {
                  return true;
            }

            return false;
        }

        public int fGetCount()
        {
            return mnCount;
        }

        public String fGetElement(int nMode)
        {
            return _Element[nMode - 1];
        }

        public int fGetElementExists(int nMode)
        {
            return _ElementsType[nMode - 1];
        }

        public bool fGetElementUsed(int nMode)
        {
            return _ElementUsed[nMode - 1];
        }

        public String fGetCombination(int nMode)
        {
            return _combination[nMode - 1];
        }

        public int fGetAmount1(int nMode)
        {
            return _reactamount[nMode - 1];
        }

        public int fGetAmount2(int nMode)
        {
            return _reactwithamount[nMode - 1];
        }

        public bool fGetPossibility1(int nMode)
        {
            return _possibility1[nMode - 1];
        }

     
        public bool fGetPossibility2(int nMode)
        {
            return _possibility2[nMode - 1];
        }

        public bool fGetPossibility3(int nMode)
        {
            return _possibility3[nMode - 1];
        }

        public bool fGetPossibility4(int nMode)
        {
            return _possibility4[nMode - 1];
        }

        public bool fGetPossibility5(int nMode)
        {
            return _possibility5[nMode - 1];
        }

        public String fGetProbability1 (int nMode)
        {
            return _probability1[nMode - 1];
        }

        public String fGetProbability2(int nMode)
        {
            return _probability2[nMode - 1];
        }

        public String fGetProbability3(int nMode)
        {
            return _probability3[nMode - 1];
        }

        public void fSaveElement(int nMode,String sText1,String sText2,String sText3)
        {
            _ElementUsed[nMode - 1] = true;
            _combination[nMode - 1] = sText1;
            _reactamount[nMode - 1] = Convert.ToInt32(sText2);
            _reactwithamount[nMode - 1] = Convert.ToInt32(sText3);
        }

        public void fSaveElement2(int nMode, bool b1,bool b2,bool b3,bool b4,bool b5)
        {
            _possibility1[nMode - 1] = b1;
            _possibility2[nMode - 1] = b2;
            _possibility3[nMode - 1] = b3;
            _possibility4[nMode - 1] = b4;
            _possibility5[nMode - 1] = b5;
        }

        public void fSaveElement3(int nMode, String s1,String s2,String s3)
        {
            _probability1[nMode - 1] = s1;
            _probability2[nMode - 1] = s2;
            _probability3[nMode - 1] = s3;
        }
    }
}
