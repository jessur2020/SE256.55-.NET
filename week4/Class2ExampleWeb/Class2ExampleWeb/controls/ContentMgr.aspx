<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ContentMgr.aspx.cs" Inherits="Class2ExampleWeb.controls.ContentMgr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="width:80%; margin-top:2%; margin-left:10%;text-align:center">
        <h1>Manage Users</h1>
        <asp:button runat="server" ID="logout" class="btn btn-danger float-right" text="Log Out" OnClick="logout_Click" />
    </div>
    <div style="width:80%; margin-top:2%; margin-left:10%">
        <asp:Table ID="Table1" class="table table-bordered table-hover" runat="server">
            <asp:TableHeaderRow>
                <asp:TableCell>First Name</asp:TableCell>
                <asp:TableCell>Last Name</asp:TableCell>
                <asp:TableCell>Street 1</asp:TableCell>
                <asp:TableCell>Street 2</asp:TableCell>
                <asp:TableCell>City</asp:TableCell>
                <asp:TableCell>State</asp:TableCell>
                <asp:TableCell>Zip</asp:TableCell>
                <asp:TableCell>Email</asp:TableCell>
                <asp:TableCell>Phone</asp:TableCell>
                <asp:TableCell>Edit</asp:TableCell>
                <asp:TableCell>Delete</asp:TableCell>
            </asp:TableHeaderRow> 
        </asp:Table>
    </div>
</asp:Content>
