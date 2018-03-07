<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Payment.ascx.cs" Inherits="Payment" %>
<p>
    Here are your items :
</p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="220px" Width="463px">
    <Columns>
        <asp:BoundField DataField="item_name" HeaderText="item_name" SortExpression="item_name" />
        <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [item_name], [quantity], [price] FROM [Chart]"></asp:SqlDataSource>
<p>
    &nbsp;<asp:Label ID="lblAddress" runat="server" Text="Mr. &quot;name&quot;, your order will go to this address: &quot;address&quot;."></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Select your payment method :&nbsp;&nbsp; <asp:RadioButton ID="rbCash" runat="server" Checked="True" GroupName="paymentMethod" Text="Cash" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="rbCreditCard" runat="server" GroupName="paymentMethod" Text="Credit Card" />
</p>
<p>
    Total amount to be paid :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
    <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
</p>

