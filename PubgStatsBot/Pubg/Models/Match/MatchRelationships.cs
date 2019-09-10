using System.Collections.Generic;

namespace PubgStatsBot.Pubg.Models.Match
{
    public class MatchRelationships
    {
        public MatchRelationshipsRosters Rosters { get; set; }
        public MatchRelationshipsAssets Assets { get; set; }
    }

    public class MatchRelationshipsRosters
    {
        public IEnumerable<Data> Data { get; set; }
    }

    public class MatchRelationshipsAssets
    {
        public IEnumerable<Data> Data { get; set; }
    }
}