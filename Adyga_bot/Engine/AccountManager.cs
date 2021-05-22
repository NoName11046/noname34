using Adyga_bot;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace Adyga_bot
{
    internal class AccountManager
    {
        private string Login { get; set; }
        private string Password { get; set; }
        private WebClient webClient { get; set; }
        private Random Random { get; set; }
        public string App { get; set; }
        public string infoAccount { get; set; }
        public string UserId { get; set; }
        public static string AppId { get; set; }
        public AccountManager() { }
        public AccountManager(string Login, string Password)
        {
            webClient = new WebClient();
            Random = new Random();
            this.Login = Login;
            this.Password = Password;
        }
        public string Authorize()
        {
            var cc = new CookieContainer();
            var accessToken = Network.GET("https://m.vk.com/", cc);
            accessToken = StrWrk.GetBetween(accessToken, "action=\"", "\"");
            string url = accessToken;
            accessToken = Network.POST(url, $"email={Login}&pass={Password}", cc);
            dynamic response = null;

            string vkApi;

            var token = string.Empty;

            accessToken =
                          Network.GET($"https://oauth.vk.com/authorize?client_id=2685278&scope=1073737727&redirect_uri=https://oauth.vk.com/blank.html&display=page&response_type=token&revoke=1", out vkApi, cc);

            if (vkApi == null)
                accessToken = StrWrk.GetBetween(accessToken, "form method=\"post\" action=\"", "\"");
            else
                accessToken = vkApi;
            Network.GET(accessToken, out vkApi, cc);

            token = StrWrk.GetBetween(vkApi, "access_token=", "&");

            response = JsonConvert.DeserializeObject(VKserver.APIRequest("users.get", "", token, ""));
            infoAccount = $"{response["response"][0]["first_name"]} {response["response"][0]["last_name"]}";

            return token;
        }
    }
}
