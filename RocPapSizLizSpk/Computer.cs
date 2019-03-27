using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //variables
        string ComputerSelection;

        public Computer()
        {

        }

        //methods
        public override string GetUserInput()
        {
            //generate a random input
            return "spoch";
        }

    }
}
