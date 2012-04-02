using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    class TitleScreen : State
    {
        public void writeName(StateContext stateContext, String name)
        {
            Console.WriteLine("Welcome! "+name);
            stateContext.setState(new RabbitShop());
        }

        //This method is responsible for displaying the welcome screen options.
        public void welcomeScreen(StateContext stateContext)
        {
            
            String input="4";
            int caseSwitch=99;
            while (!input.Equals("0"))
            {
                Console.WriteLine("Welcome to RabRacer!");
                Console.WriteLine("Press the number to take you to your desired location.");
                //Checking for the existence of a player.
                if (Game.getPlayer() == null)
                {
                    Console.WriteLine("1. Create new player");
                }
                else
                {
                    Console.WriteLine("1. Rabbit Shop");
                }
                Console.WriteLine("0. Quit");
                input = Console.ReadLine();
                caseSwitch=int.Parse(input);

                switch(caseSwitch)
                {
                     case 0:
                        Console.WriteLine("Thankyou for playing.");
                        input="0";
                        break;
                     case 1:
                        if (Game.getPlayer() == null)
                        {
                            Console.WriteLine("Please enter a name for your player.");
                            Game.setPlayer(new Player(Console.ReadLine()));
                            stateContext.welcomeScreen();
                        }
                        else
                        {
                            Console.WriteLine("Moving to the rabbit shop");
                            stateContext.setState(new RabbitShop());
                            stateContext.welcomeScreen();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
               
                
            }
        }
        
    }
}
