using System;

namespace InvoiceGenerator
{

    //https://www.c-sharpcorner.com/article/generate-word-document-using-c-sharp/
    public class Invoice
    {
        private HeaderCreator Header;
        private RetailerInfo Retailer;
        public Invoice()
        {
            Console.WriteLine("Hello");
            Header = new HeaderCreator();
        }

    }
}
