using System;
namespace assessmentQ4
 {

    class Student : Person {

        public int StudentID {get; set;}

        public Student (string firstName, string lastname) : base(firstName, lastname) {}

        public void EnrollStudent() {

            var rand = new Random();
            StudentID = rand.Next(1111, 9999);

        }
        public override string PersonInfo() {

            return $"\nFull Name: {GetFullName()}\nStudent ID: {StudentID}\n";

        }

    }

}