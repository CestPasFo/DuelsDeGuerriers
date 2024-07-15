using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuelGuerrier.Classe;

namespace DuelGuerrier.Classe
{
    internal class Nain : Guerrier
    {
        private int _ptBouclier;
        public Nain (int pdv, int nbDegats, string name, int bouclier) : base (pdv, nbDegats, name, bouclier)
        {
            Bouclier = bouclier;
        }

        public override int TakeDamage(Guerrier Joueur1, int dmg, int bouclier)
        {
            int dgts = 0;
            dgts += dmg - bouclier;
            return dgts;
        }
    }
}
