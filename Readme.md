<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602453/13.2.13%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T227361)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/T227361/Default.aspx) (VB: [Default.aspx](./VB/T227361/Default.aspx))**
* [Default.aspx.cs](./CS/T227361/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/T227361/Default.aspx.vb))
<!-- default file list end -->
# How to print/export XtraReport in an ASP.NET WebForms application without showing a report preview


<p>This example demonstrates how to print/export XtraReport without displaying a report preview and using the preview's printing/exporting functionality. </p>
<p>The main idea of this approach is to export XtraReport into the page's Response by using one of its <strong>ExportTo...</strong> methods.<br>To print the report, export it to the PDF format. Then write this PDF to a page's Response with the <strong>Content-Disposition</strong> header set to the "inline" value. In this case, this PDF will be opened by the browser's built-in PDF viewer. To avoid opening the PDF viewer in the browser's window, export the PDF to a separate iframe. In this case, only the print dialog will be displayed.<br><br><strong>See also:</strong><br><a href="https://github.com/DevExpress-Examples/Reporting-Angular-Print-Without-Preview">How to print and export DevExpress reports without previewing them on a web page in an ASP.NET Core Angular application</a><br><a href="https://www.devexpress.com/Support/Center/p/E454">E454: How to print a report without displaying it in a web application</a><br><a href="https://www.devexpress.com/Support/Center/p/T569785">T569785: How to print/export XtraReport in an ASP.NET MVC application without showing a report preview</a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-webforms-print-export-report-without-showing-a-preview&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-webforms-print-export-report-without-showing-a-preview&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
