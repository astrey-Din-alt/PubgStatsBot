using Microsoft.Extensions.Configuration;
using PubgStatsBot.Pubg.Models.Match;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PubgStatsBot.Pubg.Services
{
    public class MatchService : IMatchService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public MatchService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MatchService(IConfiguration configuration, IUserService userService) : this(configuration)
        {
            _userService = userService;
        }

        public async Task<Match> GetMatchStatsAsync(string id)
        {
            string path = $"{_configuration["Pubg:ApiRoot"]}matches/{id}";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(path);
                client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue("Bearer", _configuration["Pubg:ApiToken"]);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                Match match = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    match = await response.Content.ReadAsAsync<Match>();
                }
                return match;
            }
        }

        public async Task<PartisipantsStats> GetLastMatchStatsByUser(string user)
        {
            var data = await _userService.GetUserMatchesAsync(user);
            var lastMatchId = data.Data.FirstOrDefault().Relationships.Matches.Data.FirstOrDefault().Id;
            var matchStats = await GetMatchStatsAsync(lastMatchId);
            var userStats = matchStats.Included
                .Where(x => x.Type == "participant")
                .Select(x => x.Attributes.Stats)
                .FirstOrDefault(x => x.name == user);
            return userStats;
        }
    }
}