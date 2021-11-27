<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="StaffPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This page is for Staff only. User logins will not be accepted.<br />
            Ask administrator for access to this page.
        </div>
        <p>
            Username:
            <asp:TextBox ID="staffUnameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="staffPassTextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="staffLoginButton" runat="server" Text="Login" />
        <br />
        <br />
        <asp:Label ID="staffLoginResultLabel" runat="server" Text="result"></asp:Label>
    </form>
</body>
</html>
