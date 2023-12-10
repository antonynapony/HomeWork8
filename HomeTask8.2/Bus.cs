namespace Bus
{
    public class Bus
    {
        private double _maxSpeed;
        private int _maxCountOfSeats;
        private double _speed;
        public double Speed
        {
            get { return _speed; }
            set
            {
                _speed = Math.Min(Math.Max(value, 0), _maxSpeed);
            }
        }
        public double MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }

        public int MaxCountOfSeats
        {
            get { return _maxCountOfSeats; }
            set
            {
                if (value > 0)
                {
                    _maxCountOfSeats = value;
                }
                else
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }
        public bool HasEmptySeats { get; set; }
        public List<string> Passangers { get; set; }
        public Dictionary<int, string> Seats { get; set; }

        public Bus(int maxSpeed, int maxCountOfSeats)
        {
            MaxSpeed = maxSpeed;
            MaxCountOfSeats = maxCountOfSeats;
            Speed = 0;
            HasEmptySeats = true;
            Passangers = new List<string>();
            Seats = new Dictionary<int, string>();
        }

        public void IncreaseSpead(int difference)
        {
            Speed += difference;
        }

        public void DecreaseSpead(int difference)
        {
            Speed -= difference;
        }

        public bool AddPassangers(List<string> passangers)
        {
            if (passangers is null)
            {
                throw new ArgumentNullException(nameof(passangers));
            }

            var isSuccessful = true;
            foreach (var passenger in passangers)
            {
                isSuccessful = AddPassanger(passenger);
                if (!isSuccessful)
                {
                    return false;
                }
            }

            return true;
        }

        public bool AddPassanger(string passanger)
        {
            if (string.IsNullOrEmpty(passanger))
            {
                throw new ArgumentException("", nameof(passanger));
            }

            if (HasEmptySeats)
            {
                Passangers.Add(passanger);
                HasEmptySeats = Passangers.Count < MaxCountOfSeats;
                for (int i = 0; i < MaxCountOfSeats; i++)
                {
                    if (!Seats.ContainsKey(i))
                    {
                        Seats.Add(i, passanger);
                        return true;
                    }
                }
            }
                return false;
        }

        public bool RemovePassanger(string passanger)
        {
            if (string.IsNullOrEmpty(passanger))
            {
                throw new ArgumentException("", nameof(passanger));
            }

            if (Passangers.Contains(passanger))
            {
                Seats.Remove(Passangers.IndexOf(passanger));
                Passangers.Remove(passanger);
                HasEmptySeats = Passangers.Count < MaxCountOfSeats;
                return true;
            }

            return false;
        }
    }
}
