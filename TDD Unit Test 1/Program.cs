using System;

namespace TDD_Unit_Test_1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int resultat = Addition(a, b);

            if (resultat != 3)
                Console.WriteLine("Le test a raté");
            else
                Console.WriteLine("Le test est OK");
        }
        
        public static int Addition(int a, int b)
        {
            return a + b;
        }*/
        static void Main(string[] args)
        {
            string phrase1 = "";
            if (CompteMots(phrase1) != 0)
                Console.WriteLine("Echec du test");
        }

        public static int CompteMots(string phrase)
        {
            return 0;
        }
    }
}
