using System;
using System.Collections.Generic;

namespace Roulette.Api.Entities
{
    public class Table
    {
        public string Id { get; set; }
        public bool Status { get; set; }
        public DateTime OpenedAt { get; set; }
        public DateTime ClosedAt { get; set; }
        public int WinnerBox { get; set; } = -1;
        public string WinnerColor { get; set; }
        public List<Bet> Bets { get; set; } = new List<Bet>();
        public List<Result> Results { get; set; } = new List<Result>();

    }
}
