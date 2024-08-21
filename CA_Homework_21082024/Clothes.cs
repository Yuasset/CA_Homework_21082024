namespace CA_Homework_21082024
{
    internal class Clothes : Product
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public override decimal Discount()
        {
            DateTime dateTime = new DateTime();
            if (dateTime.Month == 10 && dateTime.Month == 11)
            {
                return Price - (Price * 0.10m);
            }
            else
            {
                return Price - (Price * 0.05m);
            }
        }
    }
}
