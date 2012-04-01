using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabRacer2
{
    interface State
    {
        void writeName(StateContext context, String name);
        //This will be the default screen to transport to on a state transition
        void welcomeScreen(StateContext context);
    }
}
