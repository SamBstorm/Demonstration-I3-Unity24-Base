/*
////Le Console.WriteLine() est une procédure (le type de retour est void) car nous n'attendons aucune valeur à la fin de l'éxécution
//Console.WriteLine("Hello, World!");

////public void WriteLine(string text)


////Le Console.ReadLine() est une fonction (le type de retour est string) car nous attendons une valeur à la fin de l'éxécution
//string valeur = Console.ReadLine();

////public string? ReadLine()
*/

Mathematique math;

math.ShowCalcul(5,3);
math.ShowCalcul(5,3,mustBeSolved : true);
math.ShowAddition(5,3);

//int? quotient = math.Division(7, 0);
//if (quotient is null)
//{
//    math.ShowCalcul(7, 0, '/');
//    Console.WriteLine("Division impossible");
//}
//else
//{
//    math.ShowCalcul(nb1: 7, operateur: '/', nb2: 0);
//    Console.WriteLine($"Le résultat de la division est {quotient}.");
//}

int quotient;
if (math.TryDivide(7, 0, out quotient))
{
    Console.WriteLine($"La division est possible : {quotient}");
}
else
{
    Console.WriteLine($"La division est impossible, quotient récupère sa valeur par défaut : {quotient}");
}
Console.WriteLine();
Console.WriteLine( math.Addition(5.2,3).ToString("#.#0") );
Console.WriteLine( 5 );
public struct Mathematique
{
    public int Addition(int nb1, int nb2)
    {
        return nb1 + nb2;
    }
    public double Addition(double nb1, double nb2)
    {
        return nb1 + nb2;
    }
    
    public void ShowAddition(int nb1, int nb2)
    {
        Console.WriteLine($"{nb1} + {nb2} = {nb1+nb2}");
        return;
    }

    public void ShowCalcul(int nb1, int nb2, char operateur = '+', bool mustBeSolved = false)
    {
        if (!mustBeSolved)
        {
            Console.WriteLine($"{nb1} {operateur} {nb2} = ???");
        }
        else
        {
            switch (operateur)
            {
                case '+':
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {nb1 + nb2}");
                    break;
                case '-':
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {nb1 - nb2}");
                    break;
                case '/':
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {nb1 / nb2}");
                    break;
                case '*':
                    Console.WriteLine($"{nb1} {operateur} {nb2} = {nb1 * nb2}");
                    break;
            }
        }
    }

    public int? Division(int nb1, int nb2)
    {
        if (nb2 != 0)
        {
            return nb1 / nb2;
        }
        return null;
    }

    public bool TryDivide(int nb1, int nb2, out int result)
    {
        result = default;
        if (nb2 == 0)
        {
            return false;
        }
        result = nb1 / nb2;
        return true;
    }
}