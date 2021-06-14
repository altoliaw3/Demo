<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch6-4.aspx.cs" Inherits="WebApp_F.ch6_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            落塵量(0~3.5間)<asp:TextBox ID="tb_Num" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="rv_Num" runat="server" ErrorMessage="數字輸入有誤" 
                ControlToValidate="tb_Num" MinimumValue="0.0" MaximumValue="3.5"
                Type="Double" ForeColor="#800000">
            </asp:RangeValidator><br />
            <asp:Button ID="btn_Submit" runat="server" Text="送出" OnClick="btn_Submit_Click" /><br />
            <asp:Label ID="lb_Msg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
