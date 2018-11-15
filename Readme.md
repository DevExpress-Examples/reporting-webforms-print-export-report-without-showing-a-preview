<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/T227361/Default.aspx) (VB: [Default.aspx](./VB/T227361/Default.aspx))**
* [Default.aspx.cs](./CS/T227361/Default.aspx.cs) (VB: [Default.aspx](./VB/T227361/Default.aspx))
<!-- default file list end -->
# How to print/export XtraReport in an ASP.NET WebForms application without showing a report preview


<p>This example demonstrates how to print/export XtraReport without displaying a report preview and using the preview's printing/exporting functionality. </p>
<p>The main idea of this approach is to export XtraReport into the page's Response by using one of its <strong>ExportTo...</strong> methods.<br>To print the report, export it to the PDF format and enable the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPdfExportOptions_ShowPrintDialogOnOpentopic">ShowPrintDialogOnOpen</a> option in the export options. Then export this PDF to a page's Response with the <strong>Content-Disposition</strong> header set to the "inline" value. In this case, this PDF will be opened by the browser's PDF plugin. To avoid opening the PDF viewer in the browser's window, export the PDF to a separate iframe. In this case, only the print dialog will be displayed.<br><br><strong>See also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/E454">E454: How to print a report without displaying it in a web application</a><br><a href="https://www.devexpress.com/Support/Center/p/T569785">T569785: How to print/export XtraReport in an ASP.NET MVC application without showing a report preview</a></p>

<br/>


