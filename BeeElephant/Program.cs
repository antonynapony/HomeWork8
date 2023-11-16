namespace BeeElephant
{
    class Program
    {
        static void Main(string[] args)
        {
            BeeElephant beeElephant = new BeeElephant(45, 20);
            beeElephant.Print();
            beeElephant.Fly();
            beeElephant.Trumpet();
            Console.WriteLine("Введите вид пищи: ");
            string meal = Console.ReadLine();
            Console.WriteLine("Введите количество: ");
            int value = int.Parse(Console.ReadLine());
            beeElephant.Eat(meal, value);
        }
    }
}

