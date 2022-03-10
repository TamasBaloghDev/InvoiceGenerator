using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerator;

namespace WindowsFormsApp1
{
    internal static class CallWrapper
    {
        public static bool GenerateInvoice()
        {
            new InvoiceGenerator.Invoice();
            return true;
        }
    }
}
