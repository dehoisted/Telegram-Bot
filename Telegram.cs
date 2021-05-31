using System;
using System.IO;
using System.Net;

namespace Telegram
{
    sealed class TelegramBot
    {
        public static int BotCount = 0;
        private readonly string botid;
        private readonly string chatid;
        private readonly bool running;

        public TelegramBot(string aBotID, string aChatID)
        {
            botid = aBotID;
            chatid = aChatID;
            running = true;
            BotCount++;
        }

        public static int GetRand(int x, int y)
        {
            Random rand = new Random();
            int num = rand.Next(x, y);
            return num;
        }

        private string GetUrl(string BotID, string chatID, string msg)
        {
            string url = "https://api.telegram.org/bot" + BotID + "/sendMessage?chat_id=" + chatID + "&text=" + msg;
            return url;
        }

        private string GetReq(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse()) // If an exception thrown here then the bot ID passed in is invalid
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public void SendMessage(string msg)
        {
            string url = GetUrl(botid, chatid, msg);
            GetReq(url);
        }

        public bool IsRunning()
        {
            if (running)
            {
                return true;
            }

            return false;
        }
    }
}
