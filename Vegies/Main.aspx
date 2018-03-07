<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %> <%@ Reference Control="ItemControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 999px;
            height: 249px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style7 {
            font-size: x-large;
            width: 199px;
        }
        .auto-style8 {
            font-size: x-large;
            width: 1657px;
            text-align: center;
        }
        .auto-style9 {
            font-size: x-large;
            width: 200px;
            text-align: right;
        }
        .auto-style10 {
            width: 937px;
            height: 88px;
        }
        .auto-style11 {
            width: 511px;
            height: 88px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style7"><strong>Welcome<br />
                    </strong>
                    <asp:Label ID="lblWelcome" runat="server" CssClass="auto-style3" Font-Bold="True" Font-Italic="True" ForeColor="#FF5050" Text="&quot;username&quot;"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style8" colspan="2">Items<br />
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="132px" AutoPostBack="True">
                    </asp:DropDownList>
                    <br />
                    <asp:Label ID="lblPrice" runat="server" CssClass="auto-style3" Text="&quot;Price:&quot;"></asp:Label>
                    <br />
                </td>
                <td class="auto-style9">&nbsp;<asp:Button ID="btnCheckOut" runat="server" Height="29px" OnClick="btnCheckOut_Click" Text="Check out" Width="77px" />
                    &nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style9">
                    <asp:Button ID="btnSignOut" runat="server" Height="29px" OnClick="btnSignOut_Click" Text="Sign out" Width="77px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style11" colspan="3">
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    
                </td>
            </tr>
        </table>
        <p>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </p>
    </form>
</body>
</html>
