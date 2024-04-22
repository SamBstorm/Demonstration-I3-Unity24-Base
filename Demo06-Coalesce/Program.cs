Console.WriteLine("Joueur, veuillez choisir un pseudo : (Enter pour laisser tel quel)");
string pseudo = Console.ReadLine();
pseudo = (pseudo == "")? null: pseudo;


//if (pseudo == null) pseudo = "Link";

//OU

//pseudo = pseudo ?? "Link";

//OU

pseudo ??= "Link";
Console.WriteLine($"Bienvenue brave héro : {pseudo}!");
