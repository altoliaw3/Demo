<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch6-5.aspx.cs" Inherits="WebApp_F.ch6_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_CTEL" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="rev_CTEL" runat="server" ErrorMessage="不符合格式"
                ControlToValidate="tb_CTEL" ValidationExpression="^09\d{2}-\d{3}-\d{3}$" 
                ForeColor="Maroon"></asp:RegularExpressionValidator><br />
            <asp:Button ID="btn_Submit" runat="server" Text="送出" OnClick="btn_Submit_Click" /><br />
            <asp:Label ID="lb_Msg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
