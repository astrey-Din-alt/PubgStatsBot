using Microsoft.AspNetCore.Mvc;
using PubgStatsBot.Telegram.Models;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace PubgStatsBot.Controllers.Telegram
{
    [Route("api/telegram/[controller]")]
    [ApiController]
    public class MessageController
    {
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]Update update)
        {
            if (update == null)
                return new OkResult();

            var commands = Bot.Commands;
            var message = update.Message;
            var botClient = await Bot.GetBotClientAsync();

            foreach (var command in commands)
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, botClient);
                    break;
                }
            }
            return new OkResult();
        }
    }
}