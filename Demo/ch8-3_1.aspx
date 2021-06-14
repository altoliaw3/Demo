<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch8-3_1.aspx.cs" Inherits="WebApp_F.ch8_3_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>
            <asp:Button ID="btn_Submit" runat="server" Text="送出" OnClick="btn_Submit_Click" />
        </div>
    </form>
</body>
</html>
