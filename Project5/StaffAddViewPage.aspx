<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffAddViewPage.aspx.cs" Inherits="Project5.StaffAddViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <h1 style="font-family: 'Arial Unicode MS'; background-color: #FFFFFF; color: #800000;">Recipe Vault</h1>
        <p class="lead" style="font-family: Calibri">Staff page for administrative purposes.</p>
<title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<strong style="font-family: Calibri">Add Staff:</strong><br />
            <asp:Label ID="nameLabel" runat="server" Text="username:  " Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="passLabel" runat="server" Text="password:   " Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" Font-Names="Calibri" style="height: 25px" />
            <br />
            <asp:Label ID="addLabel" runat="server" Text="Add Staff Result" Font-Names="Calibri"></asp:Label>
        </div>
    </form>
</body>
</html>
