using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L7_Abstract
{
    // Implement Abstract
    internal abstract class Vehicle
    {
        // Protected means the class and any child has access to the members
        protected string _characterName;
        protected string _color;
        protected double _speed;

        public Vehicle(string characterName, string color, double speed)
        {
            _characterName = characterName;
            _color = color;
            _speed = speed;
        }

        // Abstract methods cannot have a body

        // Method Signature is defined by it's NAME and Parameters(), add the return type
        public abstract void Accelerate();


        public void Speedomiter()
        {
            Console.WriteLine($"{_characterName} - Current Speed: {_speed}");
        }



    } // class

} // namespace
