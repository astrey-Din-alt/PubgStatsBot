using System.Threading.Tasks;
using TGBot = Telegram.Bot;
using TGTypes = Telegram.Bot.Types;

namespace PubgStatsBot.Telegram.Commands
{
    public class StartCommand : ICommand
    {
        public string Name => @"/start";

        public bool Contains(TGTypes.Message message)
        {
            if (message.Type != TGTypes.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public async Task Execute(TGTypes.Message message, TGBot.TelegramBotClient botClient)
        {
            var chatId = message.Chat.Id;
            await botClient.SendTextMessageAsync(chatId, "Hallo I'm Pubg Stats Bot", parseMode: TGTypes.Enums.ParseMode.Markdown);
        }
    }
}