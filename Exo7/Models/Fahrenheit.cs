namespace Exo7.Models
{
    public struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius() 
        {
            Celsius c;

            c.Temperature = Math.Round((Temperature - 32) / 1.8, 2);

            return c;
        }
    }
}
