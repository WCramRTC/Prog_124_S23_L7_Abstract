using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L7_Abstract
{
    internal abstract class Motorized : Vehicle
    {
        protected int _hp;

        public Motorized(string characterName, string color, double speed, int hp) : base(characterName, color, speed)
        {
            _hp = hp;
        }


    }
}
