using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L7_Abstract
{
    internal class GoKart : Motorized
    {
        public GoKart(string characterName, string color, double speed, int hp) : base(characterName, color, speed, hp)
        {
        }

        public override void Accelerate()
        {
            _speed += _hp / 3.0;
        }

    } // class

} // namespace
