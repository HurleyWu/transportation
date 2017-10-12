using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class LoadCapacity
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        LoadCapacityUnit _unit;

        internal LoadCapacityUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public LoadCapacity(int number, LoadCapacityUnit unit)
        {
            _number = number;
            _unit = unit;
        }
    }
}
