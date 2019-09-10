namespace PubgStatsBot.Pubg.Models.Match
{
    public abstract class Attribute
    {
        public IStats Stats { get; set; }
        public string ShareId { get; set; }
    }
}