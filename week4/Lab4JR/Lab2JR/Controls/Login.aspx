<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab2JR.Controls.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <div style="width:40%;margin-left:30%;margin-top:2%;text-align:center;">
        <h1>Please login

        </h1>
        <div class="form-row" style="margin-top:2%">
            <asp:TextBox ID="UserName" placeholde="User Name" Class="form-control" style="text-align:center" runat="server"></asp:TextBox>
        </div>
            <div class="form-row" style="margin-top:2%">
                <asp:TextBox ID="Password"  placeholde="Password" Class="form-control" style="text-align:center" runat="server"></asp:TextBox>
        </div>
            <div class="form-row" style="margin-top:2%">
                <div class="col">
                <asp:Button ID="Submit" class="btn btn-success" runat="server" Text="login" OnClick="Submit_Click" />
                <asp:Button ID="Clear" class="btn btn-danger"  runat="server" Text="Clear" OnClick="Clear_Click" />
        </div>
                  </div>

    </div>


</asp:Content>
