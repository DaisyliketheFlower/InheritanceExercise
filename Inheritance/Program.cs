using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             * 
             * 
             */
            var kingFisher = new bird_class()
            {
               BuildsNest = true,
                CanFly = true,
                CanSing = true,
                Name = "KingFisher",
                CanSwim = false
            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile()
            {
             HasForkedTongue = true,
             HasScales = true,
             Movement = "slithers",
              Legs = 0,
              Name = "Rattlesnake"
            };

              KingFisher.PrintDetails();
               Console.WriteLine();

              snake.PrintDetails();

            var penguin = new bird_class() { CanFly = false, CanSwim = true, CanSing = false, Name = "penguin" };
            var gator = new Reptile() { HasForkedTongue = false, CanSwim = true,Movement = "Crawls", Name = "Gator"}

            Console.WriteLine();
            penguin.PrintDetails();
            Console.WriteLine();
            gator.PrintDetails();

        }
    }
}
