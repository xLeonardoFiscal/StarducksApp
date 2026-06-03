using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;

namespace Starducks.Modelo
{
    public class PiePagina : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfPTable pie = new PdfPTable(1);

            pie.TotalWidth = 520f;

            PdfPCell celda = new PdfPCell(new Phrase("STARDUCKS - Página "+ writer.PageNumber));

            celda.Border = 0;

            celda.HorizontalAlignment = Element.ALIGN_CENTER;

            pie.AddCell(celda);

            pie.WriteSelectedRows(0, -1, 36, 30, writer.DirectContent);
        }
    }
}
