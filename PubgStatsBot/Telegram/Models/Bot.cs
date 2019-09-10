using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;

namespace PubgStatsBot.Telegram.Models
{
    public class Bot
    {
        private static IConfiguration _configuration;
        private static TelegramBotClient botClient;
        private static List<Command> commandsList;

        public Bot(IConfiguration configuration)
        {
            _configuration = configuration;
        }               

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> GetBotClientAsync()
        {
            if (botClient != null)
            {
                return botClient;
            }

            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
            //TODO: Add more commands
            botClient = new TelegramBotClient(AppSettings.BotKey);
            var hook = $"{AppSettings.HostUrl}api/telegram/Message/update";
            await botClient.SetWebhookAsync(hook);
            return botClient;
        }
    }
}