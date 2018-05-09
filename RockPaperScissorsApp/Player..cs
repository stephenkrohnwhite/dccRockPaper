using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    abstract class Player
    {
        public string name;
        public abstract int MakeMove();
        public List<string> optionsList = new List<string>()
        {
            "rock",
            "paper",
            "scissors",
            "lizard",
            "spock",
        };
        public void PrintPlayerChoice(string name, int input, List<string> options)
        {
            string selection = (options[input]).ToUpper();
            Console.WriteLine(name+" chose "+selection+"!");
        }
    }
    
}
