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
        List<string> gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock"};

        public Player()
        {
            //probably don't need anthing here
        }

        //methods
        public virtual string GetUserInput()
        {
            do
            {
                Console.WriteLine("Choose one: Rock, Paper, Scissors, Lizard, Spock");
                Selection = Console.ReadLine();
            } while (!InputValidation(Selection));
            return Selection;
        }
        public virtual bool InputValidation(string Selection)
        {
            if (gestures.Contains(Selection))
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
