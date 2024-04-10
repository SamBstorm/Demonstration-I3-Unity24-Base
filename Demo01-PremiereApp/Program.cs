string username;


Console.WriteLine("Hello, les Unitys 24!\nPas mal pour un premier jour de cours!\nQuel est votre nom ?");
username = Console.ReadLine();
Console.Clear();
//Console.Write("Bonjour ");
//Console.Write(username);
//Console.Write(" !");

//Concaténation : Colle les mots ensembles
Console.WriteLine("Bonjour "+username+" !");

//Interpolation : incruste les mots des variables dans le texte
Console.WriteLine("Bonjour {0} !", username);
Console.WriteLine($"Bonjour {username} !");