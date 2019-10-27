using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege2
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Opdracht 2
        int x;
        Random r = new Random();
        const int MAXNUMS = 60;
        int max = 0;
        int grootste_index;

        int[] nums = new int[MAXNUMS];
        for (int i = 0; i < MAXNUMS; i++)
        {
            x = r.Next(100);
            nums[i] = x;
        }

        foreach (int n in nums)
        {
            Console.Write($"{n} ");
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"Het grootste getal uit de reeks is {max}");
        */

        /* opdracht 3
        int x;
        Random r = new Random();
        const int MAXNUMS = 500;
        int min = 500;
        int aantalMin = 0;
        int grootste_index;

        int[] nums = new int[MAXNUMS];
        for (int i = 0; i < MAXNUMS; i++)
        {
            x = r.Next(100);
            nums[i] = x;
            if (nums[i] < min)
            {
                min = nums[i];
                aantalMin = 1;
            }
            else if (nums[i] == min)
            {
                aantalMin++;
            }
        }

        foreach (int n in nums)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine($"Het kleinste getal uit de reeks is {min} en dat komt {aantalMin} keer voor. ");
    */

        /* opdracht 3 tips 
        int x;
        int grootteArray = 10;
        int[] array = new int[grootteArray];

        for (int i = 0; i < 10; i++)
        {
            array[i] = i + 1;
            Console.WriteLine(array[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            array[i] = 10 - i;
            Console.WriteLine(array[i]);
        }
        */

        /* opdracht 4
        string input = "";
        int x;
        int laatsteCijfer = 0;
        List<int> cijfers = new List<int>();

        while (input != "0")
        {
            Console.WriteLine("Please enter a number");
            input = Console.ReadLine();

            if (Int32.TryParse(input, out int j))
            {
                x = j;

                if (x > 0)
                {
                    for (int i = 0; i < x; i++)
                    {
                        cijfers.Add(x);
                    }
                }
                else if (x < 0)
                {
                    for (int i = 0; i < -x; i++)
                    {
                        cijfers.RemoveAt(cijfers.Count-1);
                    }
                }
            }
            else { Console.WriteLine("Please enter a number"); }
        }

        laatsteCijfer = cijfers[cijfers.Count-1];
        Console.Write($"Aantal elementen in de array: {cijfers.Count} \nLaatste element in de array: {laatsteCijfer}\n ");
        foreach (int cijfer in cijfers)
        {
            Console.WriteLine(cijfer);
        }
         */
        /* opgave 6 

        int grootteArray = 19;
        List<int> array = new List<int>();

        for (int i = 0; i < grootteArray; i++)
        {
            array.Add(i);
            Console.Write(array[i] + " ");
        }

        //fout
        for (int i = 0; i < array.Count -1; i++)
        {
            if (i % 2 == 0)
            {
                array.RemoveAt(i);
            }
        }

        Console.WriteLine();
        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i] + " ");
        }

        int[,] matrix = new int[6, 6] {
        {0, 50, 135, 120, 65, 65},
        {50, 0, 140, 75, 20, 70},
        {135, 140, 0, 220, 170, 75},
        {120, 75, 220, 0, 55, 145},
        {65, 20, 170, 55, 0, 90},
        {65, 70, 75, 145, 90, 0}      };

        string[] plaatsnaam = new string[] { "Arnhem", "Amersfoort", "Assen", "Rotterdam", "Utrecht", "Zwolle" };

        int minAfstand = 2147483647; //biggest value for int :)
        int indexMinAfstand = 0;
        int afstand = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                afstand += matrix[i,j];
            }
            if (afstand < minAfstand)
            {
                minAfstand = afstand;
                indexMinAfstand = i;
            }
            Console.WriteLine($"{plaatsnaam[i]}: {afstand}km");
            afstand = 0;
        }
        Console.WriteLine($"Minimum afstand is: {plaatsnaam[indexMinAfstand]} met {minAfstand * 5}km");*/
        }
    }
}
