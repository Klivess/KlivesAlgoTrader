using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlivesAlgoTrader.Secrets
{
    internal class Secrets
    {
        public struct SecretsData
        {
            public string KucoinAPIKey;
            public string CMCKey;
        }

        public static SecretsData LoadAPIKeys()
        {
            string text = File.ReadAllText(Prerequisites.Prerequisites.SecretsPath);
            SecretsData deserialisedText = JsonConvert.DeserializeObject<SecretsData>(text);
            return deserialisedText;
        }
    }
}
