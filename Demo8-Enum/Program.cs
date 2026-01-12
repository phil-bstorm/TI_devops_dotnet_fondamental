using Demo8_Enum.CustomEnums;

namespace Demo8_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PieceEnum p1 = PieceEnum.Reine;

            Console.WriteLine("Valeur 1");
            foreach (int item in Enum.GetValues(typeof(PieceEnum)))
            {
                Console.WriteLine($"- {item} / {(PieceEnum)item}");
            }
            Console.WriteLine();

            Console.WriteLine("Valeur 2");
            foreach (int item in Enum.GetValues<PieceEnum>())
            {
                Console.WriteLine($"- {item} / {(PieceEnum)item}");
            }
            Console.WriteLine();

            // Parcourir les noms de l'enum
            Console.WriteLine("Nom 1");
            foreach (string item in Enum.GetNames(typeof(PieceEnum)))
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine("Nom 2");
            foreach (string item in Enum.GetNames<PieceEnum>())
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
