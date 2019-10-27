using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege3
{
    class Program
    {
        static void Main(string[] args)
        {
            //opdracht 5
            int[] getallen = { 19, 24, -19, -24, 0 };
            foreach (int item in getallen)
            {
                Console.Write(item + ": ");
                if ((item & 0x1) == 0)
                {
                    Console.Write("Even ");
                }
                else
                {
                    Console.Write("Uneven ");
                }

                if ((item & 80000000) == 0)
                {
                    Console.WriteLine("Positive ");
                }
                else
                {
                    Console.WriteLine("Negative ");
                }
            }

            // 6
            foreach (int item in getallen)
            {
                int getal = item >> 1;
                Console.WriteLine(getal);
            }

            // 7
            char x = 'A';
            char y = 'a';
            char toLowerCase = (char)(x | 32);
            char toUpperCase = (char)(y & ~32);
            char toggleCase = (char)(y ^ 32);

            Console.WriteLine(toLowerCase);
            Console.WriteLine(toUpperCase);
            Console.WriteLine(toggleCase);

            // 8 klopt bíjna
            string tekst1 = "Oefening 8, geef nu een tekst! ";
            string tekst2 = "dit is echt een leuke opgave 8 zeg!";
            char[] regel = tekst2.ToCharArray();
            string result = "";

            for (int i = 0; i < regel.Length; i++)
            {
                if (i == 0 || regel[i] != ' ' && regel[i - 1] != ' ')
                {
                    result += (char)(regel[i] | 32);
                }
                else if (regel[i] != ' ' && regel[i - 1] == ' ')
                {
                    result += (char)(regel[i] & ~32);
                }
                //deze elseif doetie niet
                else if (regel[i] < 'a' && regel[i] > 'Z')
                {
                    result += regel[i];
                }
                else
                {
                    result += " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
