using KlivesAlgoTrader.Data_Fetching;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KlivesAlgoTrader.Prerequisites
{
    public class Prerequisites
    {
        public static string SecretsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KliveAlgoSecrets.json");

        public static bool RunPrerequisites()
        {
            bool secretsAcquired = false;

            //Check that API Key for CoinMarketCap and Kucoin have been input into the secrets file.
            if (!File.Exists(SecretsPath))
            {
                SecretsData secretsData = new SecretsData();
                secretsData.CMCKey = "<enterCMCKeyHere>";
                secretsData.KucoinAPIKey = "<enterKucoinAPIKeyHere>";
                File.WriteAllText(SecretsPath, JsonConvert.SerializeObject(secretsData));
                secretsAcquired = false;
            }
            else
            {
                secretsAcquired = true;
            }
        }
    }
}
