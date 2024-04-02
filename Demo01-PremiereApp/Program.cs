// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, les Unitys 24!");
Console.WriteLine("Pas mal pour un premier jour de cours!");
Console.WriteLine("Quel est votre nom ?");
string username = Console.ReadLine();
Console.Clear();
//Console.Write("Bonjour ");
//Console.Write(username);
//Console.Write(" !");

//Concaténation : Colle les mots ensembles
Console.WriteLine("Bonjour " + username + " !");

//Interpolation : incruste les mots des variables dans le texte
Console.WriteLine("Bonjour {0} !", username);
Console.WriteLine($"Bonjour {username} !");