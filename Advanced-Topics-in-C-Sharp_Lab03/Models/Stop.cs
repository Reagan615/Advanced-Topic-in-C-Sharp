namespace Advanced_Topics_in_C_Sharp_Lab03.Models
{
    public class Stop
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public Stop(int number, string street, string name, Direction direction)
        {
            Number = number;
            Street = street;
            Name = name;
            Direction = direction;

        }
    }
}
