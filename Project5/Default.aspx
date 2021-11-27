<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            Login:<br />
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
            <br />
            <br />
            <br />
            New User:
            <br />
            username:
            <asp:TextBox ID="newUserTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password:  "></asp:Label>
            <asp:TextBox ID="newPassTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="createUserButton" runat="server" Text="Create User" OnClick="createUserButton_Click" />
            <br />
            <br />
            (must complete image verifier to register new user)<br />
            <div>
                <asp:Image ID="Image1" Visible="false" runat="server" />
                <asp:Button ID="showImageButton" runat="server" OnClick="showImageButton_Click" Text="Show Image" Width="167px" />
                <br />
                <br />
                Enter string here:
                <asp:TextBox ID="TextBox1" runat="server" Width="98px"></asp:TextBox>
                <br />
                <asp:Button ID="buttonSubmitImage" runat="server" OnClick="buttonSubmitImage_Click" Text="Submit" Width="120px" />
                <br />
                <br />
                <asp:Label ID="imageVerLabel" runat="server" Text="Result"></asp:Label>

            </div>
            <br />
            <br />
            <br />
            <asp:Label ID="createUserLabel" runat="server" Text="Create User Result"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>

