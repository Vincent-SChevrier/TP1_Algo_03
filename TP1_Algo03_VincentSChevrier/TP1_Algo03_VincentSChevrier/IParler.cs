// <copyright file="IParler.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Interface représentant une capacité de parler.
    /// </summary>
    public interface IParler
    {
        /// <summary>
        /// Modèle de la fonction pour parler.
        /// </summary>
        /// <param name="message">Message à dire par un organisme.</param>
        void Parler(string message);
    }
}
