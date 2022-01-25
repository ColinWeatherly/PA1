using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public abstract class Animal
    {

        private string Name;
        private int Age;
        private string Noise;
        private int Weight;

        public Animal()
        {
            Name = "Steve";
            Age = 1;
            Noise = "GRAWR";
            Weight = 10;
        }

        public Animal(string animName, int animAge, string animNoise, int animWeight)
        {
            Name = animName;
            Age = animAge;
            Noise = animNoise;
            Weight = animWeight;
        }

        public abstract void PrintInfo();

        public abstract void MakeNoise();

        public abstract void AgeUp();

        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int GetAge
        {
            get { return Age; }
            set { Age = value; }
        }

        public string GetNoise
        {
            get { return Noise; }
            set { Noise = value; }
        }

        public int GetWeight
        {
            get { return Weight; }
            set { Weight = value; }
        }

    }
}
