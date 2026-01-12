using Exo8.CustomEnums;

namespace Exo8.Models
{
    public struct Card
    {
        public CardColorEnum Color;
        public CardValueEnum Value;

        public Card(CardColorEnum color, CardValueEnum value)
        {
            Color = color;
            Value = value;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Color} - {Value}");
        }
    }
}
