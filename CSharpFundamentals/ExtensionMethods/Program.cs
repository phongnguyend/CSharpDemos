using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            person.PrintFullName();
            PersonExtensions.PrintFullName(person);

            Console.WriteLine(DateTimeExtensions.GetDiscount(DateTime.Now));
            Console.WriteLine(DateTimeExtensions.GetDiscount1(DateTime.Now));
            Console.WriteLine(DateTimeExtensions.GetDiscount2(DateTime.Now));
            Console.WriteLine(DateTimeExtensions.GetDiscount3(DateTime.Now));

            Console.WriteLine(DateTime.Now.GetDiscount());
            Console.WriteLine(DateTime.Now.GetDiscount1());
            Console.WriteLine(DateTime.Now.GetDiscount2());
            Console.WriteLine(DateTime.Now.GetDiscount3());
        }
    }
}
