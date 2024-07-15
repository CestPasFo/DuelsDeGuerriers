using DuelGuerrier.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DuelGuerrier.Classe
{
    internal class Guerrier
    {
        #region Initiation Classe Guerreir
        private int _pv;
        private int _nbDeDegats;
        private int _ptBouclier;
        private String _name;

        public int Pdv { get => _pv; set => _pv = value; }
        public int NbDeDegats { get => _nbDeDegats; set => _nbDeDegats = value; }
        public String Name { get => _name; set => _name = value; }
        public int Bouclier { get => _ptBouclier; set => _ptBouclier = value; }

        public Guerrier(int pdv, int nbDegats, string name, int bouclier)
        {
            Pdv = pdv;
            NbDeDegats = nbDegats;
            Name = name;
            Bouclier = 0;
        }
        #endregion

        #region Fonction attaque
        public virtual int Attack()
        {
            Random aleatoire = new Random();
            int dmg = aleatoire.Next(1, 7);
            return dmg;
        }
        #endregion

        #region Fonction Theme Song WiP
        public static void Theme()
        {
           
        }
        #endregion

        #region Status PJ
        public virtual void Etat(Guerrier Joueur1, int dmgJ2, Guerrier Joueur2)
        {
            Console.WriteLine("\n -" + Joueur2.Name + " a infligé " + dmgJ2 + " points de vie à " + Joueur1.Name + ".");
            Console.WriteLine("\n -" + Joueur1.Name + " a " + Joueur1.Pdv + " points de vie restants.");
        }
        #endregion

        #region Fonction reception dégats
        public virtual int TakeDamage(Guerrier Joueur1, int dmg, int bouclier)
        {
            int dgts = 0;
            dgts += dmg;
            return dgts;
        }
        #endregion

        #region Fonction combat
        public static void Fight(Guerrier Joueur1, Guerrier Joueur2)
        {
            Random aleatoire = new Random();
            int turn = 1;
            int dmgJ1;
            int dmgJ2;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n -----------------------------------------------------------------------------------------");
            Console.WriteLine("     | | ________________                                          ________________ | |     ");
            Console.WriteLine("O|===|* >________________> Cest l'heure du du-du-du-du-du-duel !! <________________< *|===|O");
            Console.WriteLine("     | |                                                                            | |     ");
            Console.WriteLine(" -----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            while (Joueur1.Pdv > 0 && Joueur2.Pdv > 0)
            {
                if (turn % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDebut du tour " + turn);
                    Console.WriteLine("\nTour de " + Joueur2.Name + " (J2)");
                    for (int i = 0; i < Joueur2.NbDeDegats; i++)
                    {
                        dmgJ2 = Joueur2.Attack();
                        Joueur1.Pdv -= Joueur1.TakeDamage(Joueur1, dmgJ2, Joueur1.Bouclier);
                        Joueur1.Etat(Joueur1, dmgJ2, Joueur2);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nDebut du tour " + turn);
                    Console.WriteLine("\nTour de " + Joueur1.Name + " (J1)");
                    for (int i = 0; i < Joueur1.NbDeDegats; i++)
                    {
                        dmgJ1 = Joueur1.Attack();
                        Joueur2.Pdv -= Joueur2.TakeDamage(Joueur2, dmgJ1, Joueur2.Bouclier);
                        Joueur2.Etat(Joueur1, dmgJ1, Joueur2);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                turn++;
            }
            Console.WriteLine("\n--------------------------------------------");
            if (Joueur2.Pdv <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n" + Joueur1.Name + " a gagné !");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n" + Joueur2.Name + " a gagné !");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion

    }
}


