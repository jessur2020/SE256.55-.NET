<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ContentMgr.aspx.cs" Inherits="Lab2JR.Controls.ContentMgr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div style="width:80%; margin-left:10%;margin-top:2%;text-align:center;">
        <h1>Managger User</h1>
            <asp:button runat="server" ID="logout" class="btn btn-danger float-right" text="Log Out" OnClick="logout_Click" />
    </div>

</asp:Content>
