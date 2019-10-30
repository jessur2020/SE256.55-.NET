<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Class2ExampleWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div class="text-center" style="margin-top:2%;">
        <h1>Welcome to New England Institute of Technology's Home Page</h1>
        <img src="App_Themes/Images/index.jpg" class="img-fluid rounded embed-responsive" style="width:80%;margin-left:10%;"/>
        <h4><a href="About.aspx">Learn</a> More about our school or <a href="Contact.aspx">Apply</a> Now!</h4>
    </div>
</asp:Content>
