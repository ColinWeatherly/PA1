/* Name: Colin Weatherly
 * Date: 1/25/2022
 * File: Program.cs
 * IDE: Visual Studio 2019
 * Description: The driver used to test the functionalities of the abstract Animal class and its 3 children.
 *              It uses a simple interface that allows the user to interact with the various class functions and
 *              to add animal objects to a list.
 */

using System;
using System.Collections.Generic;

namespace CSCI_352_PA1
{
    class World
    {
        // Main is where most of the menu choices are implemented.
        static void Main(string[] args)
        {
            // Establishes an instance of the World object.
            var OurWorld = new World();

            // Creates a new list of Animals.
            var animals = new List<Animal>();

            // Initializes the animal count.
            int AnimalNum = 0;

            // Prints the menu using the World object's PrintMenu method.
            OurWorld.PrintMenu();

            // Takes the user's input and converts it to an int.
            int ChoiceNum = Convert.ToInt32(Console.ReadLine());

            // Handles the menu choice and chooses the correct action corresponding to the integer entered.
            while (ChoiceNum != 7)
            {
                // Takes user input for a name, age, and weight and adds a new cat to the list.
                if (ChoiceNum == 1)
                {
                    Console.WriteLine("What is the new cat's name?");
                    string NewName = Console.ReadLine();

                    Console.WriteLine("How old is the cat in years?");
                    int NewAge = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("How heavy is the cat in kilograms?");
                    int NewWeight = Convert.ToInt32(Console.ReadLine());

                    animals.Add(new Cat(NewName, NewAge, NewWeight));
                    AnimalNum++;
                }
                // Takes user input for a name, age, and weight and adds a new cassowary to the list.
                else if (ChoiceNum == 2)
                {
                    Console.WriteLine("What is the new cassowary's name?");
                    string NewName = Console.ReadLine();

                    Console.WriteLine("How old is the cassowary in years?");
                    int NewAge = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("How heavy is the cassowary in kilograms?");
                    int NewWeight = Convert.ToInt32(Console.ReadLine());

                    animals.Add(new Cassowary(NewName, NewAge, NewWeight));
                    AnimalNum++;
                }
                // Takes user input for a name, age, and weight and adds a new sea lion to the list.
                else if (ChoiceNum == 3)
                {
                    Console.WriteLine("What is the new sea lion's name?");
                    string NewName = Console.ReadLine();

                    Console.WriteLine("How old is the sea lion in years?");
                    int NewAge = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("How heavy is the sea lion in kilograms?");
                    int NewWeight = Convert.ToInt32(Console.ReadLine());

                    animals.Add(new Sea_Lion(NewName, NewAge, NewWeight));
                    AnimalNum++;
                }
                // Ages up the animal specified by index.
                else if (ChoiceNum == 4)
                {
                    // Asks user for the specific animal index (array index + 1).
                    Console.WriteLine("What number animal would you like to age up?");
                    int indexNum = Convert.ToInt32(Console.ReadLine()) - 1;

                    // Checks to see if the chosen animal exists by use of the World object's
                    // ValidateIndex method.
                    while (OurWorld.ValidateIndex(indexNum, AnimalNum) == false)
                    {
                        indexNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    animals[indexNum].AgeUp();
                }
                // Prints out the noise of the animal specified by index.
                else if (ChoiceNum == 5)
                {
                    // Asks user for the specific animal index (array index + 1).
                    Console.WriteLine("What number animal would you like to hear the noise of?");
                    int indexNum = Convert.ToInt32(Console.ReadLine()) - 1;

                    // Checks to see if the chosen animal exists by use of the World object's
                    // ValidateIndex method.
                    while (OurWorld.ValidateIndex(indexNum, AnimalNum) == false)
                    {
                        indexNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    animals[indexNum].MakeNoise();
                }
                // Prints out the info of the animal specified by index. 
                else if (ChoiceNum == 6)
                {
                    // Asks user for the specific animal index (array index + 1).
                    Console.WriteLine("What number animal would you like to view the info to?");
                    int indexNum = Convert.ToInt32(Console.ReadLine()) - 1;

                    // Checks to see if the chosen animal exists by use of the World object's
                    // ValidateIndex method.
                    while (OurWorld.ValidateIndex(indexNum, AnimalNum) == false)
                    {
                        indexNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    animals[indexNum].PrintInfo();
                }
                // If a choice not included in the menu is made, this message is printed to console.
                else
                {
                    Console.WriteLine("\nInvalid Input, Please Try Again\n");
                }

                // The menu is reprinted with World's PrintMenu method
                OurWorld.PrintMenu();

                // The while loop is reprimed with another user input
                ChoiceNum = Convert.ToInt32(Console.ReadLine());

            }

            // Message for when the program closes
            Console.WriteLine("\nClosing program");
            
        }

        /* Definition: A method for the World class that prints out the menu choices for the interface.
         *             This is a simple menu that makes use of newline and tab characters.
         *             
         * Result: The menu for the interface is printed out.
         */
        void PrintMenu()
        {
            Console.WriteLine("Please select one of the following:\n");
            Console.WriteLine("\t1. Add a new Cat\n");
            Console.WriteLine("\t2. Add a new Cassowary\n");
            Console.WriteLine("\t3. Add a new Sea Lion\n");
            Console.WriteLine("\t4. Age an animal up\n");
            Console.WriteLine("\t5. Have an animal make its noise\n");
            Console.WriteLine("\t6. Print an animal's info\n");
            Console.WriteLine("\t7. Exit program\n");
        }

        /* Definition: A method for the World class that takes two numbers as parameters (the user's
         *             inputted index and the number of animals in the list) to confirm that an animal
         *             exists at the specified index using comparisons.
         *             
         * Parameters: int InputNum
         *                 The index being checked for the existence of an animal.
         *             int AnimalNum
         *                 The number of animals in the list.
         *                 
         * Return: true
         *             The function returns true if an animal exists at that index.
         *         false
         *             The function returns false if an animal does not exist at that index.
         */
        bool ValidateIndex(int InputNum, int AnimalNum)
        {
            if (InputNum >= AnimalNum || InputNum < 0)
            {
                Console.WriteLine("Invalid Index, Please Try Again");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
