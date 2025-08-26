// <copyright file="Program.cs" company="CSTJEAN 2025">
// Copyright (c) Ariane De Guise - Vincent Szwec-Chevrier. All rights reserved.
// </copyright>

namespace TP1_Algo03_VincentSChevrier
{
    /// <summary>
    /// Classe principale du programme.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Fonction principale du programme et utilisée pour tester les différentes fonctionnalités.
        /// </summary>
        /// <param name="args">Arguments (non-utilisé).</param>
        private static void Main(string[] args)
        {
            // Une Cryptolingua(1, 1) qui parle et qui se déplace de(+2, +2).
            Cryptolingua cryptolingua = new Cryptolingua(1, 1);
            cryptolingua.Deplacement(2, 2);
            Console.WriteLine($"Cryptolingua est maintenant en ({cryptolingua.PositionX}, {cryptolingua.PositionY})");
            cryptolingua.Parler("Allo!");

            // Un Verbaflora(5, 5) qui parle.
            Verbaflora verbaflora = new Verbaflora(5, 5);
            verbaflora.Parler("Allo!");

            // Un Ambuloflora(10, 10) qui se déplace de(-7, +9).
            Ambuloflora ambuloflora = new Ambuloflora(10, 10);
            ambuloflora.Deplacement(-7, 9);
            Console.WriteLine($"Ambuloflora est maintenant en ({ambuloflora.PositionX}, {ambuloflora.PositionY})");

            // Un environnement avec les 3 créatures créées ci - dessus.
            Ecosysteme.AjouterOrganisme(cryptolingua);
            Ecosysteme.AjouterOrganisme(verbaflora);
            Ecosysteme.AjouterOrganisme(ambuloflora);
            foreach (Organisme organisme in Ecosysteme.Organismes)
            {
                Console.WriteLine($"{organisme.Nom} est en ({organisme.PositionX}, {organisme.PositionY})");
            }

            // Trouver l’organisme le plus proche d’un Novaplantus(9, 9) dans l’environnement ci-dessus.
            Plante novaplantus = new Plante("Novaplantus", 9, 9);
            Ecosysteme.TrouverOrganismeLePlusProche(novaplantus);

            // Une nouvelle créature qui a une vitesse de 2, qui est à la position(20, 20) et qui se déplace de(-2, +2).
            Creature creature = new Creature("Creature", 20, 20, 2);
            creature.Deplacement(-2, 2);
            Console.WriteLine($"Creature est maintenant en ({creature.PositionX}, {creature.PositionY})");

            // Une liste d’organismes qui peuvent parler. Ajouter le Cryptolingua et la Verbaflora. Faites une boucle qui leur fait dire « Super message !!! ».
            List<IParler> organismesParlants = new List<IParler> { cryptolingua, verbaflora };
            foreach (IParler organismeParlant in organismesParlants)
            {
                organismeParlant.Parler("Super message !!!");
            }
        }
    }
}

/* À faire :
   Calculer la complexité en notation « Grand O »
*/
