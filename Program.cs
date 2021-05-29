//Example

using System;
using System.Threading;
using Telegram;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TelegramBot TBot = new TelegramBot("BOTID", "CHATID");
            switch (TBot.IsRunning())
            {
                case true:
                    Console.WriteLine("Bot is running!");
                    break;

                case false:
                    Console.WriteLine("Bot isn't running!");
                    break;
            }

            TBot.SendMessage("Bot is on!");
            Thread.Sleep(1000);

            while (true)
            {
                switch (TBot.GetRand(1, 3))
                {
                    case 1:
                        TBot.SendMessage("skid");
                        break;
                    case 2:
                        TBot.SendMessage("joshy is a fluffy femboy");
                        break;

                    case 3:
                        TBot.SendMessage("kyle is black");
                        break;
                }
                Thread.Sleep(10000);
            }
        }
    }
}
