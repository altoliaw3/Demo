<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch5-9.aspx.cs" Inherits="WebApp_F.ch5_9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_One" runat="server" Text="按鍵1" OnClick="btn_One_Click" />
            <asp:Button ID="btn_Two" runat="server" Text="按鍵2" OnClick="btn_Two_Click" /><br />
            <asp:Panel ID="pl_1" runat="server">
                文字和文字框1被包住Panel<br />
                <asp:TextBox ID="Tbx_Name1" runat="server"></asp:TextBox>
            </asp:Panel>
            <asp:Panel ID="pl_2" runat="server" BorderColor="#336600">
                文字和文字框2被包住Panel<br />
                <asp:TextBox ID="Tbx_Name2" runat="server"></asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
