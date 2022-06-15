using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Service_BasicChatBot
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        static TelegramBotClient _bot = new TelegramBotClient("");

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = new UpdateType[]
                {
                    UpdateType.Message,
                    UpdateType.EditedMessage,
                }
            };

            _bot.StartReceiving(UpdateHandler, ErrorHandler, receiverOptions);

        }

        private Task ErrorHandler(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

        private async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken arg3)
        {
            ConversaBasica(update.Message.Text.ToUpper(), update.Message.Chat.Id);
        }

        private void ConversaBasica(string v, long id)
        {
            throw new NotImplementedException();
        }
    }
}