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
        string Player1Selection;
        string Player2Selection;
        int Player1Score = 0;
        int Player2Score = 0;

        public Game()
        {

        }
        //methods
        public void RunGame()
        {
            Human player1 = new Human();
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
        public void WhoWon(string Player1Selection, string Player2Selection)
        {
            /* Rock crushes Scissors (done)
             * Scissors cuts Paper (done)
             * Paper covers Rock (done)
             * Rock crushes Lizard (done)
             * Lizard poisons Spock (done)
             * Spock smashes Scissors (done)
             * Scissors decapitates Lizard (done)
             * Lizard eats Paper
             * Paper disproves Spock (done)
             * Spock vaporizes Rock (done) */

            if (Player1Selection == "rock" && Player2Selection == "scissors")
            {
                Player1Score++;
            }
            else if (Player2Selection == "rock" && Player1Selection == "scissors")
            {
                Player2Score++;
            }
            else if (Player1Selection == "scissors" && Player2Selection == "paper")
            {
                Player1Score++;
            }
            else if (Player2Selection == "scissors" && Player1Selection == "paper")
            {
                Player2Score++;
            }
            else if (Player1Selection == "paper" && Player2Selection == "rock")
            {
                Player1Score++;
            }
            else if (Player2Selection == "paper" && Player1Selection == "rock")
            {
                Player2Score++;
            }
            else if (Player1Selection == "rock" && Player2Selection == "lizard")
            {
                Player1Score++;
            }
            else if (Player2Selection == "rock" && Player1Selection == "lizard")
            {
                Player2Score++;
            }
            else if (Player1Selection == "lizard" && Player2Selection == "spock")
            {
                Player1Score++;
            }
            else if (Player2Selection == "lizard" && Player1Selection == "spock")
            {
                Player2Score++;
            }
            else if (Player1Selection == "spock" && Player2Selection == "scissors")
            {
                Player1Score++;
            }
            else if (Player2Selection == "spock" && Player1Selection == "scissors")
            {
                Player2Score++;
            }
            else if (Player1Selection == "scissors" && Player2Selection == "lizard")
            {
                Player1Score++;
            }
            else if (Player2Selection == "scissors" && Player1Selection == "lizard")
            {
                Player2Score++;
            }
            else if (Player1Selection == "lizard" && Player2Selection == "paper")
            {
                Player1Score++;
            }
            else if (Player2Selection == "lizard" && Player1Selection == "paper")
            {
                Player2Score++;
            }
            else if (Player1Selection == "paper" && Player2Selection == "spock")
            {
                Player1Score++;
            }
            else if (Player2Selection == "paper" && Player1Selection == "spock")
            {
                Player2Score++;
            }
            else if (Player1Selection == "spock" && Player2Selection == "rock")
            {
                Player1Score++;
            }
            else if (Player2Selection == "spock" && Player1Selection == "rock")
            {
                Player2Score++;
            }

        }
    }
}
