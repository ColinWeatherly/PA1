/* Name: Colin Weatherly
 * Date: 1/25/2022
 * File: Cat.cs
 * IDE: Visual Studio 2019
 * Description: The concrete Cat class. This class inherits from the abstract Animal class and
 *              implements overriden functions for this specific animal.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public class Cat : Animal
    {
        // Default constructor. It simply uses the Animal default constructor.
        public Cat() : base()
        { }

        // Parameterized constructor. It uses the Animal parameterized constructor and specifies
        // a certain noise.
        public Cat(string animName, int animAge, int animWeight) : base(animName, animAge, "Meoooow", animWeight)
        { }

        // Overridden AgeUp function. This simply increases the age of the cat by 1.
        public override void AgeUp()
        {
            Console.WriteLine('\n' + GetName + " has aged 1 year!\n");
            GetAge++;
        }

        // Overridden MakeNoise function. This prints the noise the cat makes plus adds an extra cat-specific message.
        public override void MakeNoise()
        {
            Console.WriteLine('\n' + GetName + " made a noise!\n");
            Console.WriteLine(GetNoise + "\nIt now proceeds to follow you around the house.\n");
        }

        // Overridden PrintInfo function. This prints the cat's information (name, age, noise, weight).
        public override void PrintInfo()
        {
            Console.WriteLine('\n' + GetName + " the Cat's info:\n");
            Console.WriteLine("\tAge: " + GetAge + " years old\n");
            Console.WriteLine("\tNoise: " + GetNoise + "\n");
            Console.WriteLine("\tWeight: " + GetWeight + " kg\n");
        }

    }
}
