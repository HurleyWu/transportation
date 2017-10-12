using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Car : Transportation
    {
        string _licensePlate;

        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        Colour _colour;

        internal Colour Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        VehicleType _vehicleType;

        internal VehicleType VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }

        public Car()
        {
            Type = TransportationType.CAR;
        }


        public override void move()
        {
            Console.WriteLine("The car is driving forward !");
        }

        public override void printInfomationOfSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Transportation Type : " + Type).Append(" , ");
            sb.Append("name : " + Name).Append(" , ");
            sb.Append("License Plate : " + LicensePlate).Append(" , ");
            sb.Append("Engine Power : " + EnginePower.Number).Append(" ").Append(EnginePower.Unit).Append(" , ");
            sb.Append("Maximal Speed : " + MaxMoveSpeed.Number).Append(" ").Append(MaxMoveSpeed.Unit).Append(" , ");
            sb.Append("Colour : " + Colour).Append(" , ");
            sb.Append("Vehicle Type : " + VehicleType);
            Console.WriteLine(sb.ToString());
        }

        public override int compareTo(Transportation o)
        {
            throw new NotImplementedException();
        }
    }
}
