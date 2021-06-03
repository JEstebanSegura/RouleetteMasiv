using System;
namespace Roulette.Api.Exceptions
{
    public class InvalidBet : Exception
    {
        public InvalidBet(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}

