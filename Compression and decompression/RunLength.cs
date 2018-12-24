using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compression_and_decompression
{
    class RunLength
    {
        public string filePath { get; set; }
        public string fileStr { get; set; }
        public string outStr {  get; set; }
        public int strCont = 1;
       

        public string Encode(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            

            while ((fileStr = sr.ReadLine()) != null)
            {
                fileStr = fileStr + " ";
                for (int i = 0; i < fileStr.Length-1; i++)
                {
                    if (fileStr[i] == fileStr[i +1])
                    {
                        strCont++;
                    }
                   
                    else
                    {
                        outStr += strCont;
                        outStr += fileStr[i]; 
                        strCont = 1;
                    }
                }
            }

            return outStr;

        }

        public string Decode(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            while ((fileStr = sr.ReadLine()) != null)
            {
                string ccount = string.Empty;
                for (int i = 0; i < fileStr.Length; i++)
                {
                    if ("1234567890".Contains(fileStr[i]))
                    {
                        ccount += fileStr[i];

                    }
                    else
                    {
                        outStr += new string(fileStr[i], int.Parse(ccount));
                        ccount = "";
                            
                    }
                }

            }
            return outStr;
        }
    }
}
