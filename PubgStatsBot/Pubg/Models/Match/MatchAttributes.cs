using System;

namespace PubgStatsBot.Pubg.Models.Match
{
    public class MatchAttributes
    {
        public DateTime CreatedAt { get; set; }
        public int Duration { get; set; }
        public string TitleId { get; set; }
        public object Stats { get; set; }
        public string GameMod { get; set; }
        public string ShardId { get; set; }
        public object Tags { get; set; }
        public string MapName { get; set; }
        public bool IsCustomMatch { get; set; }
        public string SeasonState { get; set; }
    }
}