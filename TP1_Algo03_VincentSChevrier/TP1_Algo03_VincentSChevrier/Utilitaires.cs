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
            string chaineOriginal = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chaineEncrypte = "cjdgoyhktvxfzelquapwmbsnriCJDGOYHKTVXFZELQUAPWMBSNRI";
            string newChaineChar = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                foreach (char lettre in chaineOriginal)
                {
                    if (lettre == message[i])
                    {
                        newChaineChar += chaineEncrypte[Array.IndexOf(chaineOriginal.ToCharArray(), lettre)];
                        break;
                    }
                    else if (lettre == chaineOriginal[^1])
                    {
                        newChaineChar += message[i];
                        break;
                    }
                }
            }

            return newChaineChar;
        }
    }
}
