using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Text.Json.Serialization.Metadata;
using Newtonsoft.Json;
using KlivesAlgoTrader.Logging;

namespace KlivesAlgoTrader.Data_Fetching
{
    class CryptoCharts
    {
        HttpClient wc = new();
        SecretsData secrets = new SecretsData();

        private const int RateLimitCMCPerMinute = 30;
        private const int MonthlyAPICredits = 10000;

        public CryptoCharts()
        {
            secrets = LoadAPIKeys();
            bool webClientResult = SetUpWebClient();
            if (webClientResult == false)
            {
                throw new Exception("CMC API key is invalid.");
            }
        }
        public struct CryptoChart
        {

        }

        private bool SetUpWebClient(bool testIfSecretWorks = true)
        {
            wc.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", secrets.CMCKey);

            if (testIfSecretWorks)
            {

                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
