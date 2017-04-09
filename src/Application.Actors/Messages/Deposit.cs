namespace Application.Actors.Messages
{
    public class Deposit : Message
    {
        public Deposit(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; }
    }
}