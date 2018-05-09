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
        public bool Validator(string input, List<string> options)
        {


            if (options.Contains(input))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
                return false;
            }
        }

        public int NumberAssign(string input, List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                if (input == options[i])
                {
                    int result = i;
                    return result;
                }

            }
            return 0;
        }

        public override int MakeMove()
        {
            string move = GetMove();
            if (Validator(move, base.optionsList) == true)
            {
                int numberScore = NumberAssign(move, base.optionsList);
                return numberScore;
            }
            else
            {
                return MakeMove();
            }
        }


    }
}
