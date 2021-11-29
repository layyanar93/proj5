<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="memberPage.aspx.cs" Inherits="SaveAndRetrieveTryIt.memberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<title></title>
        <h1 style="font-family: 'Arial Unicode MS'; background-color: #FFFFFF; color: #800000;">sRecipe Vault</h1>
</head>
        <body>
            <form id="form1" runat="server" style="font-family: Calibri; width: 619px;">
                <div>
            <asp:Label ID="Label2" runat="server" Text="Welcome"></asp:Label>
        </div>
                <p>
                    Add new recipe to vault:
                </p>
                <p style="width: 324px">
                    <asp:TextBox ID="saveTextBox" runat="server" Height="240px" Width="305px" TextMode="MultiLine"></asp:TextBox>
&nbsp;<asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="saveLabel" runat="server"></asp:Label>
                </p>
                <p>
                    &nbsp;</p>
                <p>
                    Retrieve your recipes:
                </p>
                <asp:Button ID="RButton" runat="server" OnClick="RButton_Click" Text="Retrieve" />
                <br />
                <asp:Label ID="printLabel" runat="server" Text="Print Result"></asp:Label>
                <br />
                <br />
                <br />
                Download your recipes:
                <br />
                Enter download location:
                <asp:TextBox ID="downloadTextBox" runat="server" Width="360px">e.g.  C:\Users\John\source\examples\Recipes\</asp:TextBox>
                <br />
                <asp:Button ID="downloadButton" runat="server" OnClick="downloadButton_Click" Text="Download" />
                <br />
                <br />
                Search the web for a new recipe:
                <br />
                Type key words here:
                <asp:TextBox ID="keywordsTextBox" runat="server" Width="388px"></asp:TextBox>
                <asp:Button ID="searchButton" runat="server" Text="Search" />
                <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink">
</asp:BulletedList>
    </form>
</body>
</html>
