using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    class Rabbit
    {
         //The rabbit class is responsible for representing the main creature of the game. The rabbit.
   
        private const int MAXSTAT=1000;
        //Strength is an attribute responsible for how much distance a rabbit covers with a successful stride command.
        private int strength;
        //Determines how long the rabbit can maintain 100% effectiveness of its strides.
        private int endurance;
        //Determines the maximum possible speed a rabbit can attain.
        private int speed;
        //Determines how quickly a rabbit can accelerate(dodge obstacles?)
        private int agility;
        //The name of the rabbit.
        private String name;

        public Rabbit(String name,int strength, int endurance, int speed, int agility)
        {
            this.name = name;
            this.strength=strength;
            this.endurance=endurance;
            this.speed=speed;
            this.agility = agility;        
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }

        public String describeStrength()
        {
            if (this.strength <= 100)
            {
                return this.name + " looks skeletal.";
            }
            else if (this.strength <= 200)
            {
                return this.name + " nothing but skin and bones.";
            }
            else if (this.strength <= 300)
            {
                return this.name + " looks like a wet noodle.";
            }
            else if (this.strength <= 400)
            {
                return this.name + " looks underdeveloped.";
            }
            else if (this.strength <= 500)
            {
                return this.name + " looks healthy.";
            }
            else if (this.strength <= 600)
            {
                return this.name + " looks heavy.";
            }
            else if (this.strength <= 700)
            {
                return this.name + " looks defined.";
            }
            else if (this.strength <= 800)
            {
                return this.name + " looks meaty.";
            }
            else if (this.strength <= 900)
            {
                return this.name + " looks ripped.";
            }
            else if (this.strength <= 1000)
            {
                return this.name + " is a monster.";
            }
            else
            {
                return null;
            }
        }
        public int getStrength()
        {
            return this.strength;
        }
        public void setStrength(int strength)
        {
            this.strength = strength;
        }

        public String describeEndurance()
        {
            if (this.endurance <= 100)
            {
                return this.name + " looks dead.";
            }
            else if (this.endurance <= 200)
            {
                return this.name + " looks unconscious.";
            }
            else if (this.endurance <= 300)
            {
                return this.name + " looks asleep.";
            }
            else if (this.endurance <= 400)
            {
                return this.name + " looks drowsy.";
            }
            else if (this.endurance <= 500)
            {
                return this.name + " looks awake.";
            }
            else if (this.endurance <= 600)
            {
                return this.name + " looks energetic.";
            }
            else if (this.endurance <= 700)
            {
                return this.name + " looks excited.";
            }
            else if (this.endurance <= 800)
            {
                return this.name + " looks hyper.";
            }
            else if (this.endurance <= 900)
            {
                return this.name + " looks manic.";
            }
            else if (this.endurance <= 1000)
            {
                return this.name + " is a nuclear reactor.";
            }
            else
            {
                return null;
            }
        }
        public int getEndurance()
        {
            return this.endurance;
        }
        public void setEndurance(int endurance)
        {
            this.endurance = endurance;
        }

        public String describeSpeed()
        {
            if (this.speed <= 100)
            {
                return this.name + " looks incapable of moving.";
            }
            else if (this.speed <= 200)
            {
                return this.name + " looks sloth-like.";
            }
            else if (this.speed <= 300)
            {
                return this.name + " looks .";
            }
            else if (this.speed <= 400)
            {
                return this.name + " looks slow.";
            }
            else if (this.speed <= 500)
            {
                return this.name + " looks quick.";
            }
            else if (this.speed <= 600)
            {
                return this.name + " looks fast.";
            }
            else if (this.speed <= 700)
            {
                return this.name + " looks like a natural runner";
            }
            else if (this.speed <= 800)
            {
                return this.name + " is hard to follow with your eyes.";
            }
            else if (this.speed <= 900)
            {
                return this.name + " cannot be seen while moving.";
            }
            else if (this.speed <= 1000)
            {
                return this.name + " can probably break the sound barrier.";
            }
            else
            {
                return null;
            }
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public int getAgility()
        {
            return this.agility;
        }
        public void setAgility(int agility)
        {
            this.agility =agility;
        }

        public static int getMaxStat()
        {
            return MAXSTAT;
        }
    }
}

    

