using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
           
            //int hunger = 1;
            //int thirst = 2;
            
            //TODO add a greeting for the user. you can also let the user name the pet if you like

            Console.WriteLine("Hello and welcome to Virtual Petland!");
            Console.WriteLine("What would you like to name your pet kangaroo?");
            string petName = Console.ReadLine();
            VirtualPet myPet = new VirtualPet(petName, 1, 2, "pat", "run", "jump");
            int selectedOption;

            do
            {
                //TODO fill this out with more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("Please select an option between 1 and 5.  Type 'Q' to Quit ");
                Console.WriteLine("1. Feed " + petName);
                Console.WriteLine("2. Give " + petName + " something to drink");
                Console.WriteLine("3. Take " + petName + " for a run");
                Console.WriteLine("4. Pat " + petName + " on the head");
                Console.WriteLine("5. Tell " + petName + " to do a trick");
                Console.WriteLine("'10'. Quit");
                selectedOption = int.Parse(Console.ReadLine());

                while (selectedOption >= 1 && selectedOption <= 5) ;

                myPet.MyPetStatus();

                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet
                    //when the user selects option two we give the pet a drink
                    //when the user selects option three we pat the pet on the head
                    //when the user selects option four we take the pet for a run
                    //when the user selects option five we ask the pet to jump through a hoop
                    case 1:
                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        Console.WriteLine("Bubbles has been fed, and hunger Level has been decreased");
                        break;
                    case 2:
                        myPet.ThirstDecrease();
                        Console.WriteLine(petName + " thanks you for the water!");
                        Console.WriteLine("Bubbles has been fed, and hunger Level has been decreased");
                        break;
                    case 3:
                        myPet.TouchPet();
                        Console.WriteLine("What a sweet thing to do for " + petName);
                        Console.WriteLine("Bubbles has been fed but may still be a little hungry. Hunger Level has been decreased");
                        break;
                    case 4:
                        myPet.ExercisePet();
                        Console.WriteLine("Oh what fun to take " + petName + "for a run!");
                        break;
                    case 5:
                        myPet.TricksPet();
                        Console.WriteLine(petName + " likes to jump through hoops. What fun!");
                        break;
                    case 6:
                        Console.WriteLine("Pat on the head");
                        break;
                    case 7:
                        Console.WriteLine("Ride in " + petName + "'s pouch");
                        break;
                    case 8:
                        Console.WriteLine("Give " + petName + "a hug");
                        break;
                    case 9:
                        Console.WriteLine(petName + " thanks you for the love!");
                        break;

                   case 10:
                        Console.WriteLine(petName + " has enjoyed spending time with you. Good-bye! ");
                        Console.WriteLine("Thank you for playing with" + petName);
                        break;
                    default:
                        Console.WriteLine("Pick a valid option");
                        break;

                        //TODO we need to add more cases for the other ways to interact with our pet
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here

                myPet.HungerDecrease();
                
                {
                    Console.WriteLine("Invalid option. Please select a number between 1 and 5, or select '10' to Quit");
                }
                Console.WriteLine("Please select an option to touch " + petName);
                Console.WriteLine("Select 1 to pat " + petName + "on the head");
                Console.WriteLine("Select 2 to ride in " + petName + "'s pouch");
                Console.WriteLine("Select 3 to hug " + petName);
                Console.WriteLine("Select '10' to Quit");
                }

            while (selectedOption < 5 && selectedOption > 1);
                {
                Console.WriteLine("That was great! Select another option to keep playing!");
                }
   
           }
        }
    }

   
    

                // put this back in!! - while (selectedOption != 10);

