using System;
namespace assessmentQ4

{
    class Person {

        public string FirstName {get; set;}
        public string LastName {get; set;}
       

        public Person(string firstName, string lastName) {

            FirstName = firstName;
            LastName = lastName;
            

            Console.WriteLine("Creating a Person...");
Console.WriteLine("Adding a new student to Bongard campus...");
        }

        public string GetFullName() {

            return $"{FirstName} {LastName}";

        }


        public virtual string PersonInfo() {

            return $"FullName: {GetFullName()}";

        }

    }

}