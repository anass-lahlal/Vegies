<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ItemControl.ascx.cs" Inherits="ItemControl" %>
<style type="text/css">
    .auto-style1 {
        width: 42%;
        height: 144px;
    }
    .auto-style2 {
        width: 146px;
    }
    .auto-style3 {
        font-size: large;
    }
    .auto-style4 {
        width: 146px;
        height: 55px;
        text-align: justify;
    }
    .auto-style6 {
        margin-left: 0px;
    }
    .auto-style5 {
        height: 55px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2" rowspan="3">
            <asp:Panel ID="Panel1" runat="server" Height="140px" Width="139px">
                <asp:Image ID="Image1" runat="server" Height="131px" Width="132px" />
            </asp:Panel>
        </td>
        <td><strong>
            <asp:Label ID="lblItem" runat="server" CssClass="auto-style3" Text="&quot;Item name&quot;"></asp:Label>
            </strong></td>
    </tr>
    <tr>
        <td>
            Quantity :
            <asp:Label ID="lblQuantity" runat="server" Text="&quot;Item quantity&quot;"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Price :&nbsp;
            <asp:Label ID="lblPrice" runat="server" Text="&quot;Item price&quot;"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" CssClass="auto-style6" Height="33px" Text="Add to chart" Width="131px" OnClick="btnAdd_Click" />
        </td>
        <td class="auto-style5">&nbsp;Quantity : &nbsp;<asp:TextBox ID="txtQuantity" runat="server" TextMode="Number" Width="35px">0</asp:TextBox>
       </td>
    </tr>
</table>

