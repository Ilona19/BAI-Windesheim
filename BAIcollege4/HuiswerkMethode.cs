using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege4
{
    class HuiswerkMethode
    {
        public static void Methode()
        {
            StackSymbolTrial("28+39*+=367+*=");

            Queue<int> intQueue = new Queue<int>();
            for (int i = 0; i < 20; i++)
            {
                intQueue.Enqueue(i + 1);
            }
            foreach (int item in QueueTrial(intQueue))
            {
                Console.WriteLine($"{item} ");
            }

            Stack<int> stack = new Stack<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(rnd.Next(1, 100));  //put random int(1-99) in stack
            }
            foreach (int item in stack)
            {
                Console.WriteLine($"{item} "); //prints items in stack
            }
            Console.WriteLine();
            foreach (int item in StackTrial(stack))
            {
                Console.WriteLine(item); //prints items in modified stack
            }
        }

        public static void StackSymbolTrial(string input)
        {
            Stack<int> datastream = new Stack<int>();
            int result = 0;
            foreach (char character in input)
            {
                if (int.TryParse(character.ToString(), out int number))
                {
                    datastream.Push(number);
                }
                else if (character == '*' || character == '+')
                {
                    int getal1 = datastream.Pop();
                    int getal2 = datastream.Pop();
                    switch (character)
                    {
                        case '*':
                            result = getal1 * getal2;
                            datastream.Push(result);
                            break;
                        case '+':
                            result = getal1 + getal2;
                            datastream.Push(result);
                            break;
                        default:
                            break;
                    }
                }
                else if (character == '=')
                {
                    Console.WriteLine(datastream.Pop());
                }
                else
                {
                    Console.WriteLine("This shiet isnt right");
                }
            }
        }

        public static Queue<T> QueueTrial<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        public static Stack<int> StackTrial(Stack<int> stack)
        {
            int biggest = 0;
            Stack<int> tempStack = new Stack<int>();

            while (stack.Count > 0)
            {
                if (stack.Peek() > biggest)
                {
                    biggest = stack.Peek();
                }
                tempStack.Push(stack.Pop());
            }

            int initialLength = tempStack.Count();
            for (int i = 0; i < initialLength; i++)
            {
                if (tempStack.Peek() != biggest)
                {
                    stack.Push(tempStack.Pop());
                }
                else
                {
                    tempStack.Pop();
                }
            }
            return stack;
        }

    }
}
