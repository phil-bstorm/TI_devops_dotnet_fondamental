namespace Exo7.Models
{
    public struct Celsius
    {
        public double Temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f;

            f.Temperature = Math.Round((Temperature * 1.8 ) + 32, 2);

            return f;
        }
    }
}
