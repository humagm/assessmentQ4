using System;
namespace assessmentQ4

{
    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Please type your first name");
            var fn = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Please type your last name");
            var ln = Console.ReadLine();
            Console.WriteLine();



           

            

            var person = new Student(fn, ln);
            person.EnrollStudent();
            Console.WriteLine();
            Console.WriteLine(person.PersonInfo());
            Console.ReadKey();

        }

    }

}