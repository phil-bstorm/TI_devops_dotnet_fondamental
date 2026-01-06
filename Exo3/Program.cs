/*
Calcule de la division entière, du modulo et de la division de deux entiers.
Résultat attendu pour 5 et 2 🡪 Division entière : 2, Modulo : 1, Division : 2,5.
*/

using System.Text.RegularExpressions;

Console.WriteLine("Veuillez encoder 2 nombres entiers: ");
Console.Write("> nb1 : ");
bool success = int.TryParse(Console.ReadLine(), out int nb1);
if (!success)
{
    Console.WriteLine("Entrée invalide");
    return;
}

Console.Write("> nb2 : ");
success = int.TryParse(Console.ReadLine(), out int nb2);
if (!success)
{
    Console.WriteLine("Entrée invalide");
    return;
}

if (nb2 == 0)
{
    Console.WriteLine("La division par zéro est impossible.");
}

Console.WriteLine("Résultats: ");
int div = nb1 / nb2;
Console.WriteLine($"{nb1} DIV {nb2} = {div}");
int reste = nb1 % nb2;
Console.WriteLine($"{nb1} % {nb2} = {reste}");
float div_f = (float)nb1 / nb2;
Console.WriteLine($"{nb1} / {nb2} = {div_f}");


/*
Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. 
Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
(utilisez la méthode « Substring » de la classe « string »).
*/

Console.Write("Donner un numéro de compte à vérifier: ");
string input = Console.ReadLine();

// vérifiez que l'utilisateur a bien encodé 12 caractères.
//if(input.Length != 12)
//{
//    Console.WriteLine("Votre numéro doit faire 12caractères");
//    return;
//}

// regex
// azertyuiopq
string pattern = @"^\d{12}$";
Regex rg = new Regex(pattern);
if (!rg.IsMatch(input))
{
    Console.WriteLine(input.Length);
    // si l'entrée utilisateur ne correspond pas, on affiche:
    Console.WriteLine("Votre numéro doit faire 12caractères");
    return;
}

long valueAccount = long.Parse(input.Substring(0, 10));
int validator = int.Parse(input.Substring(10, 2));

//long valueToCheck = valueAccount % 97; // peut être caster en INT pour prendre moins d'espace mémoire
int valueToCheck = (int)(valueAccount % 97);

if ((valueToCheck == 0 && validator == 97) || valueToCheck == validator)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("NOK");
}


// Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN (BExx-xxxx-xxxx-xxxx). Trouvez la démarche via un moteur de recherche.

// Valeur pour générer l'IBAN = BBAN + BE(1114) + 00
long temp = long.Parse(input + "1114" + "00");

// Chiffre de control : 98 - (le reste de "temp" par 97)
int controlIBAN = (int)(98 - (temp % 97));

string iban = "BE" + controlIBAN + input;

Console.WriteLine("Version IBAN: " + iban);