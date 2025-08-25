using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Algo03_VincentSChevrier
{
    public class Creature : Organisme, IDeplacement
    {
        public int Vitesse { get; }
        public int NbCasesDeplacer { get; }

        public Creature(string nom, int positionX, int positionY, int vitesse, int nbCasesDeplacer) : base(nom, positionX, positionY)
        {
            Vitesse = vitesse;
            NbCasesDeplacer = nbCasesDeplacer;
        }

        public void Deplacement()
        {
            // Logique de déplacement
        }
    }
}
