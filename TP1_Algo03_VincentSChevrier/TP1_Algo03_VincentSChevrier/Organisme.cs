using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Algo03_VincentSChevrier
{
    public abstract class Organisme
    {
        protected string Nom { get; }
        protected int PositionX { get; }
        protected int PositionY { get; }

        protected Organisme(string nom, int positionX, int positionY)
        {
            Nom = nom;
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
