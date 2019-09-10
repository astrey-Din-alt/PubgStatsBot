namespace PubgStatsBot.Pubg.Models.User
{
    public class UserMatchesData : Data
    {
        public UserMatchesAttributes Attributes { get; set; }
        public UserMatchesRelationships Relationships { get; set; }
        public UserMatchesLinks Links { get; set; }
    }
}