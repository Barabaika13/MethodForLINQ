namespace MethodForLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            try
            {
                var result1 = list.Top(50);
                foreach (var item in result1)
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            var persons = new List<Person>()
            {
                new Person { Name = "Ivan", Age = 25 },
                new Person { Name = "Petr", Age = 32 },
                new Person { Name = "Maria", Age = 27 },
                new Person { Name = "Anna", Age = 21 },
                new Person { Name = "Alexandr", Age = 40 },
                new Person { Name = "Ekaterina", Age = 36 },
                new Person { Name = "Andrey", Age = 45 },
                new Person { Name = "Irina", Age = 39 },
                new Person { Name = "Elena", Age = 37 },
            };
            try
            {
                var result2 = persons.Top(50, person => person.Age);
                foreach (var person in result2)
                {
                    Console.WriteLine($"{person.Name}, Age: {person.Age}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}