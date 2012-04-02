using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    class Game
    {
        private static Player user;
       
        public static void start()
        {
            StateContext context = new StateContext();
            context.welcomeScreen();
        }

        public static Player getPlayer()
        {
            return user;
        }
        public static void setPlayer(Player newUser)
        {
            user = newUser;
        }

        public static void status(Player user)
        {
            try
            {
                Console.WriteLine("Name: " + user.getName() +
                              "\nCredits: " + user.getCredits() +
                              "\nCurrent Rabbit " + user.getCurrentRabbit());
                Console.WriteLine("");
            }
            catch (Exception )
            {
            }             
        }
    }
}
