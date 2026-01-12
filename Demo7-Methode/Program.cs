using Demo7_Methode.Tools;

namespace Demo7_Methode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MathHelper mh = new MathHelper();
            double resultat = mh.Multi(0.445, 0.3);
            Console.WriteLine(resultat);

            resultat = mh.Multi(0.566, 0.7);
            Console.WriteLine(resultat);

            Console.WriteLine(new string('=', 12)); // ===========

            int[] tabInts = { 1, 2, 3, 4, 5 };
            TableauHelper th = new TableauHelper();
            th.DisplayInts(tabInts);
            th.DisplayInts(tabInts, ", ");
            th.DisplayInts(tabInts, "\n");

            Console.WriteLine(new string('=', 12)); // ===========

            string s = null;
            //int? tailleS = s?.Length;
            //Console.WriteLine(tailleS);
            if(s is not null)
            {
                int tailleS = s.Length;
            }

            Console.WriteLine(new string('=', 12)); // ===========

            // Utilisation de params dans la méthode
            double resultatR = mh.Multi(0.2, 5, 0.6, 07, 0.9999);

            Console.WriteLine(new string('=', 12)); // ===========

            int a = 1;
            mh.PlusUn(a);
            Console.WriteLine(a);

            mh.PlusUnRef(ref a);
            Console.WriteLine(a);

            List<string> courses = new List<string>();
            courses.Add("Patates");
            th.AjouterPoire(courses);
            Console.WriteLine(courses.Count());

            Console.WriteLine(new string('=', 12)); // ===========
            mh.Addition(1, 1);
            mh.Addition("5", "6");
        }
    }
}
