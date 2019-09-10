using System.Collections.Generic;

namespace PubgStatsBot.Pubg.Models.Match
{
    public class Match : ILink
    {
        public MatchData Data { get; set; }
        public IEnumerable<IncludedPartisipants> Included { get; set; }
        public string Self { get; set; }
        public Meta Meta { get; set; }
    }

    public class Meta { }
}