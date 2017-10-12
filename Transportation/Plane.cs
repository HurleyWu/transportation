using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Plane : Transportation
    {
        string _registration;

        public string Registration
        {
            get { return _registration; }
            set { _registration = value; }
        }


        Wingspan _wingspan;

        internal Wingspan Wingspan
        {
            get { return _wingspan; }
            set { _wingspan = value; }
        }

        LoadCapacity _loadCapacity;

        internal LoadCapacity LoadCapacity
        {
            get { return _loadCapacity; }
            set { _loadCapacity = value; }
        }

        NetWeight _netWeight;

        internal NetWeight NetWeight
        {
            get { return _netWeight; }
            set { _netWeight = value; }
        }

        PlaneType _planeType;

        internal PlaneType PlaneType
        {
            get { return _planeType; }
            set { _planeType = value; }
        }

        public Plane()
        {
            Type = TransportationType.PLANE;
        }


        public override void move()
        {
            Console.WriteLine("The plane is taking off !");
        }

        public override void printInfomationOfSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Transportation Type : " + Type).Append(" , ");
            sb.Append("name : " + Name).Append(" , ");
            sb.Append("Registration : " + Registration).Append(" , ");
            sb.Append("Engine Power : " + EnginePower.Number).Append(" ").Append(EnginePower.Unit).Append(" , ");
            sb.Append("Wingspan : " + Wingspan.Number).Append(" ").Append(Wingspan.Unit).Append(" , ");
            sb.Append("Load Capacity : " + LoadCapacity.Number).Append(" ").Append(LoadCapacity.Unit).Append(" , ");
            sb.Append("Net Weight : " + NetWeight.Number).Append(" ").Append(NetWeight.Unit).Append(" , ");
            sb.Append("Plane Type : " + PlaneType);
            Console.WriteLine(sb.ToString());
        }

        public override int compareTo(Transportation o)
        {
            throw new NotImplementedException();
        }
    }
}
