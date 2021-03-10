using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; 
            
            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} + {b} equals {addNumbers(a, b)}");
        }

        static int addNumbers(int a, int b){
            return (a - b);
        }
    }
}
