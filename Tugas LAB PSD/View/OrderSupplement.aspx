<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="OrderSupplement.aspx.cs" Inherits="Tugas_LAB_PSD.View.OrderSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Supplement Page</h1>

    <div>
        <asp:GridView ID="SupplementGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvSupplement_SelectedIndexChanged" OnRowCommand="gvSupplement_RowCommand">
            <Columns>
                <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="Expiry Date" />
                <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="TypeID" />
    
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuantity" runat="server" Text="0"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
    
                <asp:ButtonField Text="Order" CommandName="Order" ButtonType="Button" ShowHeader="True" HeaderText="Action"/>
            </Columns>
        </asp:GridView>
    </div>
    
    <div>
        <asp:Label runat="server" Text="< Cart >"></asp:Label>
        <asp:GridView ID="CartGV" runat="server"></asp:GridView>
        <div>
            <asp:Button ID="clearCartBtn" runat="server" Text="Clear Cart" OnClick="clearCartBtn_Click" />
            <asp:Button ID="checkOutBtn" runat="server" Text="Checkout" OnClick="checkOutBtn_Click" />
        </div>
    </div>
    
</asp:Content>
