namespace PubgStatsBot.Pubg.Models.Match
{
    public class PartisipantsStats : IStats
    {
        public int DBNOs { get; set; }
        public int assists { get; set; }
        public int boosts { get; set; }
        public float damageDealt { get; set; }
        public string deathType { get; set; }
        public int headshotKills { get; set; }
        public int heals { get; set; }
        public int killPlace { get; set; }
        public int killStreaks { get; set; }
        public int kills { get; set; }
        public float longestKill { get; set; }
        public string name { get; set; }
        public string playerId { get; set; }
        public int revives { get; set; }
        public float rideDistance { get; set; }
        public int roadKills { get; set; }
        public float swimDistance { get; set; }
        public int teamKills { get; set; }
        public float timeSurvived { get; set; }
        public int vehicleDestroys { get; set; }
        public float walkDistance { get; set; }
        public int weaponsAcquired { get; set; }
        public int winPlace { get; set; }
    }
}