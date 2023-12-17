using System;

namespace Lab_5_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportNetwork network = SetupTransportNetwork();

            network.MoveAllVehicles();

            Route route = new Route("City A", "City B");
            network.CalculateOptimalRoute(route, new Car());

            network.PassengerOperation(new Bus(), 24, "Boarding");
            network.PassengerOperation(new Train(), 48, "Disembarking");
        }

        static TransportNetwork SetupTransportNetwork()
        {
            TransportNetwork network = new TransportNetwork();

            network.AddVehicle(new Car());
            network.AddVehicle(new Bus());
            network.AddVehicle(new Train());

            return network;
        }
        }
    }