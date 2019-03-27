using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Rock Paper Scissors Lizzard Spoch
             * Must use parent/child classes for this assignment
             * Best 2/3 
             * No front-end requirement
             * 
             * Class planning:
             * check to see who won
             * get user input (User)
             * get computer input (ComputerPlayer)
             * do I need to have an option to play against a second user? Yes.
             * validate user input (User)
             * I want to store all of the gesture options/choices in a List
             * As a player, I want the option of a single player (human vs AI) 
             * or a multiplayer (human vs human) game.
             */
            Game game = new Game();
            game.RunGame();
        }
    }
}
