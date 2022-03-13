using System;

namespace InvoiceGenerator
{

    //https://www.c-sharpcorner.com/article/generate-word-document-using-c-sharp/
    public class Invoice
    {
        private CustomerInfo CustomerInfo;
        private RetailerInfo RetailerInfo;
        public Invoice()
        {
            Console.WriteLine("Hello");
            Header = new HeaderCreator();
        }

    }
}
