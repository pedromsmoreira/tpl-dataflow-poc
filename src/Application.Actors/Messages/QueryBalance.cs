namespace Application.Actors.Messages
{
    using BaseActor;

    public class QueryBalance : Message
    {
        public QueryBalance(Actor receiver)
        {
            this.Receiver = receiver;
        }

        public Actor Receiver { get; }
    }
}