using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    class GestureCollection : Gestures
     {
        public List<Gestures> gestures = new List<Gestures>()
        {
            new Gestures {Name="Rock", ActionOne="crushes", ActionTwo="crushes", CallID = 0, ToActionIDOne=2, ToActionIDTwo=4},
            new Gestures {Name="Paper", ActionOne="covers", ActionTwo ="disproves", CallID = 1, ToActionIDOne=0, ToActionIDTwo=3},
            new Gestures {Name="Scissors", ActionOne="cuts", ActionTwo="decapitates", CallID = 2, ToActionIDOne=1, ToActionIDTwo=4},
            new Gestures {Name="Spock", ActionOne="vaporizes", ActionTwo="smashes", CallID = 3, ToActionIDOne=0, ToActionIDTwo=2},
            new Gestures {Name="Lizard", ActionOne="poisons", ActionTwo="eats", CallID = 4, ToActionIDOne=3, ToActionIDTwo=1}
        };
        //need to take integer input for winner and loser selection. 
       //if gesture[winner].ActionOneID==gesture[loser].CallID {
        //console log gesture[winner]. gesture[winner].
        //}else if gesture[winner].ActionTwoID=-gesture[loser].CallID{
        //console log gesture[winner].name + " " +gesture[winner].ActionTwo+"gesture[loster]
        public string PrintRoundWinner(int winner, int loser, string playerName)
        {
            if(gestures[winner].ToActionIDOne == gestures[loser].CallID)
            {
                Console.WriteLine(gestures[winner].Name + " " + gestures[winner].ActionOne + " " + gestures[loser].Name + ". "+playerName+" wins round.");
                string roundVictor = Console.ReadLine();
                return roundVictor;
            }
            else if (gestures[winner].ToActionIDTwo == gestures[loser].CallID)
            {
                Console.WriteLine(gestures[winner].Name + " " + gestures[winner].ActionTwo + " " + gestures[loser].Name + ". "+playerName+" wins round.");
                string roundVictor = Console.ReadLine();
                return roundVictor;
            }
            else
            {
                Console.WriteLine("DRAW!");
                string roundTie = Console.ReadLine();
                return roundTie;
            }
        }
    }
}
