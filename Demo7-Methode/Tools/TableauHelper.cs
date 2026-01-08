using System;
using System.Collections.Generic;
using System.Text;

namespace Demo7_Methode.Tools
{
    public struct TableauHelper
    {
        public void DisplayInts(int[] tab, string sperator = "-.-.-")
        {
            for (int i = 0; i < tab.Length; i++) {
                Console.Write(tab[i]);
                if (i < tab.Length - 1)
                {
                    Console.Write(sperator);
                }
            }
            Console.WriteLine();
        }
    }
}
