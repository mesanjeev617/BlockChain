using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DHANA
{
    class TransacData
    {
        public int TradedQuantity { get; set; }
        public string SenderKey { get; set; }
        public string ReceiverKey { get; set; }
        public DateTime Creation { get; set; }
        public string RawHash { get; set; }
        public string FinalHash { get; set; }

        public TransacData(int t, string s, string r, DateTime cr)
        {
            this.TradedQuantity = t;
            this.SenderKey = s;
            this.ReceiverKey = r;
            this.Creation = cr;
        }

        public static String HashData(int i, string s, string r, DateTime t)
        {
            string RawHash = i.ToString() + s + r.ToString() + t.ToString();
            string FinalHash = GetStringSha256Hash(RawHash);
            return FinalHash;

        }



        public static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty); 
            }
        }
    }
}

