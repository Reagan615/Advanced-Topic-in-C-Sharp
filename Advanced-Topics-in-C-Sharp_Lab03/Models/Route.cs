namespace Advanced_Topics_in_C_Sharp_Lab03.Models
{
    public class Route
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public Route(int number, string name, Direction direction, bool rampAccessible, bool bicycleAccessible)
        {
            Number = number;
            Name = name;
            Direction = direction;
            RampAccessible = rampAccessible;
            BicycleAccessible = bicycleAccessible;

        }
    }
}
