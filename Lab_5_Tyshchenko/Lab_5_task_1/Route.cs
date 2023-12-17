namespace Lab_5_task_1
{
    public class Route
    {
        public string PointStartFrom { get; set; }
        public string PointEnd { get; set; }

        public Route(string pointStart, string pointEnd)
        {
            PointStartFrom = pointStart;
            PointEnd = pointEnd;
        }
    }
}