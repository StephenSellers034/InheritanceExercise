using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var redRobin = new Bird()
            {
                BeakSize = "4 inches",
                WingSpan = 12,
                Height = 6,
                Color = "Red",
                Legs = 2,
                BodySize = "Tiny",
                MaleOrFemale = "Female",
                Age = 5 


            };
            redRobin.Details();
            Console.WriteLine("------------------------------");


            var boa = new Reptile()
            {
                HasClaws = false,
                HasScales = false,
                Weight = 100,
                ColdBlooded = "Yes",
                Legs = 0,
                BodySize = "Extra Large",
                MaleOrFemale = "Male",
                Age = 8
            };
            boa.RepDetails();
            

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
