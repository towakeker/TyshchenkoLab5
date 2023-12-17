namespace Lab_5_task_1
{
    public abstract class Vehicle
    {
        public double VehicleSpeed { get; set; }
        public int VehicleCapacity { get; set; }

        public abstract void Do_move();
    }
}