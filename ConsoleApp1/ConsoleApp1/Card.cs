namespace BankingSystem
{
    public class Card
    {
        public string IdentificationNUmber { get; set; }
        public bool IsValid { get; set; }
        public int SecurityNumber { get; set; }
        private int PIN { get; set; }

        public bool isBlocked { get; set; }

    }
}