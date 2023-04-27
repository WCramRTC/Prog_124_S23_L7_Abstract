using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L7_Abstract
{
    internal class Motorcycle : Motorized
    {
        public Motorcycle(string characterName, string color, double speed, int hp) : base(characterName, color, speed, hp)
        {
        }

        public override void Accelerate()
        {
            Console.WriteLine("Vroom Vroom");
        }
    } // class

} // namespace
