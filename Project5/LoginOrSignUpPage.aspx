<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginOrSignUpPage.aspx.cs" Inherits="Project5.LoginOrSignUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <h1 style="font-family: 'Arial Unicode MS'; background-color: #FFFFFF; color: #800000;">Recipe Vault</h1>
        <p class="lead" style="font-family: Calibri">Keep your family recipes in a secure place.</p>
        <asp:Label ID="globalLabel" runat="server" Font-Names="Calibri" Text="globalLabel"></asp:Label>
<title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Calibri">
             <strong>Login:</strong><br />
            <asp:Label ID="Label1" runat="server" Text="username:  "></asp:Label>
            <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="password:   "></asp:Label>
            <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CheckBox ID="rememberChk" runat="server" OnCheckedChanged="chkRemember_CheckedChanged" Text="Remember Username" />
            <br />
            <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
            <br />
            <asp:Label ID="loginLabel" runat="server" Text="Login Result"></asp:Label>
             <br />
             <br />
        </div>
        <div style="font-family: Calibri">
            <strong>New User:
            <br />
            </strong>
            (must complete image verifier to enter password)<br />
            username:
            <asp:TextBox ID="newUserTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password:  "></asp:Label>
            <asp:TextBox ID="newPassTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="createUserButton" runat="server" Text="Create User" OnClick="createUserButton_Click" />
            <br />
            <br />
            <br />
            <div>
                <asp:Image ID="Image1" Visible="false" runat="server" />
                <asp:Button ID="showImageButton" runat="server" OnClick="showImageButton_Click" Text="Show Image" Width="167px" />
                <br />
                <br />
                Add the numbers shown.
                <br />
                Enter solution here:
                <asp:TextBox ID="TextBox1" runat="server" Width="98px"></asp:TextBox>
                <br />
                <asp:Button ID="buttonSubmitImage" runat="server" OnClick="buttonSubmitImage_Click" Text="Submit" Width="120px" />
                <br />
                <br />
                <asp:Label ID="imageVerLabel" runat="server" Text="Result" Font-Names="Calibri"></asp:Label>

            </div>
            <br />
            <asp:Label ID="createUserLabel" runat="server" Text="Create User Result" Font-Names="Calibri"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="backToDefButton" runat="server" OnClick="backToDefButton_Click" Text="Back" />
    </form>
</body>
</html>
