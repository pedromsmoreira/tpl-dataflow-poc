namespace Application.Actors
{
    using Application.Actors.BaseActor;
    using Messages;

    public class AccountActor : Actor
    {
        private decimal balance;

        public void Handle(Deposit message)
        {
            this.balance += message.Amount;
        }

        public void Handle(QueryBalance message)
        {
            message.Receiver.Send(new Balance(this.balance));
        }
    }
}