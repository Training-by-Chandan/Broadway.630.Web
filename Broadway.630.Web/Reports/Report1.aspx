<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report1.aspx.cs" Inherits="Broadway._630.Web.Reports.Report1" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <asp:ScriptManager ID="scriptManagerReport" runat="server">  
         </asp:ScriptManager>  
        <rsweb:ReportViewer runat="server" ShowPrintButton="false" Width="99.9%" Height="100%" AsyncRendering="true" ZoomMode="Percent" KeepSessionAlive="true" ID="rvSiteMapping" SizeToReportContent="false">
        </rsweb:ReportViewer>
    </form>
</body>
</html>