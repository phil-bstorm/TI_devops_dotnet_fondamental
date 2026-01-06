// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemple operateurs!");

#region TERNAIRE
// ON / OFF
bool allumer = true;
string phrase = allumer ? "La lumière est allumée" 
    : "La lumière est éteinte";

// si la note = 20 = divin
// si la note > 18 = good
// sinon at least you tried
int note = 15;
string description = note == 20 ? "Divin" :
                        note > 18 ? "Good" :
                        "At least you tried";

#endregion

#region COALESCE
{
    string? text = null;

    string textObligatoire = "";

    // version if..else
    if(text is null)
    {
        textObligatoire = "Je ne peux pas etre vide.";
    }
    else
    {
        textObligatoire = text;
    }

    // version COALESCE
    textObligatoire = text ?? "Je ne peux pas etre vide.";


    int? nbrNull = null;
    int nbr = nbrNull ?? 42;
}
#endregion

#region uncheck
{
    //int nbr = int.MaxValue;
    //Console.WriteLine(nbr);
    //nbr += 10;
    //Console.WriteLine(nbr);

    int nbr = int.MaxValue;
    Console.WriteLine(nbr);
    nbr = checked(nbr + 10);
    Console.WriteLine(nbr);
}
#endregion