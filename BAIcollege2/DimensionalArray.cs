using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege2
{
    class DimensionalArray
    {
        static void Main(string[] args)
        {
            int[,] reistijden = {
                { 0, 50, 135, 120, 65, 65 },
                { 50, 0, 140, 75, 20, 70 },
                { 135, 140, 0, 220, 170, 75 },
                { 120, 75, 220, 0, 55, 145 },
                { 65, 20, 170, 55, 0, 90 },
                { 65, 70, 75, 145, 90, 0 }
            };

            Console.WriteLine("Tabel data: ");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(reistijden[i, j] + "\t");
                }
                Console.WriteLine();//new line at each row  
            }
            Console.WriteLine("___________");

            List<int> indexesClosest = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                var avg = GemiddeldeAfstandStad(reistijden, i);
                List<int> closest = VindDichtsbijGemiddelde(reistijden, i, avg);
                foreach (var item in closest)
                {
                    indexesClosest.Add(item);
                }
            }

            foreach (var item in indexesClosest)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine(" ");
            var most = (from i in indexesClosest
                        group i by i into grp
                        orderby grp.Count() descending
                        select grp.Key).First();
            Console.WriteLine($"Most occurring: {most}");

        }

        static int GemiddeldeAfstandStad(int[,] reistijden, int stad)
        {
            int avg = 0;
            for (int i = 0; i < 6; i++)
            {
                if (reistijden[i, stad] != 0)
                {
                    avg += reistijden[i, stad];
                }

            }
            return avg / 5;
        }

        static List<int> VindDichtsbijGemiddelde(int[,] reistijden, int stad, int avg)
        {
            List<int> indexDichtsbij = new List<int>();
            int verschilAfstandKleinst = int.MaxValue;

            // Wat is het kleinste verschil
            for (int i = 0; i < 6; i++)
            {
                int verschil = Math.Abs(avg - reistijden[i, stad]);

                //Check of het verschil kleiner is dan max val.
                if (verschil < verschilAfstandKleinst)
                {
                    verschilAfstandKleinst = verschil;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (Math.Abs(avg - reistijden[i, stad]) == verschilAfstandKleinst)
                {
                    indexDichtsbij.Add(i);
                }
            }
            return indexDichtsbij;
        }
    }
}
