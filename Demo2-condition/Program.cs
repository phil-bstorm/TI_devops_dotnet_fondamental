Console.WriteLine("Demo IF");

#region if
{
    bool estValide = true;
    if (estValide)
    {
        Console.WriteLine("Le bool est valide!");
        string ici = "je suis dans le if";
    }

    //Console.WriteLine(ici); la variable "ici" est déclarée dans un scope (les accolades {})

    if (!estValide)
    {
        Console.WriteLine("Inverse de valide");
    }
}
#endregion

#region if else
{
    bool estValide = true;
    if (estValide)
    {
        Console.WriteLine("Est valide");
    }
    else
    {
        Console.WriteLine("est invalide");
    }
}
#endregion

#region if ... else if ... else
{
    bool estValide = false;
    int nombre = 5;
    if (estValide)
    {
        Console.WriteLine("Est valide");
    }
    else if (nombre == 5)
    {
        Console.WriteLine("Le nombre est égale à 5.");
    }
    else
    {
        Console.WriteLine("est invalide");
    }
}
#endregion

#region Switch
{
    Console.Write("Entre un nombre: \n>");
    string input = Console.ReadLine();
    switch (input) {
        case "42":
            Console.WriteLine("La réponse à la vie.");
            break;
        case "lundi":
            Console.WriteLine("On n'est pas lundi");
            break;
        case "faim":
            Console.WriteLine("Moi aussi.");
            break;
        default:
            Console.WriteLine("Raclette.");
            break ;
    }
}
#endregion