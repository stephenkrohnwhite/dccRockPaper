using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    class HumanPlayer : Player
    {
        GestureCollection GestureGame = new GestureCollection();
        public HumanPlayer(int playerNumber)
        {
            this.name = GetName(playerNumber);
        }
        public string GetName(int playerNumber)
        {
            Console.WriteLine("Player "+ playerNumber+ ": Please Enter Your Name");
            string name = Console.ReadLine();
            return name;
        }
        public string GetMove(string playerName)
        {
            Console.WriteLine(playerName+": Please enter "+GestureGame.gestures[0].Name+", "+ GestureGame.gestures[1].Name + ", "+ GestureGame.gestures[2].Name + ", "+ GestureGame.gestures[3].Name
            + ", or "+ GestureGame.gestures[4].Name + ".");
            string move = Console.ReadLine();
            return move.ToLower();
        }
        public List<string> GetGestureNameList()
        {
            List<string> gestureNames = new List<string>();
            for(int i = 0; i<GestureGame.gestures.Count; i++)
            {
                gestureNames.Add((GestureGame.gestures[i].Name).ToLower());
            }
            return gestureNames;
        }
        public bool Validator(string input, List<string> gestureNames)
        {


            if (gestureNames.Contains(input))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
                return false;
            }
        }

        public int NumberAssign(string input)
        {
            for (int i = 0; i < GestureGame.gestures.Count; i++)
            {
                if (input == (GestureGame.gestures[i].Name).ToLower())
                {
                    return GestureGame.gestures[i].CallID;
                }

            }
            return 0;
        }

        public override int MakeMove()
        {
            List<string> gestureNames = GetGestureNameList();
            string move = GetMove(this.name);
            if (Validator(move, gestureNames) == true)
            {
                int numberScore = NumberAssign(move);
                return numberScore;
            }
            else
            {
                return MakeMove();
            }
        }


    }
}
