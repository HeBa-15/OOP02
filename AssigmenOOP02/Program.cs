using System;

namespace AssigmenOOP02
{
    #region Q1: struct Person
    
    struct Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] p = new Person[3];
            p[0] = new Person("Ali", 20); 
            p[1] = new Person("Ahmed", 22);
            p[2] = new Person("Mariam", 25);

            foreach (Person person in p) 
            { 
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            #endregion
        }
    }
}