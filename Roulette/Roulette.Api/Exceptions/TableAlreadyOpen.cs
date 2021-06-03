using System;
namespace Roulette.Api.Exceptions
{
    public class TableAlreadyOpen : Exception
    {
        public TableAlreadyOpen(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}

