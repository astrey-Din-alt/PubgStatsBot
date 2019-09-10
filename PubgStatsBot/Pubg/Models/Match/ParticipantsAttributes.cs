namespace PubgStatsBot.Pubg.Models.Match
{
    public class ParticipantsAttributes : Attribute
    {
        public new PartisipantsStats Stats { get; set; }
        public string Actor { get; set; }
    }
}