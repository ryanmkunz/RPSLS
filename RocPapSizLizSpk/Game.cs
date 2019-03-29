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
        Player player1;
        Player player2;
        string PlayAgain;

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
                    player1.PlayerName = "Computer 1";
                    player2.PlayerName = "Computer 2";
                    break;
                case "1":
                    player1 = new Human();
                    do
                    {
                        Console.WriteLine("Enter Player 1 name: ");
                        player1.PlayerName = Console.ReadLine();
                    } while (player1.PlayerName == "");
                    player2 = new Computer();
                    player2.PlayerName = "Computer";
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    do
                    {
                        Console.WriteLine("Enter Player 1 name: ");
                        player1.PlayerName = Console.ReadLine();
                    } while (player1.PlayerName == "");
                    do
                    {
                        Console.WriteLine("Enter Player 2 name: ");
                        player2.PlayerName = Console.ReadLine();
                    } while (player2.PlayerName == "");
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
                player1.Selection = player1.GetUserInput();
                Console.WriteLine(player1.PlayerName+" chose: "+player1.Selection);
                player2.Selection = player2.GetUserInput();
                Console.WriteLine(player2.PlayerName+" chose: "+player2.Selection);
                WhoWon(player1.Selection, player2.Selection);
                Console.WriteLine(player1.PlayerName+" score: "+player1.Score+'\n'+player2.PlayerName+" score: "+player2.Score);
            } while (player1.Score < 2 && player2.Score < 2);

            if (player1.Score == 2 && player2.Score <= 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (player2.Score == 2 && player1.Score <= 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            do
            {
                Console.WriteLine("Would you like to play again?");
                PlayAgain = Console.ReadLine();

            } while (PlayAgain != "yes" && PlayAgain != "no");
            if (PlayAgain == "yes")
            {
                Game newGame = new Game();
                newGame.RunGame();
            }
            else if (PlayAgain == "no")
            {
                //how do you close the program?
            }
        }
        public void WhoWon(string Player1Selection, string Player2Selection)
        {
            /* Rock crushes Scissors
             * Scissors cuts Paper
             * Paper covers Rock
             * Rock crushes Lizard
             * Lizard poisons Spock
             * Spock smashes Scissors
             * Scissors decapitates Lizard
             * Lizard eats Paper
             * Paper disproves Spock
             * Spock vaporizes Rock */

            if (Player1Selection == "rock" && Player2Selection == "scissors")
            {
                player1.Score++;
            }
            else if (Player2Selection == "rock" && Player1Selection == "scissors")
            {
                player2.Score++;
            }
            else if (Player1Selection == "scissors" && Player2Selection == "paper")
            {
                player1.Score++;
            }
            else if (Player2Selection == "scissors" && Player1Selection == "paper")
            {
                player2.Score++;
            }
            else if (Player1Selection == "paper" && Player2Selection == "rock")
            {
                player1.Score++;
            }
            else if (Player2Selection == "paper" && Player1Selection == "rock")
            {
                player2.Score++;
            }
            else if (Player1Selection == "rock" && Player2Selection == "lizard")
            {
                player1.Score++;
            }
            else if (Player2Selection == "rock" && Player1Selection == "lizard")
            {
                player2.Score++;
            }
            else if (Player1Selection == "lizard" && Player2Selection == "spock")
            {
                player1.Score++;
            }
            else if (Player2Selection == "lizard" && Player1Selection == "spock")
            {
                player2.Score++;
            }
            else if (Player1Selection == "spock" && Player2Selection == "scissors")
            {
                player1.Score++;
            }
            else if (Player2Selection == "spock" && Player1Selection == "scissors")
            {
                player2.Score++;
            }
            else if (Player1Selection == "scissors" && Player2Selection == "lizard")
            {
                player1.Score++;
            }
            else if (Player2Selection == "scissors" && Player1Selection == "lizard")
            {
                player2.Score++;
            }
            else if (Player1Selection == "lizard" && Player2Selection == "paper")
            {
                player1.Score++;
            }
            else if (Player2Selection == "lizard" && Player1Selection == "paper")
            {
                player2.Score++;
            }
            else if (Player1Selection == "paper" && Player2Selection == "spock")
            {
                player1.Score++;
            }
            else if (Player2Selection == "paper" && Player1Selection == "spock")
            {
                player2.Score++;
            }
            else if (Player1Selection == "spock" && Player2Selection == "rock")
            {
                player1.Score++;
            }
            else if (Player2Selection == "spock" && Player1Selection == "rock")
            {
                player2.Score++;
            }
        }
    }
}
