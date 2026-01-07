// Calculer les 25 premiers nombres de la suite de Fibonacci
// Suite de Fibonacci : https://fr.wikipedia.org/wiki/Suite_de_Fibonacci.
{
    Console.WriteLine("Suite de Fibonacci :");
    int cpt = 0;
    int nbrStart = 0;
    int nbrMid = 1;
    int nbrNext = 0;

    for (cpt = 0; cpt < 25; cpt++)
    {
        Console.WriteLine($"{cpt + 1} : {nbrStart}");
        nbrNext = nbrStart + nbrMid;
        nbrStart = nbrMid;
        nbrMid = nbrNext;
    }
}

Console.WriteLine();
Console.WriteLine(new String('=', 12));
Console.WriteLine();

// Calculer le factoriel d’un nombre entré au clavier
// Factorielle https://fr.wikipedia.org/wiki/Factorielle
{

    Console.Write("Entre le nombre : \n");
    bool sucess = int.TryParse(Console.ReadLine(), out int nbr1);
    int resultat = 1;

    // nbr1  = 5
    // 5 x 4 x 3 x 2 = 120
    for (int i = nbr1; i > 1; i--)
    {
        Console.WriteLine("i = {0}", i);
        resultat *= i;
    }

    Console.WriteLine("la factorielle de {0} est {1}", nbr1, resultat);
}

Console.WriteLine();
Console.WriteLine(new String('=', 12));
Console.WriteLine();

// Grâce à une boucle « for », calculez les x premiers nombre premier.
/* x first prime numbers */
Console.Write("Input a non null positive number of prime numbers you wish to know : \n> ");
int input;
int count = 0;
bool parse = int.TryParse(Console.ReadLine(), out input);
// user input
while (!parse || input <= 0)
{
    if (!parse)
    {
        Console.WriteLine("Invalid input");
    }
    if (input < 0)
    {
        Console.WriteLine("Please input a non null positive number");
    }
    Console.Write("Input a non null positive number of prime numbers you wish to know : \n> ");
    parse = int.TryParse(Console.ReadLine(), out input);
}

// math
for (int number = 2; count < input; number++)
{
    bool isPrimeNumber = true;
    for (int divisor = 2; divisor * divisor <= number; divisor++)
    {
        if (number % divisor == 0)
        {
            isPrimeNumber = false;
            break;
        }
    }
    if (isPrimeNumber)
    {
        Console.WriteLine($"{count + 1} : {number}");
        count++;
    }
}

Console.WriteLine();
Console.WriteLine(new String('=', 12));
Console.WriteLine();

// A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 »
{
    Console.WriteLine("Table de multiplication");
    int multiplication = 0;

    for (int j = 1; j <= 20; j++)
    {
        string result = "";

        for (int i = 1; i <= 5; i++)
        {
            multiplication = i * j;

            result = result + i + " * " + j + " = " + multiplication + "\t";
        }

        Console.WriteLine(result);
    }
}

Console.WriteLine();
Console.WriteLine(new String('=', 12));
Console.WriteLine();

// BONUS: avec une seule boucle! (❁´◡`❁)
{
    int table = 1;
    Console.WriteLine("Table de multiplication (avec une seule boucle) (❁´◡`❁)");

    Console.WriteLine($"Table de multiplication de {table}");
    for (int multi = 1; table <= 5; multi++)
    {
        Console.WriteLine($"\t {multi} x {table} = {multi * table}");

        if (multi >= 20)
        {
            table++;
            multi = 0;
            if (table <= 5)
            {
                Console.WriteLine($"Table de multiplication de {table}");
            }
        }
    }

}

Console.WriteLine();
Console.WriteLine(new String('=', 12));
Console.WriteLine();

// À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, et afficher la valeur à chaque itération.
// Remarquez - vous quelque chose de particulier ?
{
    Console.WriteLine("Test addition double");
    double nbr = 0.0d; 
    for(double i = 0.0d; i < 20; i+= 0.1d)
    {
        nbr += i;
        Console.WriteLine($"\t nbr = {nbr} | i = {i}");
    }

    // le type double binaire (puissance de 2) pour représenter les nombres décimaux
    // malheuresement, 0.1 ne peut pas être représenter de manière en binaire
}

{
    Console.WriteLine("Test addition float");
    float nbr = 0.0f;
    for (float i = 0.0f; i < 20; i += 0.1f)
    {
        nbr += i;
        Console.WriteLine($"\t nbr = {nbr} | i = {i}");
    }
}

{
    Console.WriteLine("Test addition decimal");
    decimal nbr = 0.0m;
    for (decimal i = 0.0m; i < 20; i += 0.1m)
    {
        nbr += i;
        Console.WriteLine($"\t nbr = {nbr} | i = {i}");
    }
}

{
    Console.WriteLine("test addition int (recommencer pour éviter les erreurs d'arrondis");
    int nbr = 0;
    // si je travail avec une décimal, il faut multiplier par 10.
    for(int i = 0; i < 200; i += 1)
    {
        nbr += i; // pas de probleme d'arrondis dans le calcule
                  // récupérer l'arrondis, il faut diviser par 10
        Console.WriteLine($"\t nbr = {nbr/10.0} | i = {i/10.0}");
    }
}

// Calculer la racine carré d’un nombre avec maximum 10 décimales (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse)
// https://fr.wikipedia.org/wiki/Extraction_de_racine_carr%C3%A9e (SPOIER: méthode dichotomie)