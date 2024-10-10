using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IColleague
    {
        void SetMediator(IMediator mediator);
        void ReceiveMessage(string message);
    }

    public class ColleagueA : IColleague
    {
        private IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Colleague A received message: {message}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Colleague A is sending message...");
            _mediator.Notify(this, message);
        }
    }

    public class ColleagueB : IColleague
    {
        private IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Colleague B received message: {message}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Colleague B is sending message...");
            _mediator.Notify(this, message);
        }
    }

    public class ColleagueMediator : IMediator
    {
        public void Notify(object sender, string message)
        {
            if (sender is ColleagueA)
            {
                Console.WriteLine("Mediator received message from Colleague A, forwarding to Colleague B.");
            }
            else if (sender is ColleagueB)
            {
                Console.WriteLine("Mediator received message from Colleague B, forwarding to Colleague A.");
            }
        }
    }

}
