using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class MaxMoveSpeed
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        MoveSpeedUnit _unit;

        internal MoveSpeedUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public MaxMoveSpeed(int number, MoveSpeedUnit unit)
        {
            _number = number;
            _unit = unit;
        }
    }
}
