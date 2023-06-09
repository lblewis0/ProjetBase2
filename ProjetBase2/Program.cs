#region exo 01
//---------------Exo 01 - 08-06-2023-------------------
//-------------Deplacer Pion sur tableau---------------
//string[,] plateau = new string[10,10];

//string pion = "X";
//string pionVide = "-";
//bool stillPlay = true;

//void afficherPlateau(string[,] plateau)
//{
//    //Affiche le plateau de départ
//    for (int i = 0; i < plateau.GetLength(0); i++)
//    {
//        for (int j = 0; j < plateau.GetLength(1); j++)
//        {
//            Console.Write($"|{plateau[j, i]}|");
//        }
//        Console.WriteLine();
//    }
//}

////Génère plateau vide
//for (int i = 0; i < plateau.GetLength(0); i++)
//{
//    for (int j = 0; j < plateau.GetLength(1); j++)
//    {
//        plateau[i, j] = pionVide;
//    }
//}

////Je place le pion au milieu
//int x_pion = 0;
//int y_pion = 0;
//plateau[x_pion, y_pion] = pion;

//afficherPlateau(plateau);

//while (stillPlay)
//{
//    Console.WriteLine("Choisisez une direction dans laquelle déplacer le pion");
//    Console.WriteLine("H = vers le haut, B = vers le bas, G = vers la gauche, D = vers la droite, S pour stopper le jeu");

//    //Vide la case du pion de départ
//    plateau[x_pion, y_pion] = pionVide;

//    //Demande a l'utilisateur ou deplacer le pion
//    string actionUtilisateur = Console.ReadLine();

//    //Déduire nouvelle coordonnées du pion
//    switch (actionUtilisateur.ToUpper())
//    {
//        case ("H"):
//            if (y_pion > 0)
//            {
//                y_pion--;
//            }
//            else if (y_pion == 0)
//            {
//                y_pion = plateau.GetLength(1)-1;
//            }
//            break;
//        case ("B"):
//            if (y_pion < plateau.GetLength(1)-1)
//            {
//                y_pion++;
//            }
//            else if (y_pion == plateau.GetLength(1) - 1)
//            {
//                y_pion = 0;
//            }
//            break;
//        case ("G"):
//            if (x_pion > 0)
//            {
//                x_pion--;
//            }
//            else if (x_pion == 0)
//            {
//                x_pion = plateau.GetLength(0) - 1;
//            }
//            break;
//        case ("D"):
//            if (x_pion < plateau.GetLength(0) - 1)
//            {
//                x_pion++;
//            }
//            else if (x_pion == plateau.GetLength(0) - 1)
//            {
//                x_pion = 0;
//            }
//            break;
//        case ("S"):
//            stillPlay = false;
//            break;
//    }

//    //Placer le pion dans le tableau
//    plateau[x_pion, y_pion] = pion;

//    //Afficher le nouveau plateau
//    Console.Clear();
//    afficherPlateau(plateau);
//}

#endregion

//-------------Correction Exo 01 bis - 08-06-2023-------------------
//-------------Deplacer Pion sur tableau---------------
//string[,] plateau = new string[10, 10];

//string pion = "X";
//string pionVide = "-";
//bool stillPlay = true;

//void afficherPlateau(string[,] plateau)
//{
//    //Affiche le plateau de départ
//    for (int i = 0; i < plateau.GetLength(0); i++)
//    {
//        for (int j = 0; j < plateau.GetLength(1); j++)
//        {
//            Console.Write($"|{plateau[j, i]}|");
//        }
//        Console.WriteLine();
//    }
//}

////Génère plateau vide
//for (int i = 0; i < plateau.GetLength(0); i++)
//{
//    for (int j = 0; j < plateau.GetLength(1); j++)
//    {
//        plateau[i, j] = pionVide;
//    }
//}

////Je place le pion au milieu
//int x_pion = 0;
//int y_pion = 0;
//plateau[x_pion, y_pion] = pion;

//afficherPlateau(plateau);

//ConsoleKeyInfo cki;

//do
//{
//    Console.WriteLine("Choisisez une direction dans laquelle déplacer le pion");
//    Console.WriteLine("↓↑←→ pour deplacer le pion, Esc pour stopper le jeu");

//    //Vide la case du pion de départ
//    plateau[x_pion, y_pion] = pionVide;

//    cki = Console.ReadKey();

//    //Déduire nouvelle coordonnées du pion
//    switch (cki.Key)
//    {
//        case ConsoleKey.UpArrow:
//            if (y_pion > 0)
//            {
//                y_pion--;
//            }
//            else if (y_pion == 0)
//            {
//                y_pion = plateau.GetLength(1) - 1;
//            }
//            break;
//        case ConsoleKey.DownArrow:
//            if (y_pion < plateau.GetLength(1) - 1)
//            {
//                y_pion++;
//            }
//            else if (y_pion == plateau.GetLength(1) - 1)
//            {
//                y_pion = 0;
//            }
//            break;
//        case ConsoleKey.LeftArrow:
//            if (x_pion > 0)
//            {
//                x_pion--;
//            }
//            else if (x_pion == 0)
//            {
//                x_pion = plateau.GetLength(0) - 1;
//            }
//            break;
//        case ConsoleKey.RightArrow:
//            if (x_pion < plateau.GetLength(0) - 1)
//            {
//                x_pion++;
//            }
//            else if (x_pion == plateau.GetLength(0) - 1)
//            {
//                x_pion = 0;
//            }
//            break;
//    }

//    //Placer le pion dans le tableau
//    plateau[x_pion, y_pion] = pion;

//    //Afficher le nouveau plateau
//    Console.Clear();
//    afficherPlateau(plateau);
//} while (cki.Key != ConsoleKey.Escape);

//----------------Exemple Structure------------------------------
//#region exoStrucuture
//using ProjetBase;

//NewDateTime maSuperDate = new NewDateTime(2,"Avril",1995);

//#endregion

//----------------Exercice 09-06-2023----------------------------
//---Il y a un problème avec les structures concernant la valeur et la référence
//---Précisez un ref devant les variables pour que cela marche
//---Les classes sont plus pertinentes dans beaucoup de cas
//#region Demo structure Pokemon 09-06-23

//using ProjetBase;

//List<Pokemon> team = new List<Pokemon>()
//{
//    new Pokemon("pikachu"),
//    new Pokemon("ratata"),
//    new Pokemon("roucoul"),
//    new Pokemon("Chenipan"),
//    new Pokemon("Magicarpe"),
//};

//Pokemon mewtwo = new Pokemon ("Mewtwo",100,100,100,100,100,100,100);
//Pokemon ratata = new Pokemon("Ratata");

//for (int i = 0; i < team.Count; i++)
//{
//    Fight(ref mewtwo, team[i]);
//}

//static void Fight(ref Pokemon mewtwo, Pokemon pokemon)
//{
//    while (mewtwo.PV > 0 && pokemon.PV > 0)
//    {
//        mewtwo.Attack(ref pokemon);
//        if (mewtwo.PV > 0)
//        {
//            mewtwo.Attack(ref pokemon);
//        }
//    }
//    Console.WriteLine("Fin du combat");
//}

//#endregion

//----------------Exo CRUD---------------------------------------------------------------------
//--Creer tableau avec possibilités d'ajouter, rechercher, modifier, supprimer valeur----------
#region Exo CRUD

using System.Text;
using ProjetBase;

bool stillDo = true;
int? action = null;

magasin mag = new magasin("Sexshop");

do
{
    Console.WriteLine("Quelle action voulez-vous faire ?");

    StringBuilder sb = new StringBuilder();
    foreach (actions a in Enum.GetValues<actions>())
    {
        sb.AppendLine($"{(int)a + 1} - {a}");
    }
    Console.WriteLine(sb);

    action = int.Parse(Console.ReadLine());
    action -= 1;

    switch (action)
    {
        case 0:
            //Afficher
            mag.AfficherListeProduits();
            break;
        case 1:
            //Ajouter
            mag.Ajouter();
            break;
        case 2:
            //Rechercher
            mag.Rechercher();
            break;
        case 3:
            //Modifier
            break;
        case 4:
            //Supprimer
            break;
        case 5:
            //Arret du programme
            stillDo = false;
            break;
        default:
            Console.WriteLine("Action non disponible");
            break;
    }

} while (stillDo);

#endregion


