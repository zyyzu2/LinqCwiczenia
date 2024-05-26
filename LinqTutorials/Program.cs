using System;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();
            foreach (var tv in t)
            {
                Console.WriteLine(tv.ToString());
            }
            Console.WriteLine("-----------Task2");
            var t2 = LinqTasks.Task2();
            foreach (var tv in t2)
            {
                Console.WriteLine(tv.ToString());
            }
            Console.WriteLine("-----------Task3");
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);
            
            Console.WriteLine("-----------Task4");
            var t4 = LinqTasks.Task4();
            foreach (var tv in t4)
            {
                Console.WriteLine(tv.ToString());
            }
            
            Console.WriteLine("-----------Task5");
            var t5 = LinqTasks.Task5();
            foreach (var tv in t5)
            {
                Console.WriteLine(tv.ToString());
            }
            
            Console.WriteLine("-----------Task6");
            var t6 = LinqTasks.Task6();
            foreach (var tv in t6)
            {
                Console.WriteLine(tv.ToString());
            }
            
            Console.WriteLine("-----------Task7");
            var t7 = LinqTasks.Task7();
            foreach (var tv in t7)
            {
                Console.WriteLine(tv.ToString());
            }
            
            Console.WriteLine("-----------Task8");
            var t8 = LinqTasks.Task8();
            Console.WriteLine(t8);
            
            Console.WriteLine("-----------Task9");
            var t9 = LinqTasks.Task9();
            Console.WriteLine(t9);
            
            Console.WriteLine("-----------Task10");
            var t10 = LinqTasks.Task10();
            foreach (var tv in t10)
            {
                Console.WriteLine(tv.ToString());
            }
            Console.WriteLine("-----------Task11");
            var t11 = LinqTasks.Task11();
            foreach (var tv in t11)
            {
                Console.WriteLine(tv.ToString());
            }
            Console.WriteLine("-----------Task12");
            var t12 = LinqTasks.Task12();
            foreach (var tv in t12)
            {
                Console.WriteLine(tv.ToString());
            }
            Console.WriteLine("-----------Task13");
            int[] test = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            var t13 = LinqTasks.Task13(test);
            Console.WriteLine(t13);
            
            
        }
    }
}
