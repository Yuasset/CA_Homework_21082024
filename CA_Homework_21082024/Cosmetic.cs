namespace CA_Homework_21082024
{
    internal class Cosmetic : Product
    {
        public string Type { get; set; }

        public override decimal Discount()
        {
            return Price - (Price * 0.05m);
        }
    }
}
