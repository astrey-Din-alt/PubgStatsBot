using Microsoft.AspNetCore.Mvc;
using PubgStatsBot.Pubg.Models.Match;
using PubgStatsBot.Pubg.Services;
using System.Threading.Tasks;

namespace PubgStatsBot.Controllers.Pubg
{
    [Route("api/pubg/[controller]")]
    [ApiController]
    public class MatchStatsController : ControllerBase
    {
        private readonly IMatchService _matchService;

        public MatchStatsController(IMatchService matchService)
        {
            _matchService = matchService;
        }
                
        [HttpGet("{id}", Name = "GetMatchStats")]
        public async Task<Match> GetAsync(string id)
        {
            return await _matchService.GetMatchStatsAsync(id);
        }
    }
}