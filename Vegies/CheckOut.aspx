<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckOut.aspx.cs" Inherits="CheckOut" %><%@ Reference Control="Payment.ascx" %>

<%@ Register src="Payment.ascx" tagname="Payment" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 104px;
        }
        .auto-style2 {
            font-size: x-large;
            width: 1011px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            width: 1011px;
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"><strong>Welcome&nbsp; </strong>
                    <asp:Label ID="lblWelcome" runat="server" CssClass="auto-style3" Font-Bold="True" Font-Italic="True" ForeColor="#FF5050" Text="&quot;username&quot;"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblPrice" runat="server" CssClass="auto-style3" Text="Total price :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSignOut" runat="server" Height="29px" OnClick="btnSignOut_Click" Text="Sign out" Width="77px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <uc1:Payment ID="Payment1" runat="server" />
                </td>
            </tr>
        </table>
    &nbsp;
        <asp:Button ID="btnConfirm" runat="server" Height="33px" OnClick="btnConfirm_Click" Text="Confirm" Width="83px" />
    </form>
</body>
</html>
