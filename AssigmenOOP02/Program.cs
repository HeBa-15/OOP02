using System;

namespace AssigmenOOP02
{
    #region Part01

    #region Q1 and Q3: struct Person

    //struct Person
    //{
    //    public string Name;
    //    public int Age;
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    #endregion


    #region Q2:
    //struct Point 
    //{ 
    //    public double X;
    //    public double Y;
    //    public Point(double x, double y) 
    //    { 
    //        X = x;
    //        Y = y; 
    //    }


    //}
    #endregion

    #endregion

    #region Q1
    public enum SecurityLevel
    {
        Guest, Developer, Secretary, DBA, securityOfficer
    }
    public enum Gender
    {
        M, F
    }

    #endregion

    internal class Program
    {

        #region Q2:Method
        //static double CalcDistance(Point p1, Point p2)
        //{
        //    double dx = p2.X - p1.X;
        //    double dy = p2.Y - p1.Y;
        //    return Math.Sqrt(dx * dx + dy * dy);
        //}
        #endregion

        static void Main(string[] args)
        {
            #region Part 01

            #region Q1:Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] p = new Person[3];
            //p[0] = new Person("Ali", 20); 
            //p[1] = new Person("Ahmed", 22);
            //p[2] = new Person("Mariam", 25);

            //foreach (Person person in p) 
            //{ 
            //    Console.WriteLine($"Name: {person.Name} , Age: {person.Age}");
            //}

            #endregion


            #region Q2:Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //    Console.WriteLine("Enter first point :");

            //    string[] input1 = Console.ReadLine().Split(' ');
            //    Point point1 = new Point(double.Parse(input1[0]), double.Parse(input1[0]));


            //    Console.WriteLine("Enter second point :");

            //    string[] input2 = Console.ReadLine().Split(' ');
            //    Point point2 = new Point(double.Parse(input2[0]), double.Parse(input2[0]));

            //    double distance = CalcDistance(point1, point2); 
            //    Console.WriteLine($"The distance between the two points is: {distance}");
            //}

            #endregion


            #region Q3:Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Enter name of person {i + 1}:");
            //    string name = Console.ReadLine();

            //    Console.WriteLine($"Enter  age of person {i + 1}:");
            //    int age = int.Parse(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //}
            //Person oldPerson = people[0];

            //foreach (Person person in people)
            //{
            //    if (person.Age > oldPerson.Age)
            //    {

            //        oldPerson = person;
            //    }

            //}
            //Console.WriteLine($"The old person is {oldPerson.Name} with an age of {oldPerson.Age}.");
            #endregion

            #endregion


            #region Part 02

            #region Q1,2:

            //Employee emp = new Employee
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Gender = Gender.M,
            //    SecurityLevel = SecurityLevel.Developer,
            //    Salary = 10000,
            //    HireDate = new HiringDate { Day = 3, Month = 1, Year = 2020 }
            //};
            //Console.WriteLine(emp.ToString());
            #endregion


            #region Q3:

            //Employee[] Emp = new Employee[3];
            //Emp[0] = new Employee(1, "Mariam", Gender.F, SecurityLevel.DBA, 10000,
            //new HiringDate { Day = 1, Month = 2, Year = 2018 });

            //Emp[1] = new Employee(2, "Ali", Gender.M, SecurityLevel.Guest, 9000,
            //    new HiringDate { Day = 15, Month = 6, Year = 2020 });

            //Emp[2] = new Employee(3, "Charlie", Gender.M, SecurityLevel.securityOfficer, 11000,
            //    new HiringDate { Day = 10, Month = 12, Year = 2019 });

            //foreach (var emp in Emp)
            //{ 
            //    Console.WriteLine(emp.ToString());
            //}

            #endregion


            #endregion



        }

    }
}



   

