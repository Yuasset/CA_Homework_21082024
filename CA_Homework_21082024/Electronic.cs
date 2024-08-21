namespace CA_Homework_21082024
{
    internal class Electronic : Product
    {
        public string Brand { get; set; }
        public string Modal { get; set; }

        public override decimal Discount()
        {
            return Price - (Price * 0.10m);
        }
    }
}
