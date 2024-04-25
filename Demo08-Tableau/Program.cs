string[] nomEleves = //new string[16];
    [
    "Sveva",
    "Chloé",
    "Aïcha",
    "Kiara",
    "Dounia",
    "Lison",
    "Charlotte",
    "Luna",
    "Gweny",
    "Alex",
    "Marie-Laure",
    "May"
];

int nbEleves;
do
{
    Console.Clear();
    Console.WriteLine($"Vous avez {nomEleves.Length} emplacements. Combien d'élèves sont présent?");
}
while (!int.TryParse(Console.ReadLine(), out nbEleves) || nbEleves > nomEleves.Length);

for (int i = 0; i < nbEleves; i++)
{
    Console.WriteLine($"Quel est le nom de l'élève numéro {i+1} :");
    nomEleves[i] = Console.ReadLine();
}


Console.WriteLine($"La classe des UNITY24 comportent {nomEleves.Length} :");
for ( int i = 0; i < nomEleves.Length; i++)
{
    Console.WriteLine($"\t- {nomEleves[i]}");
}
