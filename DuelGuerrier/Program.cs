using DuelGuerrier.Classe;
using System.Xml.Linq;

#region Brief combat guerrier

//Création des personnages
Guerrier Joueur1 = new Guerrier(15,2,"Perceval de Galles",0);
Guerrier Joueur2 = new Guerrier(10,2,"Jeanne d'Arc", 0);
Nain Joueur3 = new Nain(100, 1, "Gimli son of Glóin",1);
Nain Joueur4 = new Nain(100, 1, "Thorin Écu-de-chêne",1);
Elfs Joueur5 = new Elfs(45, 3, "Telerin Quenya Alatáriel", 0);
Elfs Joueur6 = new Elfs(50, 3, "Sindarin Laegolas", 0);

List<Guerrier> listPJ = new List<Guerrier>();
listPJ.Add(Joueur1);
listPJ.Add(Joueur2);
listPJ.Add(Joueur3);
listPJ.Add(Joueur4);
listPJ.Add(Joueur5);
listPJ.Add(Joueur6);

#region Affiche menu
static void AffichageMenu()
{
    Console.WriteLine("\n   - Quelle lignée souhaiteriez vous jouer ? -  ");

    Console.WriteLine("\n|------------------------------------------------|");
    Console.WriteLine("|1 ------------------ Humain --------------------|");
    Console.WriteLine("|------------------------------------------------|");
    Console.WriteLine("|2 ------------------- Nain ---------------------|");
    Console.WriteLine("|------------------------------------------------|");
    Console.WriteLine("|3 ------------------- Elfs ---------------------|");
    Console.WriteLine("|------------------------------------------------|");
    Console.WriteLine("|0 ----------------- Quitter --------------------|");
    Console.WriteLine("|------------------------------------------------|");
}
#endregion

#region Methode d ecreation + ajout de personnage
static void create(List<Guerrier> listPJ)
{
    Random aleatoire = new Random();

    int pntVie;
    int nbAttack;
    string nom;
    int bouclier;
    Console.Clear();
    Console.WriteLine(" Entrez le nom de votre personnage : ");
    nom = Console.ReadLine();
    pntVie = aleatoire.Next(40, 125);
    Console.WriteLine(" Vous avez : " + pntVie + " points de vie");
    nbAttack = aleatoire.Next(1, 3);
    Console.WriteLine(" Votre personnage peut attaquer : " + nbAttack + " fois");
    bouclier = 0;
    Guerrier PJG = new Guerrier(pntVie, nbAttack, nom, 0);
    listPJ.Add(PJG);
}
#endregion

#region Creation de Personnage WiP
static void createPJ(List<Guerrier> listPJ)
{
    //Initialisation des variables
    bool isSaisieValid = false;
    int saisieU = 0;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" ---------------------------------------------- ");
    Console.WriteLine("  | Bienvenue dans le créateur de personnage |  ");
    Console.WriteLine(" ---------------------------------------------- ");
    Console.ForegroundColor = ConsoleColor.White;
    AffichageMenu();
    do
    {
        Console.WriteLine("\n Faites votre choix :");
        isSaisieValid = int.TryParse(Console.ReadLine(), out saisieU);
        switch (saisieU)
        {
            case 1: //Creation d'un Guerrier
                create(listPJ);
                break;

            case 2: //Creation d'un Nain
                create(listPJ);
                break;

            case 3: //Création d'un Elf
                create(listPJ);
                break;

            case 0:
                Environment.Exit(0);
                break;

            default:
                Console.Clear();
                Console.WriteLine("Erreur - veuillez recommancer votre saisie");
                Console.WriteLine("\n   - Quelle lignée souhaiteriez vous jouer ? -  ");
                AffichageMenu();
                break;

        }
    } while (saisieU != 0);
}
#endregion

createPJ(listPJ);
Guerrier.Fight(Joueur4, Joueur6);
#endregion