using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public class Cat : Animal
    {
        public override void ageUp()
        {
            Console.WriteLine(GetName + " has aged 1 year!");
            GetAge++;
        }

        public override void makeNoise()
        {
            Console.WriteLine(GetName + " made a noise!\n");
            Console.WriteLine(GetNoise);
        }

        public override void printInfo()
        {
            Console.WriteLine(GetName + "'s info:\n");
            Console.WriteLine("\tAge: " + GetAge + "\n");
            Console.WriteLine("\tNoise: " + GetNoise + "\n");
            Console.WriteLine("\tWeight: " + GetWeight + " kg");
        }

    }
}
