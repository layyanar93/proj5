<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Maroon" Text="Recipe Vault"></asp:Label>

        <div dir="ltr" style="font-family: Calibri">
            This application is a recipe storage application, where user can sign up to securely store their recipes in one place.<br />
            <br />
            <br />
            The following functionality is offered: <br />
            1) If general user, click &quot;Member&quot; button to be redirected to the Login/Create user page.<br />
            2) If admin user, click &quot;Staff&quot; button to be redirected to the staff page.<br />
            3) Once user is created, username/password (encrypted) will be stored in a .xml file called members.xml, in the App_Data folder. Next time, user will click login and use the same username/password to be able to retrieve/save their recipes.<br />
&nbsp;&nbsp;&nbsp; - <strong>Testing:</strong> sign up as new user, and then logout and login with previously created username/password.
            <br />
&nbsp;&nbsp;&nbsp; - <strong>Testing:</strong> To verify authentication service works, attempt to log in with an incorrect password.
            <br />
&nbsp;&nbsp;&nbsp; - <strong>Testing: </strong>To verify encryption/decryption works, use the textbox below to encrypt/decrypt a string. Alternatively, after creating username/password, check the members.xml file to ensure password is stored encrypted. <br />
            4)&nbsp; Staff Page: This is an adminstrative page where staff members can add other staff members to the application, and also remove members from the members.xml file to revoke access.<br />
&nbsp;&nbsp;&nbsp; ( username : &quot;TA&quot;, password : &quot;Cse445ta!&quot; has already been added to staff.xml )<br />
&nbsp;&nbsp;&nbsp;&nbsp; <strong>- Testing: </strong>To verify staff members can be added, add the username/password for new staff and login as that staff member upon new session. Alternatively, you can check the staff.xml file to see if username/password was recorded.<br />
&nbsp;&nbsp;&nbsp; - <strong>Testing:</strong> To verify remove member functionality, input a username to remove and then verify that it is removed from the members.xml file. <br />
            5) User can type recipe in textbox to save in secure storage service.
            <br />
            <strong>&nbsp;&nbsp;&nbsp; - Testing:</strong> To verify Save functionality works, type a recipe (string) into text box. Click &quot;Save&quot;. Logout or restart and Log back into application, then click &quot;Retrieve&quot; to verify the previously saved string is shown. Alternatively, check the recipes.xml file to see if the new data was saved.
            <br />
            6) User can click &quot;Retrieve&quot; to display all the recipes previously saved to the account. <br />
&nbsp;&nbsp;&nbsp; -<strong>Testing:</strong> After logging in as user (not staff), click &quot;retrieve&quot; and make sure your recipes appear on the screen.<br />
            7) User can click &quot;Download&quot; to download recipes that have previously been saved.&nbsp; (browser control)<br />
&nbsp;&nbsp;&nbsp; -<strong>Testing: </strong>After logging in as user (not staff), click &quot;retrieve&quot; then &quot;download&quot; and verify all of your recipes have been downloaded to file.
            <br />
            <br />
            <br />
            Go to Login/Create User page: </div>
        <asp:Button ID="memberButton" runat="server" OnClick="memberButton_Click" Text="Member" Font-Names="Calibri" />
        <p style="font-family: Calibri">
            Go to Staff page (Admin):
        </p>
        <p>
            <asp:Button ID="staffButton" runat="server" Text="Staff" OnClick="staffButton_Click" Font-Names="Calibri" />
        </p>
    <meta charset="utf-8" />
    <b id="docs-internal-guid-40580549-7fff-6a8d-b548-9fed1393475d" style="font-weight:normal; font-family: Calibri;">
    <br />
    <strong>Encrypt/Decrypt Service Test</strong><br />
    Type a string below to encrypt or decrypt:<br />
    <asp:TextBox ID="TextBox1" runat="server" Width="312px" Height="82px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="encryptButton" runat="server" OnClick="encryptButton_Click" Text="Encrypt" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="decryptButton" runat="server" OnClick="decryptButton_Click" Text="Decrypt" />
    <br />
    <br />
    <table border="1" cellpadding="0" cellspacing="0" style="border-style: none; border-color: inherit; border-width: medium; border-collapse: collapse; mso-table-layout-alt: fixed; mso-border-alt: solid black 1.0pt; mso-yfti-tbllook: 1536; mso-padding-alt: 0in 5.4pt 0in 5.4pt; mso-border-insideh: 1.0pt solid black; mso-border-insidev: 1.0pt solid black; line-height: 107%; font-size: 11.0pt; font-family: Calibri, sans-serif;" width="0">
        <tr>
            <td colspan="4" valign="top" width="659">
                <p align="center" class="MsoNormal">
                    <b><span lang="EN">Application and Components Summary Table<o:p></o:p></span></b></p>
            </td>
        </tr>
        <tr>
            <td colspan="4" valign="top" width="659">
                <p class="MsoNormal">
                    <span lang="EN">The application is deployed at: http://webstrar64.fulton.asu.edu/page1/default.aspx<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td colspan="4" valign="top" width="659">
                <p class="MsoNormal">
                    <span lang="EN">Percentage of contribution: Chance Engstrom : 50% Lohitha Ayyanar: 50%<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Provider Name<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <span lang="EN">Page and component type, e.g., aspx, DLL, SVC, etc. <o:p></o:p></span>
                </p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <span lang="EN">Component Description: What does the component do? Input/output values?<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Actual resources and methods used to implement the component and where this component is used.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">svc</span></b><span lang="EN"><o:p></o:p></span></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Authentication service:</span></b><span lang="EN"> User enters their username (string) and password (string) and is redirected if authentication check in members.xml is successful<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">svc</span></b><span lang="EN"> <b><o:p></o:p></b></span>
                </p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Login service:</span></b><span lang="EN"> User logs in by entering their username (string) and password (string). It’s then passed to authentication service to complete login. <o:p></o:p></span>
                </p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">svc<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Create user service:</span></b><span lang="EN"> User creates a login with their username (string) and password (string) and completes image verifier, to create a password which is stored in members.xml<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">XML files<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Members.xml</span></b><span lang="EN"> to store member login information: username and encrypted password<o:p></o:p></span></p>
                <p class="MsoNormal">
                    <b><span lang="EN">Staff.xml</span></b><span lang="EN"> to store staff login and encrypted password.<o:p></o:p></span></p>
                <p class="MsoNormal">
                    <b><span lang="EN">Recipes.xml</span></b><span lang="EN"> to store the encrypted recipe under each user.<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">-Members.xml stores usernames/passwords (encrypted)<o:p></o:p></span></p>
                <p class="MsoNormal">
                    <span lang="EN">-Staff.xml stores staff username/passwords (encrypted<o:p></o:p></span></p>
                <p class="MsoNormal">
                    <span lang="EN">-Recipes.xml stores the recipes (encrypted) under each member’s username<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">svc</span></b><span lang="EN"><o:p></o:p></span></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Storage service:</span></b><span lang="EN"> user can either input recipe (string) to store in recipe.xml, OR print recipes to screen <o:p></o:p></span>
                </p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">svc</span></b><span lang="EN"><o:p></o:p></span></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">View User Credentials:</span></b><span lang="EN"> Staff can view the member.xml as an admin action.<u><span><o:p></o:p></span></u></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">dll</span></b><span lang="EN"><o:p></o:p></span></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Encrypt/decrypt: </span></b><span lang="EN">password (string) will be encrypted before saved to xml file. Recipes (string) will be encrypted before saved to file. Recipes (string) will be decrypted <o:p></o:p>
                    </span>
                </p>
                <p class="MsoNormal">
                    <o:p>-tryIt for dll in Default.aspx</o:p></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code<o:p></o:p></span></p>
                <p class="MsoNormal">
                    <span lang="EN">With the C# standard cryptography lib<span>&nbsp; </span>and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">svc<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Image Verifier:</span></b><span lang="EN"> User needs to complete the image verifier to create user <u><span><o:p></o:p></span></u></span>
                </p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">cookies<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Cookies/Session var:</span></b><span lang="EN"> Variables needed to keep user logged in and session information.<u><span><o:p></o:p></span></u></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">HTTP cookie library, linked to login page. <o:p></o:p></span>
                </p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">Server control<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Download recipes: </span></b><span lang="EN">User can download their recipes from the application. Input value: string path to save file. Output is xml file. <span>&nbsp;</span><o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">Aspx page and server control<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Staff page: </span></b><span lang="EN">this is the administrative page, where staff can add other staff members to the staff.xml file, and remove members from the member.xml file.<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">GUI design and C# code behind GUI. <o:p></o:p></span>
                </p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">Aspx page and server control<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Member page: </span></b><span lang="EN">this is the page where members can save, view or download their recipes.<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">GUI design and C# code behind GUI.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">Aspx page and server control<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Login page: </span></b><span lang="EN">this is the page where members can create a user or existing members can log in.<o:p></o:p></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">GUI design and C# code behind GUI.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Chance Engstrom<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">Aspx page and server control<o:p></o:p></span></b></p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Default page: </span></b><span lang="EN">public default page that call and link login page and staff page<b><o:p></o:p></b></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">GUI design and C# code behind GUI.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td valign="top" width="124">
                <p class="MsoNormal">
                    <span lang="EN">Lohitha Ayyanar<o:p></o:p></span></p>
            </td>
            <td valign="top" width="109">
                <p class="MsoNormal">
                    <b><span lang="EN">Global.asax <o:p></o:p></span></b>
                </p>
            </td>
            <td valign="top" width="192">
                <p class="MsoNormal">
                    <b><span lang="EN">Number of visitors: </span></b><span lang="EN">Counts number of visitors to the page.<b><o:p></o:p></b></span></p>
            </td>
            <td valign="top" width="234">
                <p class="MsoNormal">
                    <span lang="EN">Write my own code and use ASU server<o:p></o:p></span></p>
            </td>
        </tr>
    </table>
    <p class="MsoNormal">
        <span lang="EN"><o:p>&nbsp;</o:p></span></p>
    </b>
</asp:Content>

