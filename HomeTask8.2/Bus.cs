namespace Bus
{
    public class Bus
    {
        public const int MaxSpeed = 90;
        public const int NumberOfSeats = 20;

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int currentSpeed;
        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }
        private Dictionary<int, string> seats;
        public Dictionary<int, string> Seats
        { get { return seats; } }

        private List<string> passengers;
        public Bus()
        {
            passengers = new List<string>();
            seats = new Dictionary<int, string>();
        }

        public void AddPassenger(string passenger)
        {
            if (passengers.Count < 20)
            {
                passengers.Add(passenger);
            }
            else
            {
                Console.WriteLine("Свободных мест нет!");
            }
        }

        public void RemovePassenger(string passenger)
        {
            if (passengers.Count > 1)
            {
                passengers.Remove(passenger);
            }
            else
            {
                Console.WriteLine("В автобусе нет пассажиров!");
            }
        }

        public void SpeedDown(int speed)
        {
            currentSpeed -= speed;
            if (currentSpeed < 0)
            {
                currentSpeed = 0;
                Console.WriteLine("Вы остановились");
            }
            else
            {
                Console.WriteLine($"Текущая скорость: {currentSpeed}");
            }
        }

        public void SpeedUp(int speed)
        {
            {
                currentSpeed += speed;
                if (currentSpeed > MaxSpeed)
                {
                    currentSpeed = MaxSpeed;
                    Console.WriteLine($"Вы движетесь с максимальной скоростью: {currentSpeed}");
                }
                else
                {
                    Console.WriteLine($"Текущая скорость: {currentSpeed}");
                }
            }
        }
    }
}
