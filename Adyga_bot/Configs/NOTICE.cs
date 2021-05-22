using Newtonsoft.Json;
using System.IO;

namespace Adyga_bot
{
    public class CONFIGAPI
    {
        internal interface Config
        {
            void Save();
        }

        internal sealed class GLogType : Config
        {
            public string CGetSetLogType;
            public GLogType()
            {
                CGetSetLogType = "";
            }

            public void Save()
            {
                File.WriteAllText("Configs/SaveLoadLogType.json", JsonConvert.SerializeObject(this));
            }
        }

        internal static class CConfig
        {
            public static GLogType LogChangers;
            public static void Get()
            {
                try
                {
                    LogChangers = JsonConvert.DeserializeObject<GLogType>(File.ReadAllText("Configs/SaveLoadLogType.json"));
                }
                catch
                {
                    LogChangers = new GLogType();
                }
            }
        }
    }
}
