using System;

namespace ReferenceTypes
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public void Print()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DayOfBirth.ToShortDateString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
        }

        private static void Demo1()
        {
            Person person1 = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Person person2 = new Person
            {
                FirstName = "Ti",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person1 berefore Updating:");
            person1.Print();
            Console.WriteLine("Person2 berefore Updating:");
            person2.Print();

            person1.FirstName = "Teo ABC";
            person2.FirstName = "Ti XYZ";

            Console.WriteLine("Person1 after Updated:");
            person1.Print();
            Console.WriteLine("Person2 after Updated:");
            person2.Print();
        }

        private static void Demo2()
        {
            Person person1 = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Person person2 = person1;

            Console.WriteLine("Person1 berefore Updating:");
            person1.Print();
            Console.WriteLine("Person2 berefore Updating:");
            person2.Print();

            person1.FirstName = "Teo ABC";
            person2.FirstName = "Ti XYZ";

            Console.WriteLine("Person1 after Updated:");
            person1.Print();
            Console.WriteLine("Person2 after Updated:");
            person2.Print();
        }

        private static void Demo3()
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person berefore Updating:");
            person.Print();

            UpdatePerson(person);

            Console.WriteLine("Person after Updated:");
            person.Print();
        }

        private static void UpdatePerson(Person person)
        {
            Console.WriteLine("Person insisde Update Function:");
            person.Print();

            person.FirstName = "Teo ABC";
        }

        private static void Demo4()
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person berefore Updating:");
            person.Print();

            UpdatePerson2(person);

            Console.WriteLine("Person after Updated:");
            person.Print();
        }

        private static void UpdatePerson2(Person person)
        {
            Console.WriteLine("Person insisde Update Function:");
            person.Print();

            person = new Person
            {
                FirstName = "Teo ABC",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };
        }

        private static void Demo5()
        {
            Person person = new Person
            {
                FirstName = "Teo",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };

            Console.WriteLine("Person berefore Updating:");
            person.Print();

            UpdatePerson3(ref person);

            Console.WriteLine("Person after Updated:");
            person.Print();
        }

        private static void UpdatePerson3(ref Person person)
        {
            Console.WriteLine("Person insisde Update Function:");
            person.Print();

            person = new Person
            {
                FirstName = "Teo ABC",
                LastName = "Nguyen",
                DayOfBirth = new DateTime(1989, 1, 1)
            };
        }
    }
}
