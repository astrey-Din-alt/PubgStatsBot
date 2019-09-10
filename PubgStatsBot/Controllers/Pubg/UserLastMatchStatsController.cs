using Microsoft.AspNetCore.Mvc;
using PubgStatsBot.Pubg.Models.Match;
using PubgStatsBot.Pubg.Services;
using System.Threading.Tasks;

namespace PubgStatsBot.Controllers.Pubg
{
    [Route("api/pubg/[controller]")]
    [ApiController]
    public class UserLastMatchStatsController : ControllerBase
    {
        private readonly IMatchService _matchService;

        public UserLastMatchStatsController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpGet("{name}", Name = "GetLastMatchStatsByUser")]
        public async Task<PartisipantsStats> GetLastMatchStatsByUserAsync(string name)
        {
            return await _matchService.GetLastMatchStatsByUser(name);
        }
    }
}