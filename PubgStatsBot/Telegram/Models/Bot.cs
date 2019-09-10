using PubgStatsBot.Telegram.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace PubgStatsBot.Telegram.Models
{
    public class Bot
    {
        private static TelegramBotClient botClient;
        private static IEnumerable<ICommand> commandsList;

        public Bot()
        {
            commandsList = new List<ICommand>();
        }

        public static IReadOnlyList<ICommand> Commands => commandsList.ToList().AsReadOnly();

        public static void RegisterCommands(IEnumerable<ICommand> commands) => commandsList = commands;

        public static async Task<TelegramBotClient> GetBotClientAsync()
        {
            if (botClient != null)
            {
                return botClient;
            }

            botClient = new TelegramBotClient(AppSettings.BotKey);
            var hook = $"{AppSettings.HostUrl}api/telegram/Message/update";
            await botClient.SetWebhookAsync(hook);
            return botClient;
        }
    }
}