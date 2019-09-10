using System.Collections.Generic;

namespace PubgStatsBot.Pubg.Models.User
{
    public class UserMatches : ILink
    {
        public IEnumerable<UserMatchesData> Data { get; set; }
        public object Meta { get; set; }
        public string Self { get; set; }
    }
}