using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            //information in the memory
            //all transportations
            List<Transportation> transportations = new List<Transportation>();
            //car 1
            Car car1 = new Car();
            car1.Name = "car 1";
            car1.LicensePlate = "NF123456";
            car1.EnginePower = new EnginePower(147, EngineSpeedUnit.KW);
            car1.MaxMoveSpeed = new MaxMoveSpeed(200, MoveSpeedUnit.KM_PER_HOUR);
            car1.Colour = Colour.GREEN;
            car1.VehicleType = VehicleType.PERSONAL_VEHICLE;
            transportations.Add(car1);

            //car 2
            Car car2 = new Car();
            car2.Name = "car 2";
            car2.LicensePlate = "NF654321";
            car2.EnginePower = new EnginePower(150, EngineSpeedUnit.KW);
            car2.MaxMoveSpeed = new MaxMoveSpeed(195, MoveSpeedUnit.KM_PER_HOUR);
            car2.Colour = Colour.BLUE;
            car2.VehicleType = VehicleType.PERSONAL_VEHICLE;
            transportations.Add(car2);

            //plane
            Plane plane1 = new Plane();
            plane1.Name = "plane";
            plane1.Registration = "LN1234";
            plane1.EnginePower = new EnginePower(1000, EngineSpeedUnit.KW);
            plane1.Wingspan = new Wingspan(30, WinspanUnit.M);
            plane1.LoadCapacity = new LoadCapacity(21, LoadCapacityUnit.T);
            plane1.NetWeight = new NetWeight(10, NetWeightUnit.T);
            plane1.PlaneType = PlaneType.FLYING_CLASS_OF_JET_PLANE;
            transportations.Add(plane1);

            //boat
            Boat boat1 = new Boat();
            boat1.Name = "boat";
            boat1.Registration = "ABC123";
            boat1.EnginePower = new EnginePower(100, EngineSpeedUnit.KW);
            boat1.MaxMoveSpeed = new MaxMoveSpeed(30, MoveSpeedUnit.KNOT_PER_HOUR);
            boat1.GrossTonnage = new GrossTonnage(500, GrossTonnageUnit.KG);
            transportations.Add(boat1);

            

            while (true)
            {
                Console.WriteLine("***********************Command begin***********************************");
                Console.WriteLine("Please input the number of what do you what to do");
                Console.WriteLine("1 -> Print Information");
                Console.WriteLine("2 -> Compare with two cars");
                Console.WriteLine("3 -> Ask to move");
                Console.WriteLine("4 -> Quit");

                string readLine = Console.ReadLine();
                if(null == readLine || readLine.Trim().Equals(""))
                {
                    Console.WriteLine("Please input the right command");
                    continue;
                }
                bool isquit = false;
                switch (readLine.Trim())
                {
                    case "1":
                        printing(transportations);
                        break;
                    case "2":
                        compareWithTwoCars(transportations);
                        break;
                    case "3":
                        askToMoveAndPrint(transportations);
                        break;
                    case "4":
                        isquit = true;
                        break;
                }
                if(isquit)
                {
                    break;
                }
                Console.WriteLine("***********************Command end***********************************");

            }


            
        }


        private static void askToMoveAndPrint(List<Transportation> transportations)
        {
            Console.WriteLine("Please input the name of transportation which to fly and print");
            string name = Console.ReadLine();
            if (null == name || name.Trim().Equals(""))
            {
                Console.WriteLine("The Input counld not be empty!");
                return;
            }
            bool isExist = false;
            foreach (Transportation item in transportations)
            {
                if(item.Name.Equals(name))
                {
                    item.printInfomationOfSelf();
                    item.move();
                    isExist = true;
                }
            }
            if(!isExist)
            {
                Console.WriteLine("There is no transportation of " + name );
                return;
            }

        }

        private static void compareWithTwoCars(List<Transportation> transportations)
        {
            Console.WriteLine("Please input the first car");
            string firstCarName = Console.ReadLine();
            if (null == firstCarName || firstCarName.Trim().Equals(""))
            {
                Console.WriteLine("The Input counld not be empty!");
                return;
            }
            Car firstCar = null;
            foreach (Transportation item in transportations)
            {
                if(item.Type == TransportationType.CAR && item.Name.Equals(firstCarName))
                {
                    firstCar = (Car)item;
                }
            }
            if (null == firstCar)
            {
                Console.WriteLine("The Car does not exist !");
                return;
            }


            Console.WriteLine("Please input the second car");
            string secondCarName = Console.ReadLine();
            if (null == secondCarName || secondCarName.Trim().Equals(""))
            {
                Console.WriteLine("The Input counld not be empty!");
                return;
            }
            Car secondCar = null;
            foreach (Transportation item in transportations)
            {
                if (item.Type == TransportationType.CAR && item.Name.Equals(secondCarName))
                {
                    secondCar = (Car)item;
                }
            }
            if(null == secondCar)
            {
                Console.WriteLine("The Car does not exist !");
                return;
            }

            if (firstCar.LicensePlate.Equals(secondCar.LicensePlate))
            {
                Console.WriteLine("The two Cars are the same vehicles!");
            }
            else
            {
                Console.WriteLine("The two Cars are not the same vehicles!");
            }


        }

        private static void printing(List<Transportation> transportations) 
        {
        
            Console.WriteLine("There are three kinds of transportations as follows");
            foreach (Transportation item in transportations)
            {
                item.printInfomationOfSelf();
            } 
        
        }

    }
}
