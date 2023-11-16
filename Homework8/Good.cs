namespace Warehouse
{

    public class Good
    {
        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string shop;
        public string Shop
        {
            get { return shop; }
            set { shop = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Good() { }

        public Good(int index, string name, string shop, double price)
        {
            Index = index;
            Name = name;
            Shop = shop;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Индекс: {index}");
            Console.WriteLine($"Наименование: {name}");
            Console.WriteLine($"Магазин: {shop}");
            Console.WriteLine($"Стоимость: {price}");
        }
    }
}
