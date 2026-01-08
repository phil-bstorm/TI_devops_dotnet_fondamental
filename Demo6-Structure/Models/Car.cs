namespace Demo6_Structure.Models
{
    public struct Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Power;

        public Car(string brand, string model, string color, int power)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Power = power;
        }

        public void FaitDuBruit()
        {
            Console.WriteLine("Vroom.");
            return; // optionel
        }
    }
}
