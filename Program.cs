// Example

using System;
using System.Threading;
using Telegram;

namespace ConsoleApp
{
    class Program
    {
        public static int w_seconds = 10;
        public static string[] messages = { "@everyone skid", "kyle is black", "joshy is a fluffy femboy", "depressed/broken :/" };

        static void Main()
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

            TBot.SendMessage("Bot is online!");
            Thread.Sleep(2000);

            while (true)
            {
                switch (TelegramBot.GetRand(0, 3))
                {
                    case 0:
                        TBot.SendMessage(messages[0]);
                        Console.WriteLine("Sent message [" + messages[0] + "]");
                        break;

                    case 1:
                        TBot.SendMessage(messages[1]);
                        Console.WriteLine("Sent message [" + messages[1] + "]");
                        break;

                    case 2:
                        TBot.SendMessage(messages[2]);
                        Console.WriteLine("Sent message [" + messages[2] + "]");
                        break;

                    case 3:
                        TBot.SendMessage(messages[3]);
                        Console.WriteLine("Sent message [" + messages[3] + "]");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Sleeping for " + w_seconds + " seconds");
                Console.ResetColor();
                Thread.Sleep(w_seconds * 1000);
            }
        }
    }
}
