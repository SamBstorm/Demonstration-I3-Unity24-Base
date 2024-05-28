Personne?[,] eleves = new Personne?[3,5];

//foreach (Personne? etudiant in eleves)
//{
//    Console.WriteLine(etudiant);
//}

Personne sveva;
sveva.prenom = "Sveva";
sveva.nom = "Grippa";
eleves[0,0] = sveva;
Personne m_a;
m_a.prenom = "Marie-Astrid";
m_a.nom = "Buelens";
eleves[0,2] = m_a;


for(int range = 0; range < 3; range++)
{
    for(int place = 0; place < 5; place++)
    {
        Personne? etudiant = eleves[range,place];
        if(etudiant is null)
        {
            Console.Write("Pas d'étudiant\t");
        }
        else
        { 
            Console.Write($"Prénom : {((Personne)etudiant).prenom} ; Nom : {((Personne)etudiant).nom}\t");
        }
    }
    Console.WriteLine();
}

public struct Personne
{
    public string prenom;
    public string nom;
}