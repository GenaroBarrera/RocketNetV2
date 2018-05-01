<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="RocketNetV2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>,</h2>
    <h3>If you dare.</h3>
    <address>
        One Team Rocket Way<br />
        Viridian City, Kanto <br />
        <abbr title="Phone">Phone:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@rocketnet.com">Support@rocketnet.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@rocketnet.com">Marketing@rocketnet.com</a>
    </address>
</asp:Content>
