using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ///farm animals
            Sheep sheep = new Sheep();
            Horse horse = new Horse();
            Pig pig = new Pig();
            Fox fox = new Fox();

            //For loop to iterate through the menu 5 times, so view can explore all options
            for (int i = 1; i < 5; ++i)
            {
                ///entry text for user providing menu to select animal
                Console.WriteLine("Hello, welcome to the farm! Who would you like to meet?\n" +
                    "\t1. SGT Bah(Sheep)\n" +
                    "\t2. Louie(Horse)\n" +
                    "\t3. Jonny(Fox)\n" +
                    "\t4. Charlie the pig");

                ///convert string response to int to prepare for if statement
                int response = Convert.ToInt32(Console.ReadLine());

                ///find user selection and display data using methods from instantiated classes
                if (response == 1)
                {
                    Console.WriteLine($"{sheep.Speak()} and live in {sheep.Lives()}, I really enjoy {sheep.Move()} and providing {sheep.Provides()} for humans\n\n\n" +
                        $"Press enter and select someone else!");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (response == 2)
                {
                    Console.WriteLine($"{horse.Speak()} and live in {horse.Lives()}, I really enjoy {horse.Move()} and providing {horse.Provides()} for humans\n\n\n" +
                        $"Press enter and select someone else!");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (response == 3)
                {
                    Console.WriteLine($"{fox.Speak()} and live in {fox.Lives()}, I really enjoy {fox.Move()} and providing {fox.Provides()} for humans\n\n\n" +
                        $"Press enter and select someone else!");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (response == 4)
                {
                    Console.WriteLine($"{pig.Speak()} and live in {pig.Lives()}, I really enjoy {pig.Move()} and providing {pig.Provides()} for humans\n\n\n" +
                        $"Press enter and select someone else!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.ReadLine();          
        }
    }
}
