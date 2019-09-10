using System.Collections.Generic;

namespace PubgStatsBot.Pubg.Models.User
{
    public class UserRelationships
    {
        public UserRelationshipAssets Assets { get; set; }
        public UserRelationshipMatches Matches { get; set; }
    }

    public class UserRelationshipAssets
    {
        public IEnumerable<object> Data { get; set; }
    }

    public class UserRelationshipMatches
    {
        public IEnumerable<Data> Data { get; set; }
    }
}