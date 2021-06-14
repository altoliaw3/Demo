<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ch6-6.aspx.cs" Inherits="WebApp_F.ch6_6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>請輸入偶數
            <asp:TextBox ID="tb_Num" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cv_Num" runat="server"
                ErrorMessage="輸入錯誤" ForeColor="Maroon" ControlToValidate="tb_Num"
                OnServerValidate="cv_Num_ServerValidate"></asp:CustomValidator><br />
            <asp:Button ID="btn_Sumbit" runat="server" Text="送出" OnClick="btn_Sumbit_Click" /><br />
            <asp:Label ID="lb_Msg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
