﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //variables
        int selection;
        string playerName = "Computer";

        public Computer()
        {

        }

        //methods
        public override string GetUserInput()
        {
            Random random = new Random();
            selection = random.Next(1, 6); //random from 1-5

            switch(selection)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                case 4:
                    return "lizard";
                case 5:
                    return "spock";
                default:
                    Console.WriteLine("error in GetUserInput() in Computer class");
                    return "spock";
            }
        }

    }
}
