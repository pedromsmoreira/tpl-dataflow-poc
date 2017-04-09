using Application.Actors;

namespace TplDataflowPoc
{
    using System;
    using Application.Actors.Messages;

    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new AccountActor();
            var output = new OutputActor();

            account.Send(new Deposit(50));
            account.Send(new QueryBalance(output));

            account.Completion.Wait();
            output.Completion.Wait();

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}