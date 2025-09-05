// <copyright file="IDeplacement.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Interface représentant une capacité de déplacement.
    /// </summary>
    public interface IDeplacement
    {
        /// <summary>
        /// Modèle de la fonction de déplacement.
        /// </summary>
        /// <param name="deplacementX">Nombre de pas à faire sur l'axe des X.</param>
        /// <param name="deplacementY">Nombre de pas à faire sur l'axe des Y.</param>
        protected void Deplacement(int deplacementX, int deplacementY)
        {

        }
    }
}
