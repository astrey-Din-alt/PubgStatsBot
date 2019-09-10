using PubgStatsBot.Pubg.Models.Match;
using System.Threading.Tasks;

namespace PubgStatsBot.Pubg.Services
{
    public interface IMatchService
    {
        Task<Match> GetMatchStatsAsync(string id);

        Task<PartisipantsStats> GetLastMatchStatsByUser(string user);
    }
}