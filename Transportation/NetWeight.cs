using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class NetWeight
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        NetWeightUnit _unit;

        internal NetWeightUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        public NetWeight(int number, NetWeightUnit unit)
        {
            _number = number;
            _unit = unit;
        }
    }
}
