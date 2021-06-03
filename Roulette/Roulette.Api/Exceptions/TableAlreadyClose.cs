using System;
namespace Roulette.Api.Exceptions
{
    public class TableAlreadyClose : Exception
    {
        public TableAlreadyClose(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}

