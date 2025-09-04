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
        /// <param name="organismeCible">Organisme duquel on trouve l'organisme le plus proche.</param>
        public static void TrouverOrganismeLePlusProche(Organisme organismeCible) // 1
        {
            Organisme organismeLePlusProche = null!; // 1

            foreach (Organisme organisme in Organismes) // n
            {
                if (organisme != organismeCible) // n ou 1 car une seule probabilité simple (1 check)
                {
                    if (organismeLePlusProche == null) // n ou 1 car une seule probabilité simple (1 check)
                    {
                        organismeLePlusProche = organisme; // 1
                    }
                    else // autre donc aucune valeur O
                    {
                        double distanceActuelle = Math.Abs(organismeCible.PositionX - organisme.PositionX) + Math.Abs(organismeCible.PositionY - organisme.PositionY); // 1
                        double distancePlusProche = Math.Abs(organismeCible.PositionX - organismeLePlusProche.PositionX) + Math.Abs(organismeCible.PositionY - organismeLePlusProche.PositionY); // 1

                        if (distanceActuelle < distancePlusProche) // n ou 1 car une seule probabilité simple (1 check)
                        {
                            organismeLePlusProche = organisme; // 1
                        }
                    }
                }
            }

            if (organismeLePlusProche != null) // n ou 1 car une seule probabilité simple (1 check)
            {
                Console.WriteLine($"L'organisme le plus proche de {organismeCible.Nom} est {organismeLePlusProche.Nom} situé en ({organismeLePlusProche.PositionX}, {organismeLePlusProche.PositionY})"); // 1
            }
            else // autre donc aucune valeur O
            {
                Console.WriteLine($"{organismeCible.Nom} n'a pas d'autres organismes à proximité."); // 1
            }

            // n + 11 => O(n)
        }
    }
}
