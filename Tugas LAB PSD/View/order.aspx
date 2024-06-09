<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Tugas_LAB_PSD.View.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Order Page</h1>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        <asp:GridView ID="supplementGridView" runat="server" AutoGenerateColumns="false" OnRowCommand="supplementGridView_RowCommand"
            >
            <Columns>
                <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID"></asp:BoundField>
                <asp:BoundField DataField="SupplementName" HeaderText="name" SortExpression="SupplementName"></asp:BoundField>
                <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expired" SortExpression="SupplementExpiryDate"></asp:BoundField>
                <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice"></asp:BoundField>
                <asp:BoundField DataField="MsSupplementType.SupplementTypeName" HeaderText="Type Name" SortExpression="MsSupplementType.SupplementTypeName"></asp:BoundField>
                <asp:TemplateField HeaderText="Order">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtQuantity" TextMode="Number"></asp:TextBox>
                        <asp:Button runat="server" ID="orderButton" Text="Button" UseSubitBehaviour ="false" CommandName="order"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
