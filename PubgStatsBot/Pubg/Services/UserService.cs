using Microsoft.Extensions.Configuration;
using PubgStatsBot.Pubg.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PubgStatsBot.Pubg.Services
{
    public class UserService : IUserService
    {
        private IConfiguration _configuration;

        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<User> GetUserMatchesAsync(string name)
        {
            string path = _configuration["Pubg:ApiRoot"] + $"players?filter[playerNames]={name}";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(path);
                client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue("Bearer", _configuration["Pubg:ApiToken"]);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                User user = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    user = await response.Content.ReadAsAsync<User>();
                }
                return user;
            }
        }
    }
}
