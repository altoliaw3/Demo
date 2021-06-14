<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chex2_1.aspx.cs" Inherits="Demo.chex2_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb_Out" runat="server" Text="Label"></asp:Label>
            <asp:ScriptManager ID="sm_Condition" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="up_Condition" runat="server">
               <ContentTemplate>
                   <asp:Label ID="lb_In" runat="server" Text="Label"></asp:Label>
               </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btn_Sub" EventName="Click" />
                </Triggers>

            </asp:UpdatePanel>
            <asp:Button ID="btn_Sub" runat="server" Text="送出" OnClick="btn_Sub_Click" />
        </div>
    </form>
</body>
</html>
