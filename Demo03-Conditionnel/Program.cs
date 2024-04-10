const int LIMIT_AGE = 18;

Console.WriteLine("Bonjour, veuillez indiquer votre âge :");
if(int.TryParse(Console.ReadLine(), out int age))
{
    if(age >= LIMIT_AGE)
    {
        Console.WriteLine("Veuillez indiquer votre nationalité :");
        string nationalite = Console.ReadLine();
        switch (nationalite.ToLower())
        {
            case "belge":
                Console.WriteLine("Bienvenue à la loterie nationale belge, une fois!");
                break;
            case "française":
                Console.WriteLine("Bienvenue à la loterie nationale françaiseanh");
                break;
            case "suisse":
                Console.WriteLine("Bienvenueeeuhhh à la loterieeeuhhh nationaleeeuhhh suisseeeuhhh");
                break;
            case "canadienne":
                Console.WriteLine("Bienvenue à la loterie nationale canadienne, tabernacle!");
                break;
            default:
                Console.WriteLine("Désolé, mais vous n'êtes pas né du bon côté de la frontière...");
                break;
        }
    }
    else
    {
        Console.WriteLine($"Reviens dans {LIMIT_AGE - age} ans.");
    }
}
else
{
    Console.WriteLine("Veuillez entrer un nombre correct.");
}
