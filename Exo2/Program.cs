// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exo 2 - switch case!");

/*
 à l'aide d'un switch réaliser une machine à boisson:
Si l'utilisateur entre "1", affiche "Café noir - 1,20€"
Si l'utilisateur entre "2", affiche "Chocolat chaud - 1,50€"
Si l'utilisateur entre "3", affiche "Thé vert - 1,00€"
Si l'utilisateur se trompe, affiche "Choix invalide, veuillez réessayer plus tad quand on aura vu les boucles."
*/

Console.Write("Veuillez choisir une boisson (entre 1 et 3): >");
string input = Console.ReadLine();
bool parseSuccess = int.TryParse(input, out int result);
if (parseSuccess)
{
    // TODO switch
    switch (result)
    {
        case 1:
            Console.WriteLine("Café noir - 1,20€");
            break;
        case 2:
            Console.WriteLine("Chocolat chaud - 1,50€");
            break;
        case 3: 
            Console.WriteLine("Thé vert - 1,00€"); 
            break;
        default:
            Console.WriteLine("Choix invalide, veuillez réessayer plus tad quand on aura vu les boucles.");
            break;
    }
}
else
{
    Console.WriteLine("Entrée invalide.");
}