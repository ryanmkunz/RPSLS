using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //variables
        string OpponentType;

        public Game()
        {

        }
        //methods
        public void RunGame()
        {
            Human player1 = new Human();
            Referee referee = new Referee();
            do
            {
                Console.WriteLine("Would you like to play against the computer?");
                OpponentType = Console.ReadLine();
            } while (OpponentType != "yes" || OpponentType != "no");
            if (OpponentType == "yes")
            {
                Computer player2 = new Computer();
            }
            else
            {
                Human player2 = new Human();
            }
                        
        }
    }
}
