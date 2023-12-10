namespace Warehouse
{

    public class Good
    {
        private string _name;
        private string _shop;
        private decimal _price;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("", nameof(value));
                }
            }
        }
        public string Shop
        {
            get { return _shop; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _shop = value;
                }
                else
                {
                    throw new ArgumentException("", nameof(value));
                }
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("", nameof(value));
                }
            }
        }

        public override string ToString()
        {
            return $"Good: {Name}, {Shop}, {Price:F2}";
        }
    }
}
