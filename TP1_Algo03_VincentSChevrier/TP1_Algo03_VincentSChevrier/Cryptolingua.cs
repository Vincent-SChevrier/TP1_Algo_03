// <copyright file="Cryptolingua.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe représentant une Cryptolingua, une créature qui peut se déplacer et parler en cryptant son message.
    /// </summary>
    public class Cryptolingua : Creature, IParler
    {
        /// <summary>
        /// Constructeur de la Cryptolingua.
        /// </summary>
        /// <param name="positionX">Position sur l'axe des X de la Cryptolingua.</param>
        /// <param name="positionY">Position sur l'axe des Y de la Cryptolingua.</param>
        public Cryptolingua(int positionX, int positionY) : base("Cryptolingua", positionX, positionY, 3)
        {
        }

        /// <summary>
        /// Fonction qui fait parler la Cryptolingua en cryptant le message avant de l'afficher.
        /// </summary>
        /// <param name="message">Message à dire.</param>
        public void Parler(string message)
        {
            Console.WriteLine($"Cryptolingua dit : {Utilitaires.Cryptage(message)}");
        }
    }
}
