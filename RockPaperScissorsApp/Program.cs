using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Need to create base player class that makes move
             * need program class to assign value MakeMove() function
             * need to establish relationship between values
             *  need to develop round score
             * need to develop match score
             */
            
            HumanPlayer User = new HumanPlayer();
            ComputerPlayer Fred = new ComputerPlayer("Fred");
            GameRunner();
            void GameRunner()
            {
                int playerRoundScore = 0;
                int compRoundScore = 0;
                while (playerRoundScore < 3 && compRoundScore < 3)
                {
                    int userScore = User.MakeMove();
                    User.PrintPlayerChoice(User.name, userScore, User.optionsList);
                    Console.ReadKey();
                    int computerScore = Fred.MakeMove();
                    Fred.PrintPlayerChoice(Fred.name, computerScore, Fred.optionsList);
                    Console.ReadKey();
                    int value = CompareValues(userScore, computerScore);
                    int score = RoundScore(userScore, computerScore);
                    if(score == 1)
                    {
                        playerRoundScore++;
                    }
                    else if(score == 2)
                    {
                        compRoundScore++;
                    }
                }
                PrintVictor(playerRoundScore, compRoundScore);
                Console.ReadKey();
                GameRunner();
            }

            
            /*
            d = (5 + a - b) % 5. Then:
            d = 1 or d = 3 => a wins
            d = 2 or d = 4 => b wins
            d = 0 => tie
            */
            int CompareValues(int userValue, int compValue)
            {
                int diff = (5 + userValue - compValue) % 5;
                return diff;
            }
            int Winner(int difference)
            {
                switch(difference)
                {
                    case 1:
                    case 3:
                        return 1;
                    case 2:
                    case 4:
                        return 2;
                    case 0:
                        return 0;
                    default:
                        return 0;
                }
            }
            void PrintRoundVictor(int userInt, int compInt, int winnerInt)
            {
                if (winnerInt == 1)
                    {
                        Console.WriteLine(User.optionsList[userInt].ToUpper() + " beats " + Fred.optionsList[compInt].ToUpper() + ". " + User.name + " Wins the round!");
                    }
                else if (winnerInt == 2)
                    {
                    Console.WriteLine(Fred.optionsList[compInt].ToUpper() + " beats " + User.optionsList[userInt].ToUpper() + ". " + Fred.name + " Wins the round!");
                    }
                else if (winnerInt == 0)
                {
                    Console.WriteLine(User.optionsList[userInt].ToUpper() + " is even with " + Fred.optionsList[compInt].ToUpper() + ". TIE ROUND!!!");
                }
            }

            int RoundScore(int userInt, int compInt)
            {
                int diff = CompareValues(userInt, compInt);
                int winnerValue = Winner(diff);
                PrintRoundVictor(userInt, compInt, winnerValue);
                Console.ReadKey();
                return winnerValue;
            }
            void PrintVictor(int playerRoundScore, int computerRoundScore)
            {
                if(playerRoundScore == 3)
                {
                    Console.WriteLine("Congratulations " + User.name + " ! You Win!! Press any key to restart game!");
                }
                if(computerRoundScore == 3)
                {
                    Console.WriteLine("Sorry, you lose to " + Fred.name + ". Press any key to restart game!");
                }
            }
            
        }
    }
}
