using System;

namespace InvoiceGenerator
{
	
	//https://www.c-sharpcorner.com/article/generate-word-document-using-c-sharp/
    class StartApplication
    {
        static void Main(string[] args)
        {
            InvoiceSettings settings = new InvoiceSettings();
            HeaderCreator header = new HeaderCreator();
        }
    }
}
