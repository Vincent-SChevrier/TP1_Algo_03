using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Algo03_VincentSChevrier
{
    public class Ambuloflora : Plante, IDeplacement
    {
        public Ambuloflora(string nom, int positionX, int positionY) : base(nom, positionX, positionY)
        {

        }

        public void Deplacement()
        {
            // Logique de déplacement spécifique à Ambuloflora
        }
    }
}
