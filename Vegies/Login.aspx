<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 45px;
        }
        .auto-style3 {
            width: 441px;
        }
        .auto-style4 {
            font-size: xx-large;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style4">
    
        <strong>Welcome </strong>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Username:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUsername" runat="server" Width="172px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="172px"></asp:TextBox>
&nbsp;<asp:Label ID="lblWarning" runat="server" ForeColor="Red" Text="Username or password is incorrect !" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="101px" />
&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">Register?</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
