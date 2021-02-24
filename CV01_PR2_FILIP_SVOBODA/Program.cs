using System;

namespace CV01_PR2_FILIP_SVOBODA
{
    class Program
    {
        static void Main(string[] args)
        {
            char Pismeno = 'a';
            while (Pismeno != ('z' + 1))
            {
                Console.WriteLine(Pismeno);
                Pismeno++;
            }
        }
    }
}
