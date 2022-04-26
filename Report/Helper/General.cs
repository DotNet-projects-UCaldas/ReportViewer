using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;

public static class General
{
    public static Tuple<byte[], string> RenderReports(string reportpath, List<string> dataset, object data, string type, string deviceInfo = "")
    {
        LocalReport lr = new LocalReport();
        lr.ReportPath = reportpath;
        lr.EnableHyperlinks = true;

        ReportDataSource res = new ReportDataSource("Cotizacion", data);

        lr.DataSources.Add(res);

        Warning[] warnings;
        string[] streams;
        byte[] renderedBytes;
        string mimeType, encoding, fileNameExtension;

        renderedBytes = lr.Render(
            "PDF",
            deviceInfo,
            out mimeType,
            out encoding,
            out fileNameExtension,
            out streams,
            out warnings
        );

        return new Tuple<byte[], string>(renderedBytes, "text/plain");
    }
}