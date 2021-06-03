using System;
namespace Roulette.Api.Exceptions
{
    public class TableNotFound : Exception
    {
        public TableNotFound(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}

