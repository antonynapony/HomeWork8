namespace Warehouse
{
    public class Stock
    {

        private List<Good> stock;

        public Stock()
        {
            stock = new List<Good>();
        }

        public void AddGood(Good good)
        {
            stock.Add(good);
        }

        public void RemoveGood(Good good)
        {
            stock.Remove(good);
        }
    }
}
