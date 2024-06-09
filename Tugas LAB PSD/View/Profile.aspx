<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Tugas_LAB_PSD.View.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Profile Page</h1>
        <div>
            <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click"/>
            <asp:Button ID="UpdatePasswordBtn" runat="server" Text="Update Password" OnClick="UpdatePasswordBtn_Click"/>
        </div>
    </form>
</body>
</html>
