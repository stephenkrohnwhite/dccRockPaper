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
             * // need to ask player one for 'player one name' then player two for 'player two name'
             * when doing pvp rounds, get prompt to ask for player one or player two by name
             */
            HumanPlayer User = new HumanPlayer(1);
            GestureCollection GestureList = new GestureCollection();
           
            RunProgram();
            string UserGameType()
            {
                Console.WriteLine("To Select game mode, type PLAYER to play versus another player or CPU to play versus another player.");
                string result = Console.ReadLine();
                return result.ToLower();
            }
            bool GameTypeValidator(string userInput)
            {
                switch(userInput)
                {
                    case "player":
                    case "cpu":
                        return true;
                    default:
                        Console.WriteLine("Please enter a valid selection");
                        return false;
                }
            }
            int GameTypeInt(string input)
            {
                if (input == "player")
                {
                    return 1;
                }
                else if (input == "cpu")
                {
                    return 2;
                }
                else return 0;
                }
            int GameSelector()
            {
                string userChoice = UserGameType();
                if(GameTypeValidator(userChoice) == true)
                {
                    return GameTypeInt(userChoice);
                }
                else
                {
                    return GameSelector();
                }
            }
            void GameMode(int selection)
            {
                if(selection == 1)
                {
                    PVPGameRunner();
                }
                else if(selection == 2)
                {
                    CPUGameRunner();
                }
            }
            void RunProgram()
            {
                int selection = GameSelector();
                Console.Clear();
                GameMode(selection);
            }
            void CPUGameRunner()
            {
                ComputerPlayer Fred = new ComputerPlayer("Fred");
                int playerRoundScore = 0;
                int compRoundScore = 0;
                while (playerRoundScore < 3 && compRoundScore < 3)
                {
                    int userScore = User.MakeMove();
                    //replace optionsList
                    User.PrintPlayerChoice(User.name, userScore, User.optionsList);
                    Console.ReadKey();
                    //replace optionsList
                    int computerScore = Fred.MakeMove();
                    Fred.PrintPlayerChoice(Fred.name, computerScore, Fred.optionsList);
                    Console.ReadKey();
                    int value = CompareValues(userScore, computerScore);
                    int score = RoundScore(userScore, computerScore, User.name, Fred.name);
                    if(score == 1)
                    {
                        playerRoundScore++;
                    }
                    else if(score == 2)
                    {
                        compRoundScore++;
                    }
                }
                PrintVictor(playerRoundScore, compRoundScore, User.name, Fred.name);
                Console.ReadKey();
                RunProgram();
            }
            void PVPGameRunner()
            {
                HumanPlayer PlayerTwo = new HumanPlayer(2);
                int playerRoundScore = 0;
                int playerTwoRoundScore = 0;
                while (playerRoundScore < 3 && playerTwoRoundScore < 3)
                {
                    int userScore = User.MakeMove();
                    //replace optionsList
                    User.PrintPlayerChoice(User.name, userScore, User.optionsList);
                    Console.ReadKey();
                    Console.Clear();
                    int userTwoScore = PlayerTwo.MakeMove();
                    //replace optionsList
                    PlayerTwo.PrintPlayerChoice(PlayerTwo.name, userTwoScore, User.optionsList);
                    Console.ReadKey();
                    Console.Clear();
                    int value = CompareValues(userScore, userTwoScore);
                    int score = RoundScore(userScore, userTwoScore, User.name, PlayerTwo.name);
                    if (score == 1)
                    {
                        playerRoundScore++;
                        Console.Clear();
                    }
                    else if (score == 2)
                    {
                        playerTwoRoundScore++;
                        Console.Clear();
                    }
                }
                PrintVictor(playerRoundScore, playerTwoRoundScore, User.name, PlayerTwo.name);
                Console.ReadKey();
                RunProgram();
            }
            /*
            d = (5 + a - b) % 5. Then:
            d = 1 or d = 3 => a wins
            d = 2 or d = 4 => b wins
            d = 0 => tie
            */
            int CompareValues(int userValue, int secondPlayerValue)
            {
                int diff = (5 + userValue - secondPlayerValue) % 5;
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
            void PrintRoundVictor(int userInt, int compInt, int winnerInt, string playerOne, string playerTwo)
            {
                if (winnerInt == 1)
                    {
                        Console.WriteLine(GestureList.gestures[userInt].Name.ToUpper() + " beats " + GestureList.gestures[compInt].Name.ToUpper() + ". " + playerOne + " Wins the round!");
                    }
                else if (winnerInt == 2)
                    {
                    Console.WriteLine(GestureList.gestures[compInt].Name.ToUpper() + " beats " + GestureList.gestures[userInt].Name.ToUpper() + ". " + playerTwo + " Wins the round!");
                    }
                else if (winnerInt == 0)
                {
                    Console.WriteLine(GestureList.gestures[userInt].Name.ToUpper() + " is even with " + GestureList.gestures[compInt].Name.ToUpper() + ". TIE ROUND!!!");
                }
            }

            int RoundScore(int userInt, int compInt, string playerOne, string playerTwo)
            {
                int diff = CompareValues(userInt, compInt);
                int winnerValue = Winner(diff);
                PrintRoundVictor(userInt, compInt, winnerValue, playerOne, playerTwo);
                Console.ReadKey();
                return winnerValue;
            }
            void PrintVictor(int playerRoundScore, int playerTwoRoundScore, string playerOneName, string playerTwoName)
            {
                if(playerRoundScore == 3)
                {
                    Console.WriteLine("Congratulations " + playerOneName + "! You Win!! Press any key to restart game!");
                }
                if(playerTwoRoundScore == 3)
                {
                    Console.WriteLine("Congratulations " +playerTwoName+" You win!! Press any key to restart game!");
                }
            }
            
        }
    }
}
