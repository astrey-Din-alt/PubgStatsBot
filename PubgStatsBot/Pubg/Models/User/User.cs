using System.Collections.Generic;

namespace PubgStatsBot.Pubg.Models.User
{
    public class User : ILink
    {
        public IEnumerable<UserData> Data { get; set; }
        public object Meta { get; set; }
        public string Self { get; set; }
    }
}