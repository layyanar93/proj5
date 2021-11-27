<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Project5.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<title></title>
        <h1 style="font-family: 'Arial Unicode MS'; background-color: #FFFFFF; color: #800000;">Recipe Vault</h1>
        <p class="lead" style="font-family: Calibri">Staff page is for administrative purposes only.</p>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Calibri">
             <strong>Staff Login:</strong><br />
            <asp:Label ID="Label1" runat="server" Text="username:  "></asp:Label>
            <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="password:   "></asp:Label>
            <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
            <br />
            <asp:Label ID="loginLabel" runat="server" Text="Login Result"></asp:Label>
             <br />
             <br />
        </div>
    </form>
</body>
</html>
