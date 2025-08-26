// <copyright file="Ecosysteme.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe représentant un écosystème contenant une liste d'organismes.
    /// </summary>
    public class Ecosysteme
    {
        /// <summary>
        /// Liste statique des organismes dans l'écosystème.
        /// </summary>
        public static List<Organisme> Organismes { get; } = new List<Organisme>();

        /// <summary>
        /// Fonction pour ajouter un organisme à l'écosystème.
        /// </summary>
        /// <param name="organisme">Organisme à ajouter dans l'écosystème.</param>
        public static void AjouterOrganisme(Organisme organisme)
        {
            Organismes.Add(organisme);
        }

        /// <summary>
        /// Fonction pour trouver l'organisme le plus proche d'un organisme donné.
        /// Math.Abs pour gérer les distances négatives.
        /// </summary>
        /// <param name="organismeDeDepart">Organisme duquel on trouve l'organisme le plus proche.</param>
        public static void TrouverOrganismeLePlusProche(Organisme organismeDeDepart)
        {
            Organisme organismeLePlusProche = null!;
            foreach (Organisme organisme in Organismes)
            {
                if (organisme != organismeDeDepart)
                {
                    if (organismeLePlusProche == null)
                    {
                        organismeLePlusProche = organisme;
                    }
                    else
                    {
                        double distanceActuelle = Math.Abs(organismeDeDepart.PositionX - organisme.PositionX) + Math.Abs(organismeDeDepart.PositionY - organisme.PositionY);
                        double distancePlusProche = Math.Abs(organismeDeDepart.PositionX - organismeLePlusProche.PositionX) + Math.Abs(organismeDeDepart.PositionY - organismeLePlusProche.PositionY);
                        if (distanceActuelle < distancePlusProche)
                        {
                            organismeLePlusProche = organisme;
                        }
                    }
                }
            }

            if (organismeLePlusProche != null)
            {
                Console.WriteLine($"L'organisme le plus proche de {organismeDeDepart.Nom} est {organismeLePlusProche.Nom} situé en ({organismeLePlusProche.PositionX}, {organismeLePlusProche.PositionY})");
            }
            else
            {
                Console.WriteLine($"{organismeDeDepart.Nom} n'a pas d'autres organismes à proximité.");
            }
        }
    }
}
