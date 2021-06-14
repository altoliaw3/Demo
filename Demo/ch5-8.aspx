<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch5-8.aspx.cs" Inherits="WebApp_F.ch5_8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="ch5-8.xml"></asp:XmlDataSource>
            <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
        </div>
    </form>
</body>
</html>
