using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CryptBox
{
    class CheckingUtils
    {
        public static bool checkAllFiles(String[] args)
        {
            String[] files = args[2].Split(';');
            String[] hashs = args[3].Split(';');
            bool worked = true;
            for (int i = 0; i < files.Length; i++)
            {
                String f = files[i];
                String h = hashs[i];
                byte[] fh = System.Security.Cryptography.SHA256.Create().ComputeHash(System.IO.File.Open(f, System.IO.FileMode.Open));
                if (h == fh.ToString())
                {
                    
                }
                else
                {
                    worked = false;
                }
            }
            return worked;


        }
       
    }
    
}
