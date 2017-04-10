using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
        
    {
        //We're setting our fields to private here so only the VirtualPet class can modify them directly
        private string name;
        private int hunger;
        private int thirst;
        private string touch;
        private string exercise;
        private string tricks;

        //TODO fill in more fields

        //this defaut constructor is sets options without giving us any options
        public VirtualPet(string name)
        {
            this.name = name;
        }
        //public VirtualPet(int hunger)
        //{
        //    this.hunger = hunger;
        //}
         
        //TODO account for more fields

        //TODO how can we set things with our construtor
        public VirtualPet(string name, int hunger, int thirst, string touch, string exercise, string tricks)
        {
            this.name = name;
            this.hunger = 1;
            this.thirst = 2;
            this.touch = touch;
            this.exercise = exercise;
            this.tricks = tricks;
        }

        //this method can be called to increase the hunger
        public void HungerLevelIncrease()

        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger + 1;
        }

        public void ThirstLevelIncrease()
        {
            this.thirst = thirst + 1;
        }

        public void TouchPet()
        {
            this.touch = "Pat on the head";
        }

        public void ExercisePet()
        {
            this.exercise = "Run around the park";
        }

        public void TricksPet()
        {
            this.tricks = "jump through the hoop";
        }

        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {
            //TODO modify these values to anything you see fit
            
            this.hunger = hunger - 1;
        }

        public void ThirstDecrease()
        {
            this.thirst = thirst - 1;
        }
                   
        //TODO we need to add more methods to modify the other fields

        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Touch: " + touch);
            Console.WriteLine("Exercise: " + exercise);
            Console.WriteLine("Tricks: " + tricks);

            //TODO account for more fields
        }
    }
}
