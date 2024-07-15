using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGuerrier.Classe
{
    internal class Elfs : Guerrier
    {

        public Elfs(int pdv, int nbDegats, string name, int bouclier) : base(pdv, nbDegats, name, bouclier)
        {

        }

        public override int Attack()
        {
            Random aleatoire = new Random();
            int dmg = aleatoire.Next(2, 7);
            return dmg;
        }
    }
}
