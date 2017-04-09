namespace Application.Actors
{
    using System;
    using BaseActor;
    using Messages;

    public class OutputActor : Actor
    {
        public void Handle(Balance message)
        {
            Console.WriteLine($"Balance is {message.Amount}");
        }
    }
}