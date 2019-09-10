using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PubgStatsBot.Pubg.Models.Match
{
    public class MatchData : Data
    {        
        public MatchAttributes Attributes { get; set; }
        public MatchRelationships Relationships { get; set; }
        public MatchLinks Links { get; set; }
    }
}
