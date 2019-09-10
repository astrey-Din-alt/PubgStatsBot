using PubgStatsBot.Pubg.Services;
using System.Text;
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
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Игрок: {0}", partisipantsStats.name));
            builder.AppendLine("_________________");
            builder.AppendLine(string.Format("Место: {0}", partisipantsStats.winPlace));
            builder.AppendLine(string.Format("Урон: {0}", partisipantsStats.damageDealt));
            builder.AppendLine(string.Format("Килл: {0}", partisipantsStats.kills));
            builder.AppendLine(string.Format("Хедшот килл: {0}", partisipantsStats.headshotKills));
            builder.AppendLine(string.Format("Подрубить: {0}", partisipantsStats.killStreaks));
            builder.AppendLine(string.Format("Пройденная дистанция: {0} km", partisipantsStats.walkDistance));
            builder.AppendLine(string.Format("Поддержка: {0}", partisipantsStats.assists));
            builder.AppendLine(string.Format("Хилы / Бусты: {0}/{1}", partisipantsStats.heals, partisipantsStats.boosts));
            builder.AppendLine(string.Format("Количество оживлений: {0}", partisipantsStats.revives));
            builder.AppendLine(string.Format("Причина смерти: {0}", partisipantsStats.deathType));
            await client.SendTextMessageAsync(chatId, builder.ToString(), parseMode: TGTypes.Enums.ParseMode.Markdown);
        }
    }
}