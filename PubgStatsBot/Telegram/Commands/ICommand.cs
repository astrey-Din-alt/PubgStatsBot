﻿using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace PubgStatsBot.Telegram.Commands
{
    public interface ICommand
    {
        string Name { get; }

        Task Execute(Message message, TelegramBotClient client);

        bool Contains(Message message);
    }
}