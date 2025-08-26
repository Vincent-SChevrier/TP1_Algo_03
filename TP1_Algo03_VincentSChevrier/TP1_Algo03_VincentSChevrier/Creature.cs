// <copyright file="Creature.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe représentant une créature qui peut se déplacer.
    /// </summary>
    public class Creature : Organisme, IDeplacement
    {
        /// <summary>
        /// Constructeur de la créature.
        /// </summary>
        /// <param name="nom">Nom de la créature.</param>
        /// <param name="positionX">Posision sur l'axe des X de la créature.</param>
        /// <param name="positionY">Position sur l'axe des Y de la créature.</param>
        /// <param name="vitesse">Vitess de la créature.</param>
        public Creature(string nom, int positionX, int positionY, int vitesse) : base(nom, positionX, positionY)
        {
            Vitesse = vitesse;
        }

        /// <summary>
        /// Propriété représentant la vitesse de déplacement de la créature.
        /// </summary>
        public int Vitesse { get; }

        /// <summary>
        /// Fonction de déplacement de la créature.
        /// </summary>
        /// <param name="deplacementX">Nombre de pas à faire sur l'axe des X.</param>
        /// <param name="deplacementY">Nombre de pas à faire sur l'axe des Y.</param>
        public void Deplacement(int deplacementX, int deplacementY)
        {
            PositionX += deplacementX * Vitesse;
            PositionY += deplacementY * Vitesse;
        }
    }
}
