
#region boucle FOR

Console.WriteLine("Boucle for 0 -> 9");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"\t le compteur: {i}");
}

Console.WriteLine("Boucle for 0 -> 9");
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine($"\t le compteur: {i}");
}

Console.WriteLine("Boucle for 10 -> 0");
for (int i = 10; i >= 0; i -= 2)
{
    Console.WriteLine($"\t le compteur: {i}");
}
#endregion

#region boucle While
{
    bool continuer = true;
    while (continuer)
    {
        Console.WriteLine("Let's go");
        string input = Console.ReadLine();
        if (input == "exit")
        {
            continuer = false;
        }
    }
}
#endregion

#region boucle do...While
{
    Console.WriteLine("DO WHILE");
    bool continuer = false;
    do
    {
        Console.WriteLine("Let's go");
        string input = Console.ReadLine();
        if (input == "exit")
        {
            continuer = false;
        }
        else
        {
            continuer = true;
        }
    } while (continuer);
}
#endregion