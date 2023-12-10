namespace Warehouse
{
    class Program
    {

        static void Main(string[] args)
        {
            var stock = new Stock();
            Good firstGood = new Good { Name = "Coca-Cola", Shop = "Green", Price = 3.75m };
            stock.AddGood(firstGood);
            Good secondGood = new Good { Name = "Sprite", Shop = "Алми", Price = 3.75m };
            stock.AddGood(secondGood);
            Good thirdGood = new Good { Name = "Fanta", Shop = "ProStore", Price = 3.75m };
            stock.AddGood(thirdGood);
            Good fourthGood = new Good { Name = "7Up", Shop = "Соседи", Price = 4.25m };
            stock.AddGood(fourthGood);

            stock.RemoveGood(secondGood);

            Console.WriteLine(stock.GetGoodByName("7Up"));
        }
    }
}