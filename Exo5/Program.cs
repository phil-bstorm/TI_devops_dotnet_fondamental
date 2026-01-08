// Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).
{
    /* First x prime numbers using one loop only */
    Console.Write("Input a non null positive number of prime numbers you wish to know : \n> ");
    int input;
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
    List<int> primes = new List<int>();
    int number = 2;
    int divisorIndex = 0;
    bool isPrimeNumber = true;
    for (; primes.Count < input; number++)
    {
        if (divisorIndex < primes.Count && primes[divisorIndex] * primes[divisorIndex] <= number)
        {
            if (number % primes[divisorIndex] == 0)
            {
                isPrimeNumber = false;
            }
            divisorIndex++;
            number--;
        }
        else
        {
            if (isPrimeNumber)
            {
                primes.Add(number);
                Console.WriteLine($"{primes.Count} : {number}");
            }
            divisorIndex = 0;
            isPrimeNumber = true;
        }
    }
}

// Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que caractère par
// caractère. (Méthode « ToCharArray() » de la classe « string »).
{
    Console.WriteLine("Mettez le premier nombre entier à additonner = ");
    string nb1str = Console.ReadLine();
    char[] nb1ar = nb1str.ToCharArray();
    List<int> nb1list = new List<int>();
    for (int i = 0; i < nb1ar.Count(); i++)
    {
        string temp = nb1ar[i].ToString();
        int nbx = int.Parse(temp);
        nb1list.Add(nbx);
        Console.WriteLine((String.Join(",", nb1list)));
    }

    Console.WriteLine("Mettez le deuxieme nombre entier à additonner = ");
    string nb2str = Console.ReadLine();
    char[] nb2ar = nb2str.ToCharArray();
    List<int> nb2list = new List<int>();
    for (int i = 0; i < nb2ar.Count(); i++)
    {
        string temp = nb2ar[i].ToString();
        int nbx = int.Parse(temp);
        nb2list.Add(nbx);
        Console.WriteLine((String.Join(",", nb2list)));
    }

    // Fait en sorte que les 2 tableaux ont la même taille
    int countDif = Math.Abs(nb1list.Count() - nb2list.Count());
    Console.WriteLine(countDif);

    if (nb1list.Count() > nb2list.Count())
    {
        while (countDif != 0)
        {
            nb2list.Insert(0, 0);
            countDif--;
        }
    }
    if (nb1list.Count() < nb2list.Count())
    {
        while (countDif != 0)
        {
            nb1list.Insert(0, 0);
            countDif--;
        }
    }

    Console.WriteLine($"{nb1list.Count()} / {nb2list.Count()}");

    // récupération du nombre de caractères
    int maxLenght = nb1list.Count();

    int sommeLocale = 0;
    int surplus = 0;
    int reste = 0;
    List<int> somme = new List<int>();
    // somme des caractères: caractère par caractère (avec le report)
    for (int i = 0; i < maxLenght; i++)
    {
        sommeLocale = nb1list[maxLenght - 1 - i] + nb2list[maxLenght - 1 - i] + surplus;
        if (sommeLocale >= 10)
        {
            reste = sommeLocale % 10;
            surplus = sommeLocale / 10;
        }
        somme.Insert(0, reste);
    }
    somme.Insert(0, surplus);
    Console.WriteLine($"Votre somme finale est de {(String.Join(",", somme))}");
}
{

}