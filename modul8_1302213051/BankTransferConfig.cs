using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302213051
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set;}
        public string methods { get; set; }
        public string confirmation { get; set; }

        public static BankTransferConfig LoadConfig()
        {
            BankTransferConfig config;
            string configJSON = File.ReadAllText(@"D:\Kuliah\C#\modul8_1302213051\bank_transfer_config.json");
            config = JsonConvert.DeserializeObject<BankTransferConfig>(configJSON);

            return config;
        }
    }
}
