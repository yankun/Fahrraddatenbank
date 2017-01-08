using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.Pdf
{
    public class PdfAnalyzer
    {
        public PdfAnalyzer()
        {
        }

        public void AnalayzePdf()
        {
            var reader = new PdfReader(new Uri(""));
            var sw = new StringWriter();

            for (int i = reader.NumberOfPages; i <= reader.NumberOfPages; i++)
            {
                var page = reader.GetPageOrigRef(i);
                
            }
        }
    }
}
