using System;
using System.Collections.Generic;

namespace CSCI_352_PA1
{
    class World
    {
        static void Main(string[] args)
        {
            var OurWorld = new World();
            var animals = new List<Animal>();
            int AnimalNum = 0;

            OurWorld.PrintMenu();

            int ChoiceNum = Convert.ToInt32(Console.ReadLine());

            while (ChoiceNum != 7)
            {
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
                else if (ChoiceNum == 4)
                {
                    Console.WriteLine("What number animal would you like to age up?");
                    int indexNum = Convert.ToInt32(Console.ReadLine()) - 1;

                    while (OurWorld.ValidateIndex(indexNum, AnimalNum) == false)
                    {
                        indexNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    animals[indexNum].AgeUp();
                }
                else if (ChoiceNum == 5)
                {
                    Console.WriteLine("What number animal would you like to hear the noise of?");
                    int indexNum = Convert.ToInt32(Console.ReadLine()) - 1;

                    while (OurWorld.ValidateIndex(indexNum, AnimalNum) == false)
                    {
                        indexNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    animals[indexNum].MakeNoise();
                }
                else if (ChoiceNum == 6)
                {
                    Console.WriteLine("What number animal would you like to view the info to?");
                    int indexNum = Convert.ToInt32(Console.ReadLine()) - 1;

                    while (OurWorld.ValidateIndex(indexNum, AnimalNum) == false)
                    {
                        indexNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    animals[indexNum].PrintInfo();
                }
                else
                {
                    Console.WriteLine("\nInvalid Input, Please Try Again\n");
                    Console.WriteLine("Current value of AnimalNum: " + AnimalNum);
                }

                OurWorld.PrintMenu();

                ChoiceNum = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\nClosing program");
            
        }

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
