using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //variables
        string Selection;

        public Player()
        {
            //probably don't need anthing here
        }

        //methods
        public virtual string GetUserInput()
        {
            do
            {
                Console.WriteLine("Choose one: Rock, Paper, Scissors, Lizzard, Spoch");
                Selection = Console.ReadLine();
            } while (!InputValidation(Selection));
            return Selection;
        }
        public bool InputValidation(string Selection)
        {
            if (Selection == "rock" || Selection == "paper" || Selection == "scissors" || Selection == "lizzard" || Selection == "spoch")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
