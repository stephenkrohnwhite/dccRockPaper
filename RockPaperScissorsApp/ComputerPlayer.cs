using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    class   ComputerPlayer : Player
    {
        public ComputerPlayer(string name)
        {
            this.name = name;
        }
        public int RandomValue()
        {
            Random rdm = new Random();
            int randomValue = rdm.Next(0, 5);
            return randomValue;
        }
        public override int MakeMove()
        {
            int value = RandomValue();
            return value;
            //throw new NotImplementedException();
        }
    }
}
