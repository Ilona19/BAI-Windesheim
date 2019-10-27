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
        class Program2
        {
            static void Main(string[] args)
            {
                int[,] integer2DArray = new int[,] {
                { 74, 46, 42 },
                { 2, 63, 24 },
                { 83, 76, 98 },
                { 10, 3, 4 },
                { 28, 63, 79 }
            };

                HashTest.printDimensionalArray(integer2DArray);
                Console.WriteLine();
                // search array
                HashSet<int> setA = new HashSet<int>(HashTest.SearchSmallestPerColumn(integer2DArray));
                HashSet<int> setB = new HashSet<int>(HashTest.SearchBiggestPerRow(integer2DArray));

                HashTest.printHashSet(setA);
                HashTest.printHashSet(setB);
                Console.WriteLine();

                HashSet<int> resultaat1 = new HashSet<int>(setA);
                resultaat1.UnionWith(setB);
                HashTest.printHashSet(resultaat1);

                HashSet<int> resultaat2 = new HashSet<int>(setA);
                resultaat2.IntersectWith(setB);

                CheckThizz(resultaat2, setB);
            }

            public static void CheckThizz(HashSet<int> hashset1, HashSet<int> hashset2)
            {
                if (hashset1.Count > 0)
                {
                    HashTest.printHashSet(hashset1);
                }
                else
                {
                    Console.WriteLine($"{nameof(hashset1)} heeft geen elementen overeen met {nameof(hashset2)}");
                }
            }
        }
    }
}
