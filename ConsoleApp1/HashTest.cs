using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BAI_College_5
    {
        class HashTest
        {
            public static HashSet<int> EvenToHundred()
            {
                HashSet<int> setEvenUpToHundred = new HashSet<int>();
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        setEvenUpToHundred.Add(i);
                    }
                }
                return setEvenUpToHundred;
            }

            public static HashSet<int> EightToHundred()
            {
                HashSet<int> setContainsEight = new HashSet<int>();
                for (int i = 0; i < 100; i++)
                {
                    if (i.ToString().Contains("8"))
                    {
                        setContainsEight.Add(i);
                    }
                }
                return setContainsEight;
            }

            public static HashSet<int> SevenToHundred()
            {
                HashSet<int> setMultiSeven = new HashSet<int>();
                for (int i = 0; i < 100; i++)
                {
                    if (i % 7 == 0)
                    {
                        setMultiSeven.Add(i);
                    }
                }
                return setMultiSeven;
            }

            public static HashSet<int> UniversalHashSet()
            {
                HashSet<int> UniversalSet = new HashSet<int>();
                for (int i = 0; i < 101; i++)
                {
                    UniversalSet.Add(i);
                }
                return UniversalSet;
            }

            public static void printHashSet<T>(HashSet<T> hashset)
            {
                foreach (T item in hashset)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            // prints per row
            public static void printDimensionalArray<T>(T[,] array)
            {
                Console.WriteLine("De integer array: \n");

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // searches per column
            public static HashSet<int> SearchSmallestPerColumn(int[,] array)
            {
                HashSet<int> hashset = new HashSet<int>();
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    int tempGetal = int.MaxValue;
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        if (tempGetal > array[j, i])
                        {
                            tempGetal = array[j, i];
                        }
                    }
                    hashset.Add(tempGetal);
                }
                return hashset;
            }

            // searches per row
            public static HashSet<int> SearchBiggestPerRow(int[,] array)
            {
                HashSet<int> hashset = new HashSet<int>();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int tempGetal = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (tempGetal < array[i, j])
                        {
                            tempGetal = array[i, j];
                        }
                    }
                    hashset.Add(tempGetal);
                }
                return hashset;
            }
        }
    }
}
