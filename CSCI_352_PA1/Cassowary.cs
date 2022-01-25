using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public class Cassowary : Animal
    {
        public Cassowary() : base()
        { }

        public Cassowary(string animName, int animAge, int animWeight) : base(animName, animAge, "KAAAAAWWW!", animWeight)
        { }

        public override void AgeUp()
        {
            Console.WriteLine('\n' + GetName + " has aged 1 year!\n");
            GetAge++;
        }

        public override void MakeNoise()
        {
            Console.WriteLine('\n' + GetName + " made a noise!\n");
            Console.WriteLine(GetNoise + "\nIts eyes pierce into your soul.\n");
        }

        public override void PrintInfo()
        {
            Console.WriteLine('\n' + GetName + " the Cassowary's info:\n");
            Console.WriteLine("\tAge: " + GetAge + " years old\n");
            Console.WriteLine("\tNoise: " + GetNoise + "\n");
            Console.WriteLine("\tWeight: " + GetWeight + " kg\n");
        }

    }
}
