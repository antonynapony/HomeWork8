namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus(90, 50);
            bus.AddPassanger("Иванов");
            bus.AddPassanger("Смирнов");
            bus.AddPassanger("Сидоров");
            bus.AddPassanger("Павлов");
            bus.AddPassanger("Петров");

            foreach (var seat in bus.Seats)
            {
                Console.WriteLine($"{seat.Key}: {seat.Value}");
            }

            Console.WriteLine();

            bus.RemovePassanger("Павлов");
            bus.AddPassanger("Козлов");

            foreach (var seat in bus.Seats)
            {
                Console.WriteLine($"{seat.Key}: {seat.Value}");
            }

            bus.IncreaseSpead(100);
            Console.WriteLine(bus.Speed);
            bus.DecreaseSpead(60);
            Console.WriteLine(bus.Speed);
        }
    }
}
