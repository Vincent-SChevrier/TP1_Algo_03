// <copyright file="Verbaflora.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe représentant une Verbaflora, une plante qui peut parler.
    /// </summary>
    public class Verbaflora : Plante, IParler
    {
        /// <summary>
        /// Constructeur de la Verbaflora.
        /// </summary>
        /// <param name="positionX">Position sur l'axe des X de la Verbaflora.</param>
        /// <param name="positionY">Position sur l'axe des Y de la Verbaflora.</param>
        public Verbaflora(int positionX, int positionY) : base("Verbaflora", positionX, positionY)
        {

        }

        /// <summary>
        /// Fonction qui fait parler la Verbaflora en affichant le message avec des emojis de plantes.
        /// </summary>
        /// <param name="message">Message à dire.</param>
        public void Parler(string message)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Verbaflora dit : \uD83C\uDF31\uD83C\uDF38{message}\uD83C\uDF38\uD83C\uDF31");
        }
    }
}
