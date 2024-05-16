List<string> courses = new List<string>();
string choix;

do
{
    Console.Clear();
    Console.WriteLine("Voici votre liste de course :");
    Console.WriteLine($"Il y a actuellement {courses.Count} article(s).");

    foreach (string article in courses)
    {
        Console.WriteLine($"\t- {article}");
    }

    Console.WriteLine("Appuyez sur :");
    Console.WriteLine("(A)jouter - (S)upprimer - (Q)uitter");

    choix = Console.ReadLine().ToUpper();

    switch (choix)
    {
        case "A":
            Console.WriteLine("Veuillez indiquer le nouvel article à ajouter:");
            courses.Add(Console.ReadLine());
            break;
        case "S":
            Console.WriteLine("Veuillez indiquer l'article à supprimer:");
            bool supprimerOk = courses.Remove(Console.ReadLine());
            if (supprimerOk)
            {
                Console.WriteLine("Suppression réussie!");
            }
            else
            {
                Console.WriteLine("Échec de la suppression...");
            }
            Console.ReadLine();
            break;
    } 
} while (choix != "Q");