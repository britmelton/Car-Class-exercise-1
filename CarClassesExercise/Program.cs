using System;

namespace CarClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Create a new C# .Net Core Console App 
            Create a class named Car - make sure it is public
            In the Car class,
            Create a Make property of type string that is public
            Create a Model property of type string that is public
            Create a Year property of type int that is public
            In the Main method,
            Create a new instance of the Car class
            Set values in the properties for the object
            Print the values of each property to the Console
            */
            var brittanysCar = new Car();
            brittanysCar.Make = "Toyota";
            brittanysCar.Model = "Yaris";
            brittanysCar.Year = 2008;

            Console.WriteLine($"{brittanysCar.Make}\n{brittanysCar.Model}\n{brittanysCar.Year}");

        }


        public class Car
        {           
           
            public string Make { get; set; } 
            public string Model { get; set; }   
            public int Year { set; get; }


        }
    }
}
