<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SaveAndRetrieveTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        Print my recipes here:<br />
        enter username:
        <asp:TextBox ID="printTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="printButton" runat="server" OnClick="printButton_Click" Text="Print" />
        <br />
        <asp:Label ID="printedLabel" runat="server" Text="Label"></asp:Label>
    </div>
    <formView>
        <asp:Label ID="downloadLabel" runat="server" Text="download file:"></asp:Label>
        &nbsp;<br />
    Enter path to save file:
    <asp:TextBox ID="SaveTextBox" runat="server"></asp:TextBox>
    <br />
        <asp:Button ID="downloadButton" runat="server" OnClick="downloadButton_Click" Text="download" />
        <asp:Label ID="downloadResultLabel" runat="server" Text="downloadResult"></asp:Label>
    </formView>
    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                Enter Username here:
                <asp:TextBox ID="unameToAddTextbox" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                Enter text to save here:
            </p>
            <p>
                <asp:TextBox ID="toSaveTextBox" runat="server" Height="192px" Width="804px"></asp:TextBox>
&nbsp;<asp:Button ID="saveToXmlButton" runat="server" OnClick="saveToXmlButton_Click" Text="Save" />
                <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
