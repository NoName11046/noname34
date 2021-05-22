using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Adyga_bot
{
    public class Api
    {
        [NonSerialized]
             public static bool Working;
        [NonSerialized]
             public bool TokenStatus;
        [XmlElement(ElementName = "login")]
             public string Login;
        [XmlElement(ElementName = "password")]
             public string Password;
        [XmlElement(ElementName = "token")]
             public string Token;
        [XmlElement(ElementName = "target_flooder")]
             public List<FlooderTarget> TargetFlooder;
        [XmlElement(ElementName = "enabled")]
             public bool EnabledFlooder;
        [XmlElement(ElementName = "flooder_delay")]
             public int FloodDelay;
        [XmlElement(ElementName = "infa")]
             public string Informations;
        [XmlElement(ElementName = "user_id")]
             public string UserId;
        public Api() { }
        public Api(string login, string password)
        {
            Login = login;
            Password = password;
            TargetFlooder = new List<FlooderTarget>();
        }
        public int GetToken()
        {
            try
            {
                var api = new AccountManager(Login, Password);
                Token = api.Authorize();
                Informations = api.infoAccount;
                TokenStatus = true;
                UserId = api.UserId;
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        public void SaveToDisk()
        {
            var xmlSerializer = new XmlSerializer(typeof(Api));
            var textWriter = new StreamWriter("Data\\" + Login + ".xml");
            xmlSerializer.Serialize(textWriter, this);
            textWriter.Close();
        }
        private void WorkFL()
        {
            int index = -1;

            while (Working && EnabledFlooder)
            {
                try
                {
                    if (MainForm.phrases.Length != 0 && TargetFlooder.Count > 0)
                    {
                        index = (index + 1) % TargetFlooder.Count;

                        SendMessage(index);
                    }
                }
                catch (Exception ex)
                {
                   Log.Push($"[{Informations} флудер]: возникла ошибка  {ex.Message}");
                }

                Thread.Sleep(FloodDelay);
            }
        }
        private Thread thread;
        public void AsyncWorker()
        {
            if (EnabledFlooder)
            {
                if (thread != null)
                    thread.Abort();
                thread = new Thread(WorkFL);
                thread.Start();
            }
        }

        public void ParseDataGridViewFlooder(DataGridViewRowCollection rows)
        {
            TargetFlooder.Clear();

            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[1].Value != null)
                {
                    TargetFlooder.Add(new FlooderTarget
                        (
                            (row.Cells[0].Value ?? "").ToString(),
                            (row.Cells[1].Value ?? "").ToString()
                        ));
                }
            }
        }

        private void SendMessage(int index)
        {
            var target = TargetFlooder[index].target;
            var name = TargetFlooder[index].name;
            var chatId = StrWrk.qSubstr(target, "im?sel=c", false);
            var userId = StrWrk.qSubstr(target, "im?sel=", false);
            var message = MainForm.phrases[new Random().Next(MainForm.phrases.Length)];
            var sendMessage = name + message;
            sendMessage = WebUtility.UrlEncode(sendMessage);

            try
            {
                if (target.StartsWith("im?sel=c"))
                    VKserver.APIRequest("messages.send", "chat_id=" + chatId + "&message=" + sendMessage, Token, "");
                else if (target.StartsWith("im?sel="))
                    VKserver.APIRequest("messages.send", "user_id=" + userId + "&message=" + sendMessage, Token, "");
                Log.Push($"[{Informations}]: сообщение {message} отправлено в {target}");
            }
            catch (Exception ex)
            {
                Log.Push($"[{Informations}]: ошибка отправки сообщения {ex.Message}");
            }
        }
    }
}
