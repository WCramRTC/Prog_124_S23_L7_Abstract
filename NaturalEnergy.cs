using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L7_Abstract
{
    internal abstract class NaturalEnergy : Vehicle
    {
        protected NaturalEnergy(string characterName, string color, double speed) : base(characterName, color, speed)
        {
        }
    }
}
