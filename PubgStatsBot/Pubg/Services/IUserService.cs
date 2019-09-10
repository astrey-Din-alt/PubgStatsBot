using PubgStatsBot.Pubg.Models.User;
using System.Threading.Tasks;

namespace PubgStatsBot.Pubg.Services
{
    public interface IUserService
    {
        Task<User> GetUserMatchesAsync(string name);
    }
}