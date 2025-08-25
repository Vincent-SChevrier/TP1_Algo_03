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
            string newChaineChar = "";

            for (int i = 0; i > chaineChar.Length; i++)
            {
                foreach(char lettre in chaineOriginal)
                {
                    if (lettre == chaineChar[i])
                    {
                        newChaineChar += (chaineEncrypte[chaineOriginal.IndexOf(lettre)]);
                    }
                }
            }

            return newChaineChar;
        }
    }
}
