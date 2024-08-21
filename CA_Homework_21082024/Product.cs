namespace CA_Homework_21082024
{
    internal class Product
    {
        public string Name { get; set; }
        private decimal _price;
        public decimal Price { get; set; }
        virtual public decimal Discount()
        {
            return 0.0m;
        }
        public decimal PriceKDV
        {
            get
            {
                return Price * 1.20m;
            }
        }

    }
}
