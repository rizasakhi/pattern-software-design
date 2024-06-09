<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="Tugas_LAB_PSD.View.UpdatePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Update Password Page</h1>

        <div>
            <asp:Label ID="oldLbl" runat="server" Text="Old password: "></asp:Label>
            <asp:TextBox ID="oldTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="newLbl" runat="server" Text="New password: "></asp:Label>
            <asp:TextBox ID="newTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
        </div>
    </form>
</body>
</html>
