using System;
using System.IO;
using Telegram.Bot;

namespace investment_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenPath = "X:\\Coding\\C#\\Investment-Bot\\token.txt";
            string portfolioPath = "X:\\Coding\\C#\\Investment-Bot\\invest-info.txt";
            
            string portfolioInfo = File.ReadAllText(portfolioPath);
            Console.WriteLine(portfolioInfo);
            
            string token = File.ReadAllText(tokenPath);
            
            Bot bot = new Bot(token, portfolioInfo);


            
            Console.ReadKey();
        }
    }
}