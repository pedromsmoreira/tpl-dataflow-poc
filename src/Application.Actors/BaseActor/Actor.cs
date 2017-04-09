namespace Application.Actors.BaseActor
{
    using System.Threading.Tasks;
    using System.Threading.Tasks.Dataflow;
    using Messages;

    public abstract class Actor
    {
        private readonly ActionBlock<Message> action;

        public Actor()
        {
            this.action = new ActionBlock<Message>(message =>
            {
                dynamic self = this;
                dynamic msg = message;
                self.Handle(msg);
            });
        }

        public Task Completion
        {
            get
            {
                this.action.Complete();
                return this.action.Completion;
            }
        }

        public void Send(Message message)
        {
            this.action.Post(message);
        }
    }
}