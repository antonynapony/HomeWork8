namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            Dictionary<int, string> seats = new Dictionary<int, string>();
            List<string> passengers = new List<string>();
            Console.WriteLine("Введите текущую скорость движения: ");
            int MaxNumber = 20;
            int MaxSpeed = 90;
            int currentSpeed;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out currentSpeed))
                {
                    Console.WriteLine("Ошибка ввода!");

                    continue;
                }
                else
                {
                    bus.CurrentSpeed = currentSpeed;
                    if (currentSpeed < 0)
                    {
                        currentSpeed = 0;
                    }
                    else if (currentSpeed > MaxSpeed)
                    {
                        currentSpeed = MaxSpeed;
                    }
                    Console.WriteLine($"Текущая скорость: {currentSpeed}");

                    break;
                }
            }
            while (true)
            {
                Console.Write("1. Взять пассажира\n" + "2. Высадить пассажира\n" +
                    "3. Снизить скорость\n" + "4. Увеличить скорость\n" + "5. Автобус двигается в парк\n");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода!");

                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите фамилию пассажира: ");
                        var lastNameEntering = Console.ReadLine();
                        passengers.Add(lastNameEntering);
                        Console.Write("Введите номер места: ");
                        if (!int.TryParse(Console.ReadLine(), out int seatReserved))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        else if (seats.ContainsKey(seatReserved))
                        {
                            Console.WriteLine("Это место уже занято!");

                            continue;
                        }
                        else
                        {
                            seats.Add(seatReserved, lastNameEntering);
                        }

                        continue;
                    case 2:
                        Console.Write("Введите фамилию пассажира: ");
                        var lastNameQuitting = Console.ReadLine();
                        passengers.Remove(lastNameQuitting);
                        Console.WriteLine("Введите номер места");
                        if (!int.TryParse(Console.ReadLine(), out int seatReleased))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        seats.Remove(seatReleased, out lastNameQuitting);

                        continue;

                    case 3:
                        int speedDown;
                        Console.WriteLine("Насколько вы хотите снизить скорость?");
                        if (!int.TryParse(Console.ReadLine(), out speedDown))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        bus.SpeedDown(speedDown);

                        continue;

                    case 4:
                        int speedUp;
                        Console.WriteLine("Насколько вы хотите увеличить скорость?");
                        if (!int.TryParse(Console.ReadLine(), out speedUp))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        bus.SpeedUp(speedUp);

                        continue;
                    case 5:

                        break;
                }
                foreach (var passenger in seats)
                {
                    Console.WriteLine($"Пассажир {passenger.Value} занимает место {passenger.Key}");
                }
                break;
            }
        }
    }
}