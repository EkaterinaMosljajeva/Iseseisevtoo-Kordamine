using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//variant 9

namespace Iseseisevtoo_Kordamine
{
    public class StartClass
    {
        public static void Main()
        {
            Random rnd = new Random();

            int[,] kvad = new int[10, 10];

            for (int i = 0; i < kvad.GetLength(0); i++)
            {
                for (int j = 0; j < kvad.GetLength(1); j++)
                {
                    kvad[i, j] = rnd.Next(1, 11);
                }
            }

            for (int i = 0; i < kvad.GetLength(0); i++)
            {
                for (int j = 0; j < kvad.GetLength(1); j++)
                {
                    Console.Write(kvad[i,j]+" ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            double proizv = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sum += kvad[i, j];
                    proizv *= kvad[i, j];
                    Console.WriteLine(proizv);
                }
            }

            Console.Write("Summa: {0}\nKorrutamine: {1}\n", sum, proizv);

            Console.WriteLine("-----------------------");

            int a1 = 7, b1 = 4, c1 = 5;
            int a2 = 5, b2 = 8, c2 = 7;
            int a3 = 8, b3 = 10, c3 = 3;

            int p1 = a1 + b1 + c1;
            int p2 = a2 + b2 + c2;
            int p3 = a3 + b3 + c3;

            double p0 = Math.Max(Math.Max(p1, p2), p3);

            double s1 = Math.Round(Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1)), 2);
            double s2 = Math.Round(Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2)), 2);
            double s3 = Math.Round(Math.Sqrt(p3 * (p3 - a3) * (p3 - b3) * (p3 - c3)),2);

            double s0 = Math.Max(Math.Max(s1, s2), s3);

            if (p0 == p1)
            {
                Console.WriteLine("Esimese kolmnurga ümbermõõt on suurim: " + p0);
            }
            else if (p0 == p2)
            {
                Console.WriteLine("Teisel kolmnurgal on suurim ümbermõõt: " + p0);
            }
            else
            {
                Console.WriteLine("Kolmas kolmnurk on suurima ümbermõõduga: " + p0);
            }

            if (s0 == s1)
            {
                Console.WriteLine("Esimese kolmnurga pindala on suurim: " + s0);
            }
            else if (s0 == s2)
            {
                Console.WriteLine("Teisel kolmnurgal on suurim pindala: " + s0);
            }
            else
            {
                Console.WriteLine("Kolmas kolmnurgal on suurim pindala: " + s0);
            }

            Console.WriteLine("-----------------------");

            List<string> perenimed = new List<string> { "Ivanov", "Petrov", "Sidorov", "Andreev" };
            perenimed.Sort();
            foreach (string perenimi in perenimed)
            {
                Console.Write(perenimi + " ");
            }
            Console.WriteLine("\n-----------------------");
        }
    }
}
