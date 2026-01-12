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

        public void PlusUn(int nombre)
        {
            nombre++;
        }

        public void PlusUnRef(ref int nombre)
        {
            nombre++;
        }

        public int Addition(int a, int b)
        {
            return a + b; 
        }

        public int Addition(string a, string b)
        {
            int aI = int.Parse(a);
            int bI = int.Parse(b);

            return aI + bI;
        }
    }
}
