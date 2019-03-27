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
        string PlayerName;
        List<string> gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spoch"};

        public Player()
        {
            //probably don't need anthing here
        }

        //methods
        public virtual string GetUserInput()
        {
            do
            {
                Console.WriteLine("Choose one: Rock, Paper, Scissors, Lizard, Spoch");
                Selection = Console.ReadLine();
            } while (!InputValidation(Selection));
            return Selection;
        }
        public virtual bool InputValidation(string Selection)
        {
            //replace condition with some form of gestures.contains(Selection)
            if (Selection == "rock" || Selection == "paper" || Selection == "scissors" || Selection == "lizard" || Selection == "spoch")
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
