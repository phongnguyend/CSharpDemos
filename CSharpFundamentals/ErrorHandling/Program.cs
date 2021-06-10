using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithoutExceptionHandling();
            WithExceptionHandling1();
        }

        private static void WithoutExceptionHandling()
        {
            Console.WriteLine("Please enter x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"x/y = {x / (decimal)y}");
        }

        private static void WithExceptionHandling1()
        {
            try
            {
                Console.WriteLine("Please enter x:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter y:");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine($"x/y = {x / (decimal)y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
