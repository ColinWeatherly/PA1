using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public class Sea_Lion : Animal
    {
        public Sea_Lion() : base()
        { }

        public Sea_Lion(string animName, int animAge, int animWeight) : base(animName, animAge, "Arf! Arf!", animWeight)
        { }

        public override void AgeUp()
        {
            Console.WriteLine('\n' + GetName + " has aged 1 year!\n");
            GetAge++;
        }

        public override void MakeNoise()
        {
            Console.WriteLine('\n' + GetName + " made a noise!\n");
            Console.WriteLine(GetNoise + "\nIt flaps its flippers adorably.\n");
        }

        public override void PrintInfo()
        {
            Console.WriteLine('\n' + GetName + " the Sea Lion's info:\n");
            Console.WriteLine("\tAge: " + GetAge + " years old\n");
            Console.WriteLine("\tNoise: " + GetNoise + "\n");
            Console.WriteLine("\tWeight: " + GetWeight + " kg\n");
        }
    }
}
