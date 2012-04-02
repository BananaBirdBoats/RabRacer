using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    class RabbitShop : State
    {
        private int stock;
        private Rabbit[] inventory;
        public void writeName(StateContext stateContext, String name)
        {
            Console.WriteLine("Sorry we are out of stock. " + name);
            stateContext.setState(new TitleScreen());
        }
        
        //Sets up a new rabbit shop and populates it with new random rabbits.
        public RabbitShop()
        {
            Random rand = new Random();
            stock = rand.Next(1, 15);
            inventory = new Rabbit[stock];

            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i] = new Rabbit(("Sam" + i.ToString()),
                                              rand.Next(0, Rabbit.getMaxStat()),
                                              rand.Next(0, Rabbit.getMaxStat()),
                                              rand.Next(0, Rabbit.getMaxStat()),
                                              rand.Next(0, Rabbit.getMaxStat()));
            }

        }
       
        //Default actions for the RabbitShop state.
        public void welcomeScreen(StateContext stateContext)
        {
            
            String input = "4";
            int caseSwitch = 99;
            while (!input.Equals("0"))
            {
                Console.WriteLine("Welcome to Rabbit Emporium!");
                Console.WriteLine("We currently have " + inventory.Length + " rabbits in stock.");
                
                Console.WriteLine("Press the number to take you to your desired action.");
                Console.WriteLine("2. Purchase Rabbits");
                Console.WriteLine("0. Quit");
                input = Console.ReadLine();
                Console.WriteLine("");
                caseSwitch = int.Parse(input);

                switch (caseSwitch)
                {
                    case 0:
                        Console.WriteLine("Thankyou for playing.");
                        input = "0";
                        stateContext.setState(new TitleScreen());
                        stateContext.welcomeScreen();
                        break;
                    case 1:
                        Console.WriteLine("Returning to title Screen");
                        stateContext.setState(new TitleScreen());
                        stateContext.welcomeScreen();
                        break;
                    case 2:
                        this.browseRabbits(stateContext);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }


            }
        }
        //Performs the mathmatical operations to purchase rabits.
        public void purchaseRabbit(Rabbit rabbit)
        {
            Player player = Game.getPlayer();
            player.setCredits(player.getCredits() - rabbit.getCost());
            Console.WriteLine("Deducted $" + rabbit.getCost() + " from your account");
            player.setCurrentRabbit(rabbit);
            Game.status(player);

        }
        //This method will be responsible for the purchase of new rabbits. This method currently allows for rabbit descriptions only
      
        public void browseRabbits(StateContext stateContext)
        {

            String input = "-1";
            int caseSwitch = 99;
            while (!input.Equals("99"))
            {
                Console.WriteLine("Welcome to Rabbit Emporium!");
                Console.WriteLine("99. Back");
                //Listing all rabbits in the stores stock.
                Console.WriteLine("Press the number to look at your desired rabbit.");
                for (int i = 0; i < this.inventory.Length; i++)
                {
                    Console.WriteLine(i.ToString() + ". " + inventory[i].getName());
                }

                input = Console.ReadLine();
                Console.WriteLine("");
                caseSwitch = int.Parse(input);

                switch (caseSwitch)
                {
                    case 99:
                        Console.WriteLine("Thankyou for visiting our store.");
                        input = "0";
                        stateContext.welcomeScreen();
                        break;
                    default:
                        Console.WriteLine(this.inventory[caseSwitch].getName() + "\n" +
                                          this.inventory[caseSwitch].describeStrength() + "\n" +
                                          this.inventory[caseSwitch].describeEndurance() + "\n" +
                                          this.inventory[caseSwitch].describeSpeed()+"\n$"+
                                          this.inventory[caseSwitch].getCost());
                        Console.WriteLine("Press " + caseSwitch + " again to purchase the rabbit " + this.inventory[caseSwitch].getName());
                        Console.WriteLine("Press any other key to go back");
                        input=Console.ReadLine();
                        if(int.Parse(input)==caseSwitch){
                            this.purchaseRabbit(this.inventory[caseSwitch]);
                        }

                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
          