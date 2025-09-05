// <copyright file="Utilitaires.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe utilitaire contenant des fonctions statiques.
    /// </summary>
    public class Utilitaires
    {
        /// <summary>
        /// Fonction de cryptage d'un message en utilisant un simple chiffrement par substitution.
        /// </summary>
        /// <param name="message">Message à crypter.</param>
        /// <returns>Message crypté.</returns>
        public static string Cryptage(string message)
        {
            string chaineOriginal = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; // 1
            string chaineEncrypte = "cjdgoyhktvxfzelquapwmbsnriCJDGOYHKTVXFZELQUAPWMBSNRI"; // 1
            string newChaineChar = string.Empty; // 1

            for (int i = 0; i < message.Length; i++) // n
            {
                foreach (char lettre in chaineOriginal) // 52
                {
                    if (lettre == message[i]) // 52
                    {
                        newChaineChar += chaineEncrypte[Array.IndexOf(chaineOriginal.ToCharArray(), lettre)]; // 1
                        break; // 1
                    }
                    else if (lettre == chaineOriginal[^1]) // 52
                    {
                        newChaineChar += message[i]; // 1
                        break; // 1
                    }
                }
            }

            return newChaineChar; // 1

            // = 1 + 1 + 1 + n * (52 + 1 + 1 + 52 + 1 + 1) + 1
            // = 3 + 108n + 1
            // = O(n)
        }
    }
}
