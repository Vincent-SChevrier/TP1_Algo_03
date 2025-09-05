// <copyright file="Ambuloflora.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe représentant une Ambuloflora, une plante qui peut se déplacer.
    /// </summary>
    public class Ambuloflora : Plante, IDeplacement
    {
        /// <summary>
        /// Constructeur de l'Ambuloflora.
        /// </summary>
        /// <param name="positionX">Position de l'Ambuloflora sur l'axe des X.</param>
        /// <param name="positionY">Position de l'Ambuloflora sur l'axe des Y.</param>
        public Ambuloflora(int positionX, int positionY) : base("Ambulaflora", positionX, positionY)
        {
        }

        /// <summary>
        /// Fonction de déplacement de l'Ambuloflora.
        /// On utilise un compteur pour compter le nombre de pas effectués.
        /// Math.Abs pour gérer les déplacements négatifs.
        /// </summary>
        /// <param name="deplacementX">Nombre de pas à faire sur l'axe des X.</param>
        /// <param name="deplacementY">Nombre de pas à faire sur l'axe des Y.</param>
        public void Deplacement(int deplacementX, int deplacementY)
        {
            int compteur = 0; // 1
            for (int i = Math.Abs(deplacementX); i > 0; i--) // n
            {
                if (compteur == 3) // n
                {
                    PositionX -= deplacementX / Math.Abs(deplacementX); // 1
                    compteur = 0; // 1
                    i++; // 1
                }
                else // n
                {
                    PositionX += deplacementX / Math.Abs(deplacementX); // 1
                    compteur++; // 1
                }
            }

            for (int i = Math.Abs(deplacementY); i > 0; i--) // n
            {
                if (compteur == 3) // n
                {
                    PositionY -= deplacementY / Math.Abs(deplacementY); // 1
                    compteur = 0; // 1
                    i++; // 1
                }
                else // n
                {
                    PositionY += deplacementY / Math.Abs(deplacementY); // 1
                    compteur++; // 1
                }
            }

            // = 1 + n + n + 1 + 1 + 1 + n + 1 + 1 + n + n + 1 + 1 + 1 + n + 1 + 1
            // = 6n + 11
            // = O(n)
        }
    }
}
