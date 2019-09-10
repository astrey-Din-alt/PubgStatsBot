namespace PubgStatsBot.Pubg.Models.User
{
    public class UserData : Data
    {
        public UserAttributes Attributes { get; set; }
        public UserRelationships Relationships { get; set; }
        public UserLinks Links { get; set; }
    }
}