using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_5_task_1
{
    public class TransportNetwork
    {
        private List<Vehicle> Vehicles { get; } = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle) => Vehicles.Add(vehicle);

        public void MoveAllVehicles() => Vehicles.ForEach(vehicle => vehicle.Do_move());

        public void CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            Console.WriteLine($"Calculating the optimal route from {route.PointStartFrom} to {route.PointEnd} for {GetVehicleTypeName(vehicle)}.");
        }

        public void PassengerOperation(Vehicle vehicle, int passengers, string operation)
        {
            Console.WriteLine($"{operation} {passengers} passengers on the {GetVehicleTypeName(vehicle)}.");
        }

        private string GetVehicleTypeName(Vehicle vehicle) => vehicle.GetType().Name;

        public void PassengerOperation()
        {
        }
        
    }
}