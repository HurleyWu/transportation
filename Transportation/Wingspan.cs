using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Wingspan
    {
        int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        WinspanUnit _unit;

        internal WinspanUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public Wingspan (int number, WinspanUnit unit)
        {
            _number = number;
            _unit = unit;
        }
    }
}
