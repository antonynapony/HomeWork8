namespace Warehouse
{
    public class Stock
    {

        private readonly List<Good> goods;

        public Stock()
        {
            goods = new List<Good>();
        }

        public void AddGood(Good newGood)
        {
            if (newGood is null)
            {
                throw new ArgumentNullException(nameof(newGood));
            }
            else
            {
                goods.Add(newGood);
            }
        }

        public void RemoveGood(Good good)
        {
            if (good is null)
            {
                throw new ArgumentNullException(nameof(good));
            }
            else
            {
                goods.Remove(good);
            }
        }

        public string GetGoodByIndex(int index)
        {
            if (index < 0 && index >= goods.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }    

            return goods[index].ToString();
        }

        public string? GetGoodByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            name = name.Trim();
            foreach (var good in goods)
            {
                if (good.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return good.ToString();
                }    
            }

            return null;
        }
    }
}
