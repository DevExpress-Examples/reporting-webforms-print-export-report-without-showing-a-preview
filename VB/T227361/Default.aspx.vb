Imports System
Imports System.Web
Imports System.Web.UI.WebControls
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraPrinting

Namespace T227361

    Public Partial Class [Default]
        Inherits UI.Page

        Private Sub WriteDocumentToResponse(ByVal documentData As Byte(), ByVal format As String, ByVal isInline As Boolean, ByVal fileName As String)
            Dim contentType As String
            Dim disposition As String = If(isInline, "inline", "attachment")
            Select Case format.ToLower()
                Case "xls"
                    contentType = "application/vnd.ms-excel"
                Case "xlsx"
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                Case "mht"
                    contentType = "message/rfc822"
                Case "html"
                    contentType = "text/html"
                Case "txt", "csv"
                    contentType = "text/plain"
                Case "png"
                    contentType = "image/png"
                Case Else
                    contentType = String.Format("application/{0}", format)
            End Select

            Response.Clear()
            Response.ContentType = "application/pdf"
            Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName))
            Response.BinaryWrite(documentData)
            Response.End()
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim printFlag As Boolean
            If Not Equals(Request.QueryString("Print"), Nothing) AndAlso Boolean.TryParse(CStr(Request.QueryString("Print")), printFlag) AndAlso printFlag Then
                'Printing
                Dim report As XtraReport = New ProductsReport()
                Using ms As MemoryStream = New MemoryStream()
                    report.ExportToPdf(ms, New PdfExportOptions() With {.ShowPrintDialogOnOpen = True})
                    WriteDocumentToResponse(ms.ToArray(), "pdf", True, "Report.pdf")
                End Using
            End If
        End Sub

        Protected Sub btExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Exporting
            Dim report As XtraReport = New ProductsReport()
            Dim format As String = ddlExportFormat.SelectedValue
            Dim fileName As String = String.Format("Report.{0}", format)
            Using ms As MemoryStream = New MemoryStream()
                Select Case format
                    Case "pdf"
                        report.ExportToPdf(ms)
                    Case "xls"
                        report.ExportToXls(ms)
                    Case "xlsx"
                        report.ExportToXlsx(ms)
                    Case "rtf"
                        report.ExportToRtf(ms)
                    Case "mht"
                        report.ExportToMht(ms)
                    Case "html"
                        report.ExportToHtml(ms)
                    Case "txt"
                        report.ExportToText(ms)
                    Case "csv"
                        report.ExportToCsv(ms)
                    Case "png"
                        report.ExportToImage(ms, New ImageExportOptions() With {.Format = System.Drawing.Imaging.ImageFormat.Png})
                    Case Else
                        Return
                End Select

                WriteDocumentToResponse(ms.ToArray(), format, False, fileName)
            End Using
        End Sub
    End Class
End Namespace
