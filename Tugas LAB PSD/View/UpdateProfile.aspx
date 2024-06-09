<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Tugas_LAB_PSD.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Update Profile Page</h1>
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="< User Information >"></asp:Label>
            <br />
            <asp:Label ID="NameData" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="EmailData" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="GenderData" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="DobData" runat="server" Text=""></asp:Label>
            <br /> <br />
        </div> 
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
            <asp:Label ID="dobLbl" runat="server" Text="Date of Birth [dd/mm/yyyy]: "></asp:Label>
            <asp:TextBox ID="dobTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
        </div>
    </form>
</body>
</html>
