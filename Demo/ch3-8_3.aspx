<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch3-8_3.aspx.cs" Inherits="WebApp_F.ch3_8_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="呼叫方法" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="遞迴方法呼叫" />
    </form>
</body>
</html>
