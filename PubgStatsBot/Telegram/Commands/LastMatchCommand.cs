using PubgStatsBot.Pubg.Services;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TGTypes = Telegram.Bot.Types;

namespace PubgStatsBot.Telegram.Commands
{
    public class LastMatchCommand : ICommand
    {
        private IMatchService _matchService;

        public LastMatchCommand(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public string Name => @"/lastmatch";

        public bool Contains(Message message)
        {
            if (message.Type != TGTypes.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var userName = message.Text.Split(' ')[1];
            var partisipantsStats = await _matchService.GetLastMatchStatsByUser(userName);
            await client.SendTextMessageAsync(chatId, partisipantsStats.GetStatsString(), parseMode: TGTypes.Enums.ParseMode.Default);
        }
    }
}