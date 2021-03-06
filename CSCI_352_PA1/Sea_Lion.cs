/* Name: Colin Weatherly
 * Date: 1/25/2022
 * File: Sea_Lion.cs
 * IDE: Visual Studio 2019
 * Description: The concrete Sea_Lion class. This class inherits from the abstract Animal class and
 *              implements overriden functions for this specific animal.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public class Sea_Lion : Animal
    {
        // Default constructor. It simply uses the Animal default constructor.
        public Sea_Lion() : base()
        { }

        // Parameterized constructor. It uses the Animal parameterized constructor and specifies
        // a certain noise.
        public Sea_Lion(string animName, int animAge, int animWeight) : base(animName, animAge, "Arf! Arf!", animWeight)
        { }

        // Overridden AgeUp function. This simply increases the age of the sea lion by 1.
        public override void AgeUp()
        {
            Console.WriteLine('\n' + GetName + " has aged 1 year!\n");
            GetAge++;
        }

        // Overridden MakeNoise function. This prints the noise the sea lion makes plus adds an extra sea lion-specific message.
        public override void MakeNoise()
        {
            Console.WriteLine('\n' + GetName + " made a noise!\n");
            Console.WriteLine(GetNoise + "\nIt flaps its flippers adorably.\n");
        }

        // Overridden PrintInfo function. This prints the sea lion's information (name, age, noise, weight).
        public override void PrintInfo()
        {
            Console.WriteLine('\n' + GetName + " the Sea Lion's info:\n");
            Console.WriteLine("\tAge: " + GetAge + " years old\n");
            Console.WriteLine("\tNoise: " + GetNoise + "\n");
            Console.WriteLine("\tWeight: " + GetWeight + " kg\n");
        }
    }
}
