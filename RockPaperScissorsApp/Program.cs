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
            Game RockPaperScissors = new Game();
            RockPaperScissors.RunProgram();

            
        }
    }
}
