<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="ManageSupplement.aspx.cs" Inherits="Tugas_LAB_PSD.View.ManageSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Supplement Page</h1>

    <div>
        <asp:GridView ID="SupplementGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="SupplementGV_RowDeleting" OnRowEditing="SupplementGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="SupplementId" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="Expiry Date" />
                <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="TypeID" />
           
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="editBtn" runat="server" Text="Update" UseSubmitBehavior="false" CommandName="Edit" />
                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" UseSubmitBehavior="false" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    
    <br />
    <asp:Button ID="InsertSupplementBtn" runat="server" Text="Insert supplement" OnClick="InsertSupplementBtn_Click"/>
</asp:Content>
