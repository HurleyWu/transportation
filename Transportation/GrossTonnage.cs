using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class GrossTonnage
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        GrossTonnageUnit _unit;

        internal GrossTonnageUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public GrossTonnage (int number, GrossTonnageUnit unit)
        {
            _number = number;
            _unit = unit;
        }

    }
}
