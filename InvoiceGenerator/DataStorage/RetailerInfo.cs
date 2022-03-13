using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    internal class RetailerInfo
    {
        public string CompanyName { get; set; }
        public string CompanyStreet { get; set; }
        public string CompanyCity { get; set; }
        public string ICO { get; set; }

        [JsonProperty("IC DPH")]
        public string ICDPH { get; set; }
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
    }
}
