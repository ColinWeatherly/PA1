/* Name: Colin Weatherly
 * Date: 1/25/2022
 * File: Animal.cs
 * IDE: Visual Studio 2019
 * Description: The file for the abstract Animal class. This is the base class for
 *              the concrete classes that inherit from this.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI_352_PA1
{
    public abstract class Animal
    {
        // The variables that make up the animal classes' data
        private string Name;
        private int Age;
        private string Noise;
        private int Weight;

        /* Definition: Public default constructor for the abstract Animal class.
         *             All concrete classes that inherit the Animal class use this
         *             default constructor. It initializes all class variables.
         *             
         * Result: All class variables are initialized with default values.
         */
        public Animal()
        {
            Name = "Steve";
            Age = 1;
            Noise = "GRAWR";
            Weight = 10;
        }

        /* Definition: Public parameterized constructor for the abstract Animal class.
         *             All concrete classes that inherit the Animal class use this parameterized
         *             constructor. It initializes all class variables with the specified values.
         *             
         * Parameters: string animName
         *                 The specified name for the animal.
         *             int animAge
         *                 The specified age for the animal.
         *             string animNoise
         *                 The specified noise for the animal.
         *             int animWeight
         *                 The specified weight for the animal.
         *                 
         * Result: The object is created with specified values.
         */
        public Animal(string animName, int animAge, string animNoise, int animWeight)
        {
            Name = animName;
            Age = animAge;
            Noise = animNoise;
            Weight = animWeight;
        }

        /* Definition: Prints the info for the animal. This info includes the specie, name, age,
         *             noise, and weight.
         *             
         * Result: All info is printed for a particular animal.
         */
        public abstract void PrintInfo();

        /* Definition: This prints out the noise the animal makes. Depending on the animal, a
         *             special extra piece of info is given as well.
         *             
         * Result: The animal noise is printed out.
         */
        public abstract void MakeNoise();

        /* Definition: This ages up this specific animal. All it does is simply increment the Age of
         *             the animal by 1.
         *             
         * Result: The age of the animal is increased by 1.
         */
        public abstract void AgeUp();

        // This is a getter and setter for the Name variable. It allows the value to be modified by the class's children.
        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        // This is a getter and setter for the Age variable. It allows the value to be modified by the class's children.
        public int GetAge
        {
            get { return Age; }
            set { Age = value; }
        }

        // This is a getter and setter for the Noise variable. It allows the value to be modified by the class's children.
        public string GetNoise
        {
            get { return Noise; }
            set { Noise = value; }
        }

        // This is a getter and setter for the Weight variable. It allows the value to be modified by the class's children.
        public int GetWeight
        {
            get { return Weight; }
            set { Weight = value; }
        }

    }
}
