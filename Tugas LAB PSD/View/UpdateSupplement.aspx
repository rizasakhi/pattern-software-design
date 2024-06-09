<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateSupplement.aspx.cs" Inherits="Tugas_LAB_PSD.View.UpdateSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Supplement Page</h1>

    <div>
        <asp:Label ID="Label1" runat="server" Text="< Supplement Information >"></asp:Label>
        <br />
        <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="dateLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="priceLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="typeidLbl" runat="server" Text=""></asp:Label>
        <br /> <br />
    </div> 

    <div>
        <asp:Label ID="SupplementNamelbl" runat="server" Text="Supplement Name: "></asp:Label>
        <asp:TextBox ID="SuplementNameTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="SupplementExDatelbl" runat="server" Text="Supplement Expire Date [mm/dd/yyyy]: "></asp:Label>
        <asp:TextBox ID="SupplementExDateTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="SupplementPricelbl" runat="server" Text="Supplement Price: "></asp:Label>
        <asp:TextBox ID="SupplementPriceTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="SupplementTypelbl" runat="server" Text="Supplement Type: "></asp:Label>
        <asp:DropDownList ID="SupplementTypeDropDown" runat="server"></asp:DropDownList>
    </div>

    <div>
        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="backToManage" runat="server" Text="Back" OnClick="backToManage_Click"/>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
    </div>
</asp:Content>
