Dictionary<string,int> courses = new Dictionary<string,int>();
string choix;

do
{
    Console.Clear();
    Console.WriteLine("Voici votre liste de courses :");
    Console.WriteLine($"Il y a actuellement {courses.Count} article(s).");

    foreach (KeyValuePair<string, int> articleQuantite in courses)
    {
        Console.WriteLine($"\t- {articleQuantite.Key} : {articleQuantite.Value}");
    }

    Console.WriteLine("Faîtes un choix :");
    Console.WriteLine("(A)jouter | (M)odifier | (S)upprimer | (Q)uitter");
    choix = Console.ReadLine().ToUpper();

    switch (choix)
    {
        case "A":
            Console.WriteLine("Quel est l'article que vous voulez ajouter :");
            string article = Console.ReadLine();
            if (courses.ContainsKey(article))
            {
                Console.WriteLine("L'article est déjà dans la liste...");
            }
            else
            {
                int quantite;
                do
                {
                    Console.WriteLine("Quel quantité ?");
                } while (!int.TryParse(Console.ReadLine(), out quantite) || quantite < 1);
                courses.Add(article, quantite);
                Console.WriteLine("Article ajouté avec succès!");
            }
            Console.ReadLine();
            break;
        case "M":
            Console.WriteLine("Quel est l'article que vous voulez modifier :");
            string newArticle = Console.ReadLine();
            if (courses.ContainsKey(newArticle))
            {
                int quantite;
                do
                {
                    Console.WriteLine("Quel quantité ?");
                } while (!int.TryParse(Console.ReadLine(), out quantite) || quantite < 1);
                courses[newArticle] = quantite;
                Console.WriteLine("L'article a été mis à jour avec succès.");
            }
            else
            {
                Console.WriteLine("L'article n'est pas présent dans la liste...");
            }
            Console.ReadLine();
            break;
        case "S":
            Console.WriteLine("Quel est l'article à supprimer :");
            string oldArticle = Console.ReadLine();
            if (courses.Remove(oldArticle))
            {
                Console.WriteLine("Suppression effectuée avec succès!");
            }
            else
            {
                Console.WriteLine("L'article n'est pas présent dans la liste...");
            }
            Console.ReadLine();
            break;
    } 
} while (choix != "Q");
