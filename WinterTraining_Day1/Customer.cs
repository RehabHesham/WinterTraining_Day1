namespace WinterTraining_Day1
{
    // inheritance
    internal class Customer : Person
    {
        public Customer() : base("Omar")
        {
                
        }
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                cardNumber = value;
            }
        }
        public override string GetData()
        {
            return $"name = {Name}, cardNumber = {cardNumber}";
        }
    }
}
