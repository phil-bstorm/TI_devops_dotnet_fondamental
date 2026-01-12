using Exo8.CustomEnums;
using Exo8.Models;

Card[] decks = new Card[52]; // 52 car il y a 52 cartes dans un jeu de carte.

Console.WriteLine("Initialisé");

int index = 0;
//foreach (CardColorEnum c in Enum.GetValues(typeof(CardColorEnum)))
foreach (CardColorEnum c in Enum.GetValues<CardColorEnum>())
{
    foreach (CardValueEnum v in Enum.GetValues<CardValueEnum>())
    {
        decks[index].Color = c;
        decks[index].Value = v;
        index++;
    }
}

Console.WriteLine("Listing:");
foreach(Card card in decks)
{
    //Console.WriteLine($"{card.Color} - {card.Value}");
    card.GetInfo();
}