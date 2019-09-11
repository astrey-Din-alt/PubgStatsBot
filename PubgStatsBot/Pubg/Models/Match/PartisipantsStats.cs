using System.Text;

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

        public string GetStatsString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Игрок: {0}", this.name));
            builder.AppendLine();
            builder.AppendLine(string.Format("Место: {0}", this.winPlace));
            builder.AppendLine(string.Format("Урон: {0}", this.damageDealt));
            builder.AppendLine(string.Format("Килл: {0}", this.kills));
            builder.AppendLine(string.Format("Хедшот килл: {0}", this.headshotKills));
            builder.AppendLine(string.Format("Подрубить: {0}", this.killStreaks));
            builder.AppendLine(string.Format("Пройденная дистанция: {0} m", this.walkDistance));
            builder.AppendLine(string.Format("Поддержка: {0}", this.assists));
            builder.AppendLine(string.Format("Хилы / Бусты: {0}/{1}", this.heals, this.boosts));
            builder.AppendLine(string.Format("Количество оживлений: {0}", this.revives));
            builder.AppendLine(string.Format("Причина смерти: {0}", this.deathType));
            return builder.ToString();
        }
    }
}