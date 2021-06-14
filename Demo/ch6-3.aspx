<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch6-3.aspx.cs" Inherits="WebApp_F.ch6_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_Mail" runat="server" TextMode="Email"></asp:TextBox><br />
            <asp:TextBox ID="tb_MailCheck" runat="server" TextMode="Email"></asp:TextBox><br />
            <asp:CompareValidator ID="cv_Mail" runat="server" ErrorMessage="輸入不同" 
                ControlToCompare="tb_MailCheck" ControlToValidate="tb_Mail"
                ForeColor="Maroon"></asp:CompareValidator><br />
            <asp:Button ID="btn_Submit" runat="server" Text="送出" />
        </div>
    </form>
</body>
</html>
