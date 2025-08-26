// <copyright file="Organisme.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe abstraite représentant un organisme avec un nom et une position.
    /// </summary>
    public abstract class Organisme
    {
        /// <summary>
        /// Constructeur de l'organisme.
        /// </summary>
        /// <param name="nom">Nom de l'organisme.</param>
        /// <param name="positionX">Position sur l'axe des X de l'organisme.</param>
        /// <param name="positionY">Position sur l'axe des Y de l'organisme.</param>
        protected Organisme(string nom, int positionX, int positionY)
        {
            Nom = nom;
            PositionX = positionX;
            PositionY = positionY;
        }

        /// <summary>
        /// Popriété représentant le nom de l'organisme.
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Propriété représentant la position sur l'axe des X de l'organisme.
        /// </summary>
        public int PositionX { get; set; }

        /// <summary>
        /// Propriété représentant la position sur l'axe des Y de l'organisme.
        /// </summary>
        public int PositionY { get; set; }
    }
}
