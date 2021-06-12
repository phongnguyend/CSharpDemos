using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
        }

        private static void Demo1()
        {
            int x = 10;
            int y = x;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            x += 1;
            y -= 1;
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }

        private static void Demo2()
        {
            int x = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");

            UpdateX(x);

            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
        }

        static void UpdateX(int x)
        {
            Console.WriteLine($"x = {x}");
            x += 1;
            Console.WriteLine($"x = {x}");
        }

        private static void Demo3()
        {
            int x = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");

            UpdateXUsingRef(ref x);
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
        }

        static void UpdateXUsingRef(ref int x)
        {
            Console.WriteLine($"x = {x}");
            x += 1;
            Console.WriteLine($"x = {x}");
        }

        private static void Demo4()
        {
            int x = 10;
            Console.WriteLine("Initial:");
            Console.WriteLine($"x = {x}");


            UpdateXUsingOut(out x);
            Console.WriteLine("Updated:");
            Console.WriteLine($"x = {x}");
        }

        static void UpdateXUsingOut(out int x)
        {
            //Console.WriteLine($"x = {x}");
            x = 1;
            x += 1;
            Console.WriteLine($"x = {x}");
        }
    }
}
