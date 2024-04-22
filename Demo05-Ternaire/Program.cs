Console.WriteLine("Veuillez m'indiquer un temps en secondes :");

string input = Console.ReadLine();

bool isConverted = int.TryParse(input, out int temps);

if (isConverted)
{
    int minutes = temps / 60;
    int seconds = temps % 60;   // temps - (minutes * 60);
    int hours = minutes / 60;
    minutes = minutes % 60;     // minutes - (hours * 60);
    int days = hours / 24;
    hours = hours % 24;         // hours - (days * 24);
    Console.WriteLine(
        $"{temps} seconde{((temps > 1)?"s":"")} correspondent à : " +
        $"{days} jour{((days > 1) ? "s" : "")}, " +
        $"{hours} heure{((hours > 1) ? "s" : "")}, " +
        $"{minutes} minute{((minutes > 1) ? "s" : "")} " +
        $"et {seconds} seconde{((seconds > 1) ? "s" : "")}.");
}
else
{
    Console.WriteLine($"\"{input}\" n'est pas un nombre entier.");
}

