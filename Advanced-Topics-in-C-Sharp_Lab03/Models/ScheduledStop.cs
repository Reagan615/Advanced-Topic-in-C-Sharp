namespace Advanced_Topics_in_C_Sharp_Lab03.Models
{
    public class ScheduledStop
    {
        public int Id { get; set; }
        public Stop Stop { get; set; }
        public Route Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
        public ScheduledStop(int id, Stop stop, Route route, DateTime scheduledArrival)
        {
            Id = id;
            Stop = stop;
            Route = route;
            ScheduledArrival = scheduledArrival;
        }
    }
}
