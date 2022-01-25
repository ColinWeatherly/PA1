# Name: Colin Weatherly
# Date: 1/25/2022
# File: README.md

Description: This program was created for the purpose of adjusting to the transition between using C++ and using C#.
             This project features one abstract class (Animal), three concrete classes that inherit from the abstract
             class (Cat, Cassowary, Sea Lion), and a main driver that uses a World object to run the interface. The user
             is given options to add new animals of various types to a list, age them up, hear their noises, and see their
             info.
            
This program includes:
             Animal.cs:
                 The abstract class from which all concrete classes inherit. It features four private data variables that store
                 the name, age, noise, and weight of an animal. It establishes three functions (AgeUp(), MakeNoise(), 
                 PrintInfo()) that modify or display animal attributes. These functions are overridden by each concrete class.
                 Accessors and mutators for the four private data variables are also included.
                 
             Cat.cs/Cassowary.cs/Sea_Lion.cs:
                 The three concrete classes that inherit from the abstract Animal class. All functions are overloaded in their
                 own unique ways specific to the animal. The private data variables from Animal are displayed and modified using
                 the accessors/mutators.
                 
             Program.cs:
                 The main driver for the project. It runs inside of a World object and uses an instance of the World object to
                 gain access to two functions (PrintMenu(), ValidateIndex()) that help in running the interface. A menu is used
                 that allows the user to select from several options allowing interaction and creation of different animals.
                 This menu loops until the user quits the program.
                 
                      bool ValidateIndex()
                          This specific function was designed to make absolute sure that the animal that the user is trying to
                          access actually exists within the List. If it does not, this returns false. If it does, this returns
                          true.
                          
Program Use: The user will be given a variety of selections from a menu upon starting the program. From here, the user makes
             the choices pertaining to what they want. The user will then follow the instructions provided from each
             selection. When the user is finished with the program, they will exit using the Exit Program option.
             
Struggles/Possible Issues: The hardest part of creating the program for me was figuring out exactly how to set up the
                           accessors/mutators so that the private variables could be accessed. This was simply because of my
                           unfamiliarity with C#.
                           
                           The program might have a few issues if you decide to input a sentence in place of a numbered selection
                           when in the menus.
