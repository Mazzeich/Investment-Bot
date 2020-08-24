using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace investment_bot
{
    public class Bot
    {
        private static TelegramBotClient _botClient;
        private static string token;
        private static string msg;
        private static string message = "";
        
        public Bot(string botToken, string fileInfo)
        {
            token = botToken;
            msg = fileInfo;
            _botClient = new TelegramBotClient(token);

            var myChat = _botClient.GetMeAsync().Result;
            
            Console.WriteLine($"My ID: {myChat.Id}\nMy name: {myChat.FirstName}\ninfo");

            _botClient.OnMessage += Bot_OnMessage;
            _botClient.StartReceiving();
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var text = e?.Message?.Text;
            if (text == null)
            {
                return;
            }
            Console.WriteLine($"[Message]: '{text}' from chatID: {e.Message.Chat.Id}");

            await _botClient.SendTextMessageAsync
            (
                chatId: e.Message.Chat.Id,
                text: msg
            ).ConfigureAwait(false);
        }
    }
}