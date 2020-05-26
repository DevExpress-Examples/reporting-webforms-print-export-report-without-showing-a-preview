<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="T227361.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Print() {
            var url = document.URL.split('?')[0];
            window.open(url + "?Print=true", "PrintingFrame");
        }
        function PrintWithiFrame() {
            var url = document.URL.split('?')[0];
            window.open(url + "?Print=true", "PrintingFrame");
            var frameElement = document.getElementById("FrameToPrint");
            frameElement.addEventListener("load", function (e) {
                if (frameElement.contentDocument.contentType !== "text/html")
                    frameElement.contentWindow.print();
            });
        }
        function PrintInNewWindow() {
            var url = document.URL.split('?')[0];
            var printWindowWrapper = window.open(url + "?Print=true", "_blank");

            printWindowWrapper.addEventListener("load", function (e) {
                if (printWindowWrapper.document.contentType !== "text/html")
                    printWindowWrapper.print();
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="text-align: center">
            <tr>
                <td style="width: 150px">
                    Printing
                </td>
                <td style="width: 150px" colspan="2">
                    Exporting
                </td>
            </tr>
            <tr>
                   <td width="500px">
                        <input type="button" value="Print With iFrame" onclick="PrintWithiFrame(); return false;" /> <br />
                        <b>Note:</b> Printing with an invisible iFrame element is not recommended. Although this solution provides more desktop-like experience, it's not guaranteed to work reliably across all browsers. For example, it won't work in the Edge or Safary browser. <br />
                        <br />
                        <input type="button" value="Print New Window" onclick="PrintInNewWindow(); return false;" /> <br />
                        <b>Note:</b> clicking this button will open a separate tab in the browser. This is the recommented approach.
                        <iframe id="FrameToPrint" name="PrintingFrame" style="position:absolute; left: -10000px; top: -10000px;"></iframe>
                    </td>
                <td>
                    <asp:DropDownList ID="ddlExportFormat" runat="server">
                        <asp:ListItem Value="pdf" Text="Pdf" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="xls" Text="Xls"></asp:ListItem>
                        <asp:ListItem Value="xlsx" Text="Xlsx"></asp:ListItem>
                        <asp:ListItem Value="rtf" Text="Rtf"></asp:ListItem>
                        <asp:ListItem Value="mht" Text="Mht"></asp:ListItem>
                        <asp:ListItem Value="html" Text="Html"></asp:ListItem>
                        <asp:ListItem Value="txt" Text="Text"></asp:ListItem>
                        <asp:ListItem Value="csv" Text="Csv"></asp:ListItem>
                        <asp:ListItem Value="png" Text="Image"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btExport" runat="server" Text="Export" OnClick="btExport_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>