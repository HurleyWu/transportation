using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Boat : Transportation
    {
        string _registration;

        public string Registration
        {
            get { return _registration; }
            set { _registration = value; }
        }

        GrossTonnage _grossTonnage;

        internal GrossTonnage GrossTonnage
        {
            get { return _grossTonnage; }
            set { _grossTonnage = value; }
        }

        public Boat()
        {
            Type = TransportationType.BOAT;
        }

        public override void move()
        {
            Console.WriteLine("The boat is Shipping forward !");
        }

        public override void printInfomationOfSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Transportation Type : " + Type).Append(" , ");
            sb.Append("name : " + Name).Append(" , ");
            sb.Append("Registration : " + Registration).Append(" , ");
            sb.Append("Engine Power : " + EnginePower.Number).Append(" ").Append(EnginePower.Unit).Append(" , ");
            sb.Append("Maximal Speed : " + MaxMoveSpeed.Number).Append(" ").Append(MaxMoveSpeed.Unit).Append(" , ");
            sb.Append("Gross Tonnage : " + GrossTonnage);
            Console.WriteLine(sb.ToString());
        }

        public override int compareTo(Transportation o)
        {
            throw new NotImplementedException();
        }
    }
}
