using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BAI_College_6
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Opgave 1
                int[] intArray = new int[80];
                Random rnd = new Random();
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = rnd.Next(0, 2);
                }
                intArray.ToList().ForEach(getal => Console.Write(getal));
                Console.WriteLine();

                SortZeroesOnes(intArray);

                Console.WriteLine();

                List<int> integerList = new List<int>();
                int grootste = int.MinValue;
                List<int> grootsteIndexes = new List<int>();
                for (int i = 0; i < 60; i++)
                {
                    integerList.Add(rnd.Next(41, 100));
                }
                for (int i = 0; i < integerList.Count; i++)
                {
                    if (grootste < integerList[i])
                    {
                        grootste = integerList[i];
                        grootsteIndexes.Clear();
                    }
                    if (grootste == integerList[i])
                    {
                        grootsteIndexes.Add(i);
                    }
                    Console.WriteLine($"Index: {i},\tValue: {integerList[i]}");
                }
                Console.Write($"Grootste: {grootste} op index: ");
                grootsteIndexes.ForEach(index => Console.Write($"{index} "));
                Console.WriteLine();
            }
            public static void SortZeroesOnes(int[] intArray)
            {
                int aantalNullen = 0;
                for (int i = 0; i < intArray.Count(); i++)
                {
                    if (intArray[i] == 0)
                    {
                        aantalNullen++;
                    }
                }

                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = i < aantalNullen ? 0 : 1;
                }
                intArray.ToList().ForEach(getal => Console.Write(getal));
                Console.WriteLine();
            }
        }
    }
}