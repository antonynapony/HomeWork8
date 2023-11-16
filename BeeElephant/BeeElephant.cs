namespace BeeElephant
{
    internal class BeeElephant
    {
        private int bee;
        public int Bee
        {
            get { return bee; }
            set
            {
                if (value > 100)
                {
                    bee = 100;
                }
                else if (value < 0)
                {
                    bee = 0;
                }
                else
                {
                    bee = value;
                }
            }
        }
        private int elephant;
        public int Elephant
        {
            get { return elephant; }
            set
            {
                if (value > 100)
                {
                    elephant = 100;
                }
                else if (value < 0)
                {
                    elephant = 0;
                }
                else
                {
                    elephant = value;
                }
            }
        }

        public BeeElephant() { }

        public BeeElephant(int bee, int elephant)
        {
            Bee = bee;
            Elephant = elephant;
        }

        public void Print()
        {
            Console.WriteLine($"Обнаружен ПчелоСлон! {bee}: {elephant}");
        }

        public void Fly()
        {
            bool isFly = (bee >= elephant);
            Console.WriteLine(isFly);
        }

        public void Trumpet()
        {
            if (elephant >= bee)
            {
                Console.WriteLine("tu-tu-doo-doo");
            }
            else
            {
                Console.WriteLine("wzzzz");
            }
        }

        public void Eat(string meal, int value)
        {
            if (!string.IsNullOrWhiteSpace(meal))
            {
                if (meal == "nectar")
                {
                    bee += value;
                    elephant -= value;
                    if (elephant < 0)
                    {
                        elephant = 0;
                        if (bee > 100)
                        {
                            bee = 100;
                        }
                    }
                }
                else if (meal == "grass")
                {
                        elephant += value;
                        bee -= value;
                    if (bee < 0)
                    {
                        bee = 0;
                        if (elephant > 100)
                        {
                            elephant = 100;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
            Console.WriteLine($"ПчелоСлон {bee}:{elephant}");
        }
    }
}
