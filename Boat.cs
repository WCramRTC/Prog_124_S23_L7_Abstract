using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L7_Abstract
{
    internal class Boat : NaturalEnergy
    {

        protected double _knots;

        public Boat(string characterName, string color, double speed, double knots) : base(characterName, color, speed)
        {
            _knots = knots;
        }

        public override void Accelerate()
        {
            double mph = 20;
            double statuateMile = 5280;
            double ftPerHour = mph * statuateMile;
            double nauticaMph = 6076;
            _knots = ftPerHour / nauticaMph; 
        }
    }
}
