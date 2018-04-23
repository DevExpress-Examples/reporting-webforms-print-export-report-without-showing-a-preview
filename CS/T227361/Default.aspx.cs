using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.XtraPrinting;

namespace T227361 {
    public partial class Default : System.Web.UI.Page {
        void WriteDocumentToResponse(byte[] documentData, string format, bool isInline, string fileName) {
            string contentType;
            string disposition = (isInline) ? "inline" : "attachment";

            switch (format.ToLower()) {
                case "xls":
                    contentType = "application/vnd.ms-excel";
                    break;
                case "xlsx":
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "mht":
                    contentType = "message/rfc822";
                    break;
                case "html":
                    contentType = "text/html";
                    break;
                case "txt":
                case "csv":
                    contentType = "text/plain";
                    break;
                case "png":
                    contentType = "image/png";
                    break;
                default:
                    contentType = String.Format("application/{0}", format);
                    break;
            }

            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName));
            Response.BinaryWrite(documentData);
            Response.End();
        }

        protected void Page_Load(object sender, EventArgs e) {
            bool printFlag;
            if (Request.QueryString["Print"] != null && Boolean.TryParse((string)Request.QueryString["Print"], out printFlag) && printFlag) {
                //Printing
                XtraReport report = new ProductsReport();
                using (MemoryStream ms = new MemoryStream()) {
                    report.ExportToPdf(ms, new PdfExportOptions() { ShowPrintDialogOnOpen = true });
                    WriteDocumentToResponse(ms.ToArray(), "pdf", true, "Report.pdf");
                }
            }
        }

        protected void btExport_Click(object sender, EventArgs e) {
            //Exporting
            XtraReport report = new ProductsReport();

            string format = ddlExportFormat.SelectedValue;
            string fileName = String.Format("Report.{0}", format);

            using (MemoryStream ms = new MemoryStream()) {
                switch (format) {
                    case "pdf":
                        report.ExportToPdf(ms);
                        break;
                    case "xls":
                        report.ExportToXls(ms);
                        break;
                    case "xlsx":
                        report.ExportToXlsx(ms);
                        break;
                    case "rtf":
                        report.ExportToRtf(ms);
                        break;
                    case "mht":
                        report.ExportToMht(ms);
                        break;
                    case "html":
                        report.ExportToHtml(ms);
                        break;
                    case "txt":
                        report.ExportToText(ms);
                        break;
                    case "csv":
                        report.ExportToCsv(ms);
                        break;
                    case "png":
                        report.ExportToImage(ms, new ImageExportOptions() { Format = System.Drawing.Imaging.ImageFormat.Png });
                        break;
                    default:
                        return;
                }
                WriteDocumentToResponse(ms.ToArray(), format, false, fileName);
            }
        }
    }
}