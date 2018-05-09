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
             *  
             * 
             */
            HumanPlayer User = new HumanPlayer();
            ComputerPlayer Fred = new ComputerPlayer("Fred");
            int UserScore = User.MakeMove();
            Console.WriteLine(UserScore);
            Console.ReadLine();
        }
    }
}
