using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege4
{
    class Program
    {
        static void Main(string[] args)
        {
            // huiswerk
            HuiswerkMethode.Methode();

            //Method("(((((   )))) () )");
            //Method(")()");
            //Method("(()()()())");
            //Method("((((( ))))");
            //Method("-----------");

            //Queue<char> queue1 = new Queue<char>(); ;
            //QueueTrial(queue1);

            string[] lines = System.IO.File.ReadAllLines(@"..\..\namen.txt");
            DictionaryTrial(lines);
        }

        public static void Method(string text)
        {
            Stack<char> stack = new Stack<char>();
            bool posInt = true;

            foreach (char character in text)
            {
                if (character == '(')
                {
                    stack.Push(character);
                }
                if (character == ')')
                {
                    if (stack.Count == 0)
                    {
                        posInt = false;
                    }
                    else
                    {
                        stack.Append(stack.Pop());
                    }
                }
            }
            if (posInt)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                Console.WriteLine("Foutmelding");
            }
        }

        public static void QueueTrial(Queue<char> inputQueue)
        {
            foreach (char c in Console.ReadLine())
            {
                inputQueue.Enqueue(c);
            }

            Queue<char> newQueue = new Queue<char>();
            while (inputQueue.Count() > 0)
            {
                newQueue.Enqueue(inputQueue.Dequeue());
            }

            while (newQueue.Count > 0)
            {
                Console.Write($"{newQueue.Dequeue()} ");
            }
        }

        public static void DictionaryTrial(string[] stringArray)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            foreach (string item in stringArray)
            {
                string naam = item.Split()[0];
                int key = Int32.Parse(item.Split()[1]);
                if (d.ContainsKey(key))
                {
                    Console.WriteLine($"{key} Bestaat al met de value : {naam}! ------------------------------------------");
                }
                else
                {
                    d.Add(key, naam);
                }
            }

            // remove 1450-1470
            for (int key = 1450; key <= 1470; key++)
            {
                if (d.ContainsKey(key))
                {
                    d.Remove(key);
                }
            }

            Console.WriteLine(d.Count);

            Dictionary<string, int> naamCount = new Dictionary<string, int>();
            foreach (KeyValuePair<int, string> kvp in d)
            {
                string naam = kvp.Value;
                if (naamCount.ContainsKey(naam))
                {
                    naamCount[naam] = naamCount[naam] + 1;
                }
                else
                {
                    naamCount.Add(naam, 1);
                }
            }

            foreach (KeyValuePair<int, string> kvp in d)
            {
                //Console.WriteLine(kvp);
            }
            Console.WriteLine($"{naamCount}");

            foreach (KeyValuePair<string, int> kvp in naamCount)
            {
                Console.WriteLine($"Naam {kvp.Key} komt {kvp.Value} keer voor");
            }

            Console.WriteLine(naamCount.Count());
        }
    }
}
