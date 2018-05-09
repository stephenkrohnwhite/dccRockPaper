using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            this.name = GetName();
        }
        public string GetName()
        {
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();
            return name;
        }
        public string GetMove()
        {
            Console.WriteLine("Please enter 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'");
            string move = Console.ReadLine();
            return move.ToLower();
        }
        public bool Validator(string input)
        {
            switch(input)
            {
                case "rock":
                case "paper":
                case "scissors":
                case "lizard":
                case "spock":
                    return true;
                default:
                    Console.WriteLine("Please enter a valid selection");
                    return false;
            }
        }
        public int NumberAssign(string input)
        {
            switch(input)
            {
                case "rock":
                    return 0;
                case "paper":
                    return 1;
                case "scissors":
                    return 2;
                case "lizard":
                    return 3;
                case "spock":
                    return 4;
                default:
                    return 0;
            }
        }
        public override int MakeMove()
        {
            string move = GetMove();
            if (Validator(move) == true)
            {
                int numberScore = NumberAssign(move);
                return numberScore;
            }
            else MakeMove();
            return 0;
        }
    }
}
