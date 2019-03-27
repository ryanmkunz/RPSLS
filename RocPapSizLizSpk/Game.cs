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
        Player player1;
        Player player2;

        //PROPERLY implement inheritance none of this Human player1 = new Human() nonesense ---- it needs to be Player player1 = new Human()
        //Take full advantage of classes and inheritance by using Player1.Selection instead of a unique variaible for Player1Selection

        public Game()
        {
            
        }
        //methods
        public void RunGame()
        {
            do
            {
                Console.WriteLine("Enter number of players: ");
                OpponentType = Console.ReadLine();
            } while (OpponentType != "0" && OpponentType != "1" && OpponentType != "2");

            switch(OpponentType)
            {
                case "0":
                    player1 = new Computer();
                    player2 = new Computer();
                    break;
                case "1":
                    player1 = new Human();
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    break;
                default:
                    break;

            }
            GamePlay(player1, player2);
        }
        public void GamePlay(Player player1, Player player2)
        {
            do
            {
                Player1Selection = player1.GetUserInput();
                Console.WriteLine("Player 1 chose: "+Player1Selection);
                Player2Selection = player2.GetUserInput();
                Console.WriteLine("Player 2 chose: "+Player2Selection);
                WhoWon(Player1Selection, Player2Selection);
                Console.WriteLine("Player 1 score: "+Player1Score+'\n'+"Player 2 score: "+Player2Score);
            } while (Player1Score < 2 && Player2Score < 2);

            if (Player1Score == 2 && Player2Score <= 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (Player2Score == 2 && Player1Score <= 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            do
            {
                Console.WriteLine("Would you like to play again?");
            } while (Console.ReadLine() != "yes" );
            if (Console.ReadLine() == "yes")
            {
                Game newGame = new Game();
                newGame.RunGame();
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
             * Lizard eats Paper (done)
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
