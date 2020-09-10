using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello22
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            sayGoodbye();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            sayHello2(name);
            sayGoodbye2(name);
            //Console.ReadLine();
            int a = 5;
            int b = 5;
            add(a, b);
            string countthis = "such a day it was";
            spacecount(countthis);
            Console.ReadLine();
        }
        static void sayHello()
        {
            Console.WriteLine("Hello");
        }
        static void sayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }
        static void sayHello2(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void sayGoodbye2(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }
        static void add(int a , int b)// instead of void int can be also written to return the sum
        {
            int c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);
        }
        static int spacecount(string phrase)
        {
            int i = 0;
            for(int j =0; j < phrase.Length; j++)
            {
                if(phrase[j]== ' ')
                
                    i++;
                
            }
            return i;
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a=" + a + "b=" + b);

        }

    }
}
