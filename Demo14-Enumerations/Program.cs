#region Sans Flags
//Cardinalite direction = Cardinalite.Nord;

//direction = (Cardinalite)3; //direction prend la valeur de Ouest (car identifiant de Ouest est 3)
//Console.WriteLine($"Le vent souffle côté {direction}.");

//direction = direction - 1; //direction est à 3 (Ouest), - 1, donne 2 qui vaut Sud 
//						   //direction--;
//						   //direction -= 1;
//Console.WriteLine($"Le vent souffle côté {direction}.");
//public enum Cardinalite { Nord, Est, Sud, Ouest } 
#endregion
#region Avec Flags
//Cardinalite direction;
//direction = (Cardinalite) 9; //9 : c'est 8 + 1 : 8 pour Ouest, 1 pour Nord

//Console.Write($"Le vent souffle côté");
//if (direction.HasFlag(Cardinalite.Nord))
//{
//    Console.Write(" Nord");
//}
//if (direction.HasFlag(Cardinalite.Sud))
//{
//    Console.Write(" Sud");
//}
//if (direction.HasFlag(Cardinalite.Est))
//{
//    Console.Write(" Est");
//}
//if (direction.HasFlag(Cardinalite.Ouest))
//{
//    Console.Write(" Ouest");
//}
//Console.WriteLine(".");

//public enum Cardinalite { Nord = 1, Est = 2, Sud = 4, Ouest = 8 } 
#endregion
#region Enum déjà dans le system

//MaConsole console;
//console.WriteLine("C'est pas l'heure de la pause?");

//public struct MaConsole
//{
//    public void WriteLine(string monTexte)
//    {
//        Console.BackgroundColor = 0;
//        Console.ForegroundColor = (ConsoleColor)15;
//        for (int i = 0; i < monTexte.Length; i++)
//        {
//            Console.Write(monTexte[i]);
//            Console.BackgroundColor = (ConsoleColor)(((int)Console.BackgroundColor + 1) % 16);
//            Console.ForegroundColor = 
//                ((int)Console.ForegroundColor == 0)?(ConsoleColor)15 : Console.ForegroundColor - 1;
//        }
//        Console.ResetColor();
//        Console.WriteLine();
//    }
//}

#endregion

#region Démos méthodes

Console.WriteLine("Êtes-vous heureux de comprendre les enums ?");
//string[] reponses = Enum.GetNames(typeof(Reponse));
string[] reponses = Enum.GetNames<Reponse>();
foreach (string reponse in reponses)
{
    Console.WriteLine($"\t - {reponse}");
}

string userEntree = Console.ReadLine();

//Reponse userReponse = (Reponse)Enum.Parse(typeof(Reponse), userEntree);
//Reponse userReponse = Enum.Parse<Reponse>(userEntree);
Reponse userReponse;
bool isOk = Enum.TryParse<Reponse>(userEntree, out userReponse);

if (isOk)
{
    switch (userReponse)
    {
        case Reponse.Oui:
            Console.WriteLine("Heureux pour vous!");
            break;
        case Reponse.Non:
            Console.WriteLine("Quel dommage!");
            break;
        case Reponse.PeutEtre:
            Console.WriteLine("Il serait temps de le savoir!");
            break;
    }
}
else
{
    Console.WriteLine("Je n'ai pas compris...");
}
public enum Reponse { Oui, Non, PeutEtre }

#endregion