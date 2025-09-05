// <copyright file="Plante.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe représentant une plante, qui hérite de la classe Organisme.
    /// </summary>
    public class Plante : Organisme
    {
        /// <summary>
        /// Constructeur de la plante.
        /// </summary>
        /// <param name="nom">Nom de la plante.</param>
        /// <param name="positionX">Position sur l'axe des X de la plante.</param>
        /// <param name="positionY">Position sur l'axe des Y de la plante.</param>
        public Plante(string nom, int positionX, int positionY) : base(nom, positionX, positionY)
        {

        }
    }
}
