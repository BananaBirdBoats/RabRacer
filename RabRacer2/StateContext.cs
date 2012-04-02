using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    class StateContext
    {
        private State myState;
        public StateContext()
        {
            setState(new TitleScreen());
        }

        public void setState(State newState)
        {
           
            this.myState = newState;
        }

        public void writeName(String name)
        {
            this.myState.writeName(this, name);
        }

        public void welcomeScreen()
        {
            Game.status(Game.getPlayer());
            this.myState.welcomeScreen(this);
        }
    }
}
