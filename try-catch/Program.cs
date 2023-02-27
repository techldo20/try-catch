
using System;

namespace trycatch
{
    class Program
    {
        static void Main()
        {
            int konec = 0;

            while (konec == 0)
            {
                int[] numArray = { 1, 2, 3, 4, 5, 6 };

                Console.WriteLine("Napište číslo");
                Console.Write("->");
                int cislo;


                while (!Int32.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Napište číslo");
                    Console.Write("->");
                }

                Console.WriteLine();

                try
                {
                    if (cislo < 0)
                    {
                        throw new NegativeNumberException("Číslo nesmí být záporné");
                    }

                    Console.WriteLine(numArray[cislo]);
                }
                catch (IndexOutOfRangeException x)
                {
                    Console.WriteLine("Vyskytla se chyba: " + x.Message);
                }
                catch (NegativeNumberException x) 
                {
                    Console.WriteLine(x.Message);
                }

                Console.WriteLine();
            }
        }
    }

    class NegativeNumberException : Exception
    {
        public NegativeNumberException() { }

        public NegativeNumberException(string message) : base(message) {}
    }
}