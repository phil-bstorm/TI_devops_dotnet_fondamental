// See https://aka.ms/new-console-template for more information
Console.WriteLine("Superbe calculette!");

{
    // Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, la conversion devra utiliser la méthode « int.Parse() »

    //string inputNbr1 = Console.ReadLine();
    //int nbr1 = int.Parse(inputNbr1);
    //int nbr1 = Convert.ToInt32(inputNbr1);

    Console.WriteLine("Entrez un nombre: ");
    int nbr1 = int.Parse(Console.ReadLine());
    Console.Write("Entrez un nombre: ");
    int nbr2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Total: " + (nbr1 + nbr2));
}

{
    // Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, la conversion devra utiliser la méthode « int.TryParse() »
    string inputNbr1 = Console.ReadLine();
    bool success = int.TryParse(inputNbr1, out int nbr1);
    if (success)
    {
        string inputNbr2 = Console.ReadLine();
        success = int.TryParse(inputNbr2, out int nbr2);
        if (success)
        {
            Console.WriteLine("Total: " + (nbr1 + nbr2));
        }
        else
        {
            Console.WriteLine("Entrée invalide");
        }
    }
    else
    {
        Console.WriteLine("Entrée invalide");
    }
}