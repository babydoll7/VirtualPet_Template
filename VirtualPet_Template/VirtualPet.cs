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
        private string exercise;
        private string tricks;

        //TODO fill in more fields

        //this defaut constructor is sets options without giving us any options
        public VirtualPet()
        {
            this.name = "Bubbles";
            this.hunger = 20;
            this.thirst = 40;
            this.exercise = "Run";
            this.tricks = "Jump";
                
            //TODO account for more fields
        }

        //TODO how can we set things with our construtor
        public VirtualPet(string name, int hunger, int thirst, string exercise, string tricks)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;
            this.exercise = exercise;
            this.tricks = tricks;
        }

        
        //this method can be called to increase the hunger
        public void HungerIncrease()
        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger + 3;
        }

        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {   
            //TODO modify these values to anything you see fit
            this.hunger = hunger - 5;
        }

        //TODO we need to add more methods to modify the other fields


        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            //TODO account for more fields
        }
    }
}
