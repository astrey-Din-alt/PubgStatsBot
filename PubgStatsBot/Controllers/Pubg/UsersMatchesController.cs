using Microsoft.AspNetCore.Mvc;
using PubgStatsBot.Pubg.Models.User;
using PubgStatsBot.Pubg.Services;
using System.Threading.Tasks;

namespace PubgStatsBot.Controllers
{
    [Route("api/pubg/[controller]")]
    [ApiController]
    public class UsersMatchesController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersMatchesController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{name}", Name = "GetUserMatches")]
        public async Task<User> GetAsync(string name)
        {
            return await _userService.GetUserMatchesAsync(name);
        }
    }
}