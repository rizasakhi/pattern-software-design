<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Tugas_LAB_PSD.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
        <div>
            <asp:Label ID="usernameLbl" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="emailLbl" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="genderLbl" runat="server" Text="Gender: "></asp:Label>
            <asp:TextBox ID="genderTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="passwordLbl" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="confirmLbl" runat="server" Text="Confirmation Password: "></asp:Label>
            <asp:TextBox ID="confirmTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="dobLbl" runat="server" Text="Date of Birth [dd/mm/yyyy]: "></asp:Label>
            <asp:TextBox ID="dobTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:LinkButton ID="toLoginLink" runat="server" OnClick="toLoginLink_Click">Already have an account? Login</asp:LinkButton>
        </div>
        <div>
            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
        </div>
    </form>
</body>
</html>
