#region Exemple avec WHILE
//Console.WriteLine("Veuillez entrer un nombre de 12 chiffres : ");
//string bban = Console.ReadLine();                                       //Initialisation

//while (bban.Length != 12 || !long.TryParse(bban, out _))                //Condition
//{
//    Console.WriteLine("Ceci n'est pas un BBAN valide...");
//    Console.WriteLine("Veuillez entrer un nombre de 12 chiffres : ");
//    bban = Console.ReadLine();                                          //Modifiée
//}
#endregion

#region Exemple avec FOR
//Console.WriteLine("Veuillez entrer un nombre de 12 chiffres : ");
//for (string bban = Console.ReadLine(); bban.Length != 12 || !long.TryParse(bban, out _); bban = Console.ReadLine())
//{
//    Console.WriteLine("Ceci n'est pas un BBAN valide...");
//    Console.WriteLine("Veuillez entrer un nombre de 12 chiffres : ");
//}
#endregion

#region Exemple pour le DO ... WHILE

string bban;
do
{
    Console.WriteLine("Veuillez entrer un nombre de 12 chiffres : ");
    bban = Console.ReadLine();
} while (bban.Length != 12 || !long.TryParse(bban, out _));


#endregion