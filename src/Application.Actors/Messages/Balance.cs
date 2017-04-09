namespace Application.Actors.Messages
{
    public class Balance : Message
    {
        public Balance(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; }
    }
}