using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    class Player
    {

        //Player represents the rabbit trainer. He should be able to own rabbits, buy rabbits and sell rabbits.
        private String name;
        private int credits;

        private ArrayList ownedRabs;
        private Rabbit currentRabbit;

        public Player(String name)
        {
            this.name = name;
            this.credits = 100000;
            this.ownedRabs = null;
            this.currentRabbit = null;
        }
        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }

        public int getCredits()
        {
            return this.credits;
        }
        public void setCredits(int credits)
        {
            this.credits= credits;
        }

        public ArrayList getOwnedRabbits()
        {
            return this.ownedRabs;
        }
        public void setOwnedRabs(ArrayList ownedRabs)
        {
            this.ownedRabs = ownedRabs;
        }

        public Rabbit getCurrentRabbit()
        {
            return this.currentRabbit;
        }
        public void setCurrentRabbit(Rabbit newRabbit)
        {
            this.currentRabbit = newRabbit;
        }

        

    }
}
