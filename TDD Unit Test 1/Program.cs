using System;

namespace TDD_Unit_Test_1
{
    class Program
    {
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
