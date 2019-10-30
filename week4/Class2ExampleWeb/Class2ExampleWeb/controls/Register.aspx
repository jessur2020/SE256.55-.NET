﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Class2ExampleWeb.controls.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <div style="width:50%;margin-left:25%;margin-top:2%;text-align:center">
        <h1>Please Register</h1>
        <div class="form-row" style="margin-top:2%">
            <asp:Label ID="ErrorLabel" runat="server" Text="Database error" style="margin:auto" CssClass="alert alert-danger" Visible="false"></asp:Label>
             <asp:Label ID="SuccessLabel" runat="server" Text="User Added" style="margin:auto" CssClass="alert alert-success" Visible="false"></asp:Label>
        </div>
        <div class="form-row" style="margin-top:2%">
            <asp:textbox runat="server" ID="UserName" class="form-control" style="text-align:center" placeholder="User Name"></asp:textbox>
        </div>
        <div class="form-row" style="margin-top:2%">
            <asp:textbox runat="server" ID="password" class="form-control" style="text-align:center" placeholder="Password"></asp:textbox>
        </div>
        <div class="form-row" style="margin-top:2%">
            <p>have an Account? <a href="../controls/Login.aspx">Login</a> Now!</p>    
        </div>
        <div class="form-row" style="margin-top:2%">
            <asp:button runat="server" class="btn btn-success" ID="submit" text="Register" OnClick="submit_Click" />
            <asp:button runat="server" class="btn btn-danger" ID="clear" text="Clear" OnClick="clear_Click" />
        </div>
    </div>


</asp:Content>
