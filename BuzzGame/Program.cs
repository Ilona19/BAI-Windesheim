using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BuzzGame buzzer1 = new BuzzGame(7);
            Console.WriteLine(buzzer1);
            buzzer1.PlayBuzz();
            // results

            Console.WriteLine("\n" + buzzer1);
        }
    }
}
