using System;

namespace PubgStatsBot.Pubg.Models.User
{
    public class UserAttributes
    {
        public string TitleId { get; set; }
        public string ShardId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Stats { get; set; }
    }
}