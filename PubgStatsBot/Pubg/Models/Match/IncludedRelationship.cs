using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PubgStatsBot.Pubg.Models.Match
{
    public class IncludedRelationship
    {
        public Participants Participants { get; set; }
        public Team Team { get; set; }
    }

    public class Participants
    {
        public IEnumerable<Data> Data { get; set; }
    }

    public class Team
    {
        public Data Data { get; set; }
    }
}
