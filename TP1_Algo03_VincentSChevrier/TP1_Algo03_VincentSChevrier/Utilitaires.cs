using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Algo03_VincentSChevrier
{
    public class Utilitaires
    {
        public string Cryptage(string chaineChar)
        {
            string chaineOriginal = "abcdefghijklmnopqrstuvwxyz";
            string chaineEncrypte = "cjdgoyhktvxfzelquapwmbsnri";

            foreach (char lettre in chaineChar)
            {
                for (int i = 0; i > chaineOriginal.Length; i++)
                {
                    if (chaineChar[i] == chaineOriginal[i])
                    {
                        chaineChar[i] == chaineEncrypte[i];
                    }
                }
            }

            return 
        }
    }
}
