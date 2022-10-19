using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //global variable
        private int data = 25;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //herhangi bir tuşa basana kadar sabit kalır
            Console.ReadKey(); 
            
            //local variable example
            int a;

            a = 200;
        }
    }
}