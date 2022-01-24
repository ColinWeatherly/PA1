using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public abstract class Animal
    {
        private Animal()
        {
            string Name = "Default";
            int Age = 1;
            string Noise = "GRAWR";
            int Weight = 100;
        }

        public abstract void printInfo();

        public abstract void makeNoise();

        public abstract void ageUp();

    }
}
