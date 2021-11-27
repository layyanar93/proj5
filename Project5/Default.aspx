<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Maroon" Text="Recipe Vault"></asp:Label>

        <div dir="ltr" style="font-family: Calibri">
            This application is a recipe storage application, where user can sign up to securely store their recipes in one place.e.<br />
            <br />
            The following functionality is offered: <br />
            1) If general user, click &quot;Member&quot; button to be redirected to the Login/Create user page.<br />
            2) If admin user, click &quot;Staff&quot; button to be redirected to the staff page.<br />
            3) Once user is created, username/password (encrypted) will be stored in a .xml file called members.xml, in the App_Data folder. Next time, user will click login and use the same username/password to be able to retrieve/save their recipes.<br />
&nbsp;&nbsp;&nbsp; - <strong>Testing:</strong> sign up as new user, and then logout and login with previously created username/password.
            <br />
&nbsp;&nbsp;&nbsp; - <strong>Testing:</strong> To verify authentication service works, attempt to log in with an incorrect password.
            <br />
&nbsp;&nbsp;&nbsp; - <strong>Testing: </strong>To verify encryption/decryption works, after creating username/password, check the members.xml file to ensure password is stored encrypted. <br />
            4)&nbsp; Staff Page: ......<br />
            5) User can type recipe in textbox to save in secure storage service.
            <br />
            <strong>&nbsp;&nbsp;&nbsp; - Testing:</strong> To verify Save functionality works, type a recipe (string) into text box. Click &quot;Save&quot;. Logout or restart and Log back into application, then click &quot;Retrieve&quot; to verify the previously saved string is shown. Alternatively, check the recipes.xml file to see if the new data was saved.
            <br />
            6) User can click &quot;Retrieve&quot; to display all the recipes previously saved to the account. <br />
&nbsp;&nbsp;&nbsp; -<strong>Testing:</strong> After logging in as user (not staff), click &quot;retrieve&quot; and make sure your recipes appear on the screen.<br />
            7) User can click &quot;Download&quot; to download recipes that have previously been saved.&nbsp; (browser control)<br />
&nbsp;&nbsp;&nbsp; -Testing: After logging in as user (not staff), click &quot;retrieve&quot; then &quot;download&quot; and verify all of your recipes have been downloaded to file.
            <br />
            <br />
            <br />
            Go to Login/Create User page: </div>
        <asp:Button ID="memberButton" runat="server" OnClick="memberButton_Click" Text="Member" />
        <p>
            Go to Staff page (Admin):
        </p>
        <p>
            <asp:Button ID="staffButton" runat="server" Text="Staff" OnClick="staffButton_Click" />
        </p>
    <meta charset="utf-8" />
    <b id="docs-internal-guid-40580549-7fff-6a8d-b548-9fed1393475d" style="font-weight:normal;">
    <br />
    </b>
</asp:Content>

