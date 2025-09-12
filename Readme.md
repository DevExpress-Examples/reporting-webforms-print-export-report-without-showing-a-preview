<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602453/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T227361)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for ASP.NET WebForms - How to print or export a report without showing a preview

This example demonstrates how to print or export a report in an ASP.NET WebForms application without displaying this report's preview.

![Report Prine or Export Without Preview](Images/screenshot.png)

The report uses one of the **ExportTo...** methods to export a report document to the page's **Response**.

To print the report, export it to the PDF format. Then write the PDF stream to the page's **Response** with the **Content-Disposition** header set to the "inline" value. The browser's built-in PDF viewer opens the PDF file. An alternative method exports the PDF to a separate iframe. In this case, only the print dialog is displayed.

## Files to Look At

- [Default.aspx.cs](CS/T227361/Default.aspx.cs) (VB: [Default.aspx.vb](VB/T227361/Default.aspx.vb))
- [Default.aspx](CS/T227361/Default.aspx) (VB: [Default.aspx](VB/T227361/Default.aspx))

## Documentation

- [Printing and Export in Reporting Tools for Web](https://docs.devexpress.com/XtraReports/404502/web-reporting/common-features/printing)

## More Examples

* [Reporting for ASP.NET MVC - How to print or export a report without showing a preview](https://github.com/DevExpress-Examples/reporting-print-export-report-without-showing-a-preview)
* [How to Print and Export a Report in the ASP.NET Core Application without the Document Viewer](https://github.com/DevExpress-Examples/Reporting-AspNetCore-Print-Without-Preview)
* [How to print and export DevExpress reports without previewing them on a web page in an ASP.NET Core Angular application](https://github.com/DevExpress-Examples/Reporting-Angular-Print-Without-Preview)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-webforms-print-export-report-without-showing-a-preview&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-webforms-print-export-report-without-showing-a-preview&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
