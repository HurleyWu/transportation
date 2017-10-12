using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    abstract class Transportation : Moveable, Printable, Comparable<Transportation>
    {
        String _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        TransportationType _type;

        internal TransportationType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        EnginePower _enginePower;

        internal EnginePower EnginePower
        {
            get { return _enginePower; }
            set { _enginePower = value; }
        }

        MaxMoveSpeed _maxMoveSpeed;

        internal MaxMoveSpeed MaxMoveSpeed
        {
            get { return _maxMoveSpeed; }
            set { _maxMoveSpeed = value; }
        }

        public abstract void move();
        public abstract void printInfomationOfSelf();

        public abstract int compareTo(Transportation o);
    }
}
