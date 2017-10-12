using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class EnginePower
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        EngineSpeedUnit _unit;

        internal EngineSpeedUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public EnginePower(int number, EngineSpeedUnit unit)
        {
            _number = number;
            _unit = unit;
        }

    }
}
