namespace Warehouse
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Good> stock = new List<Good>();
            while (true)
            {
                Console.Write("1. Добавить товар\n" +
                              "2. Удалить товар\n" +
                              "3. Найти товар по имени\n" +
                              "4. Найти товар по индексу\n" +
                              "5. Завершить операции с товарами\n");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода!");

                    continue;
                }
                switch (choice)
                {
                    case 1:
                        int index;
                        Console.Write("Введите индекс товара: ");
                        if (!int.TryParse(Console.ReadLine(), out index))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        Console.Write("Введите название товара: ");
                        var name = Console.ReadLine();
                        Console.Write("Введите название магазина: ");
                        var shop = Console.ReadLine();
                        Console.Write("Введите стоимость товара: ");
                        double price;
                        if (!double.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        Good good = new Good(index, name, shop, price);
                        stock.Add(good);

                        continue;
                    case 2:
                        Console.WriteLine("Введите имя товара, который хотите удалить: ");
                        var goodsName = Console.ReadLine();
                        stock.Remove(stock.Single(s => s.Name == goodsName));

                        continue;
                    case 3:
                        Console.WriteLine("Введите имя товара, который хотите найти: ");
                        var findName = Console.ReadLine();
                        foreach (Good findGood in stock)
                        {
                            if (findGood.Name.Equals(findName))
                            {
                                Console.WriteLine($"Индекс: {findGood.Index}");
                                Console.WriteLine($"Наименование: {findGood.Name}");
                                Console.WriteLine($"Магазин: {findGood.Shop}");
                                Console.WriteLine($"Стоимость: {findGood.Price}");
                            }
                        }

                        continue;
                    case 4:
                        int findIndex;
                        Console.Write("Введите индекс товара: ");
                        if (!int.TryParse(Console.ReadLine(), out findIndex))
                        {
                            Console.WriteLine("Ошибка ввода!");

                            continue;
                        }
                        foreach (Good findGood in stock)
                        {
                            if (findGood.Index.Equals(findIndex))
                            {
                                Console.WriteLine($"Индекс: {findGood.Index}");
                                Console.WriteLine($"Наименование: {findGood.Name}");
                                Console.WriteLine($"Магазин: {findGood.Shop}");
                                Console.WriteLine($"Стоимость: {findGood.Price}");
                            }
                        }

                        continue;
                    case 5:

                        break;
                }
                break;
            }
        }
    }
}