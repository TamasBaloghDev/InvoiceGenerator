using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.DataStorage
{
    class ConstantEntries
    {
        public string Title { get; set; }
        public string SumWithoutVAT { get; set; }
        public string VATSymbol { get; set; }
        public string InWords { get; set; }
    }
}
