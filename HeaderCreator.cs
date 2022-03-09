using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace InvoiceGenerator
{
    internal class HeaderCreator
    {
        internal HeaderCreator()
        {
            string fileName = @"C:\Users\HP\source\repos\InvoiceGenerator\GEN.docx";

            var doc = DocX.Create(fileName);

            doc.InsertParagraph("Hello Word");

            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }

    }
}
