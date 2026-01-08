namespace Demo7_Methode.Tools
{
    public struct MathHelper
    {
        public double Multi(double nb1, double nb2)
        {
            return Math.Round(nb1 * nb2, 2);
        }

        public double Multi(params double[] nbs)
        {
            double total = 1;
            for (int i = 0; i < nbs.Length; i++)
            {
                total *= nbs[i];
            }
            return total;
        }
    }
}
