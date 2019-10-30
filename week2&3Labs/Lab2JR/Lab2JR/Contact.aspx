﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Lab2JR.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


         <div style="width: 80%; margin-left: 10%; margin-top: 2%;">
        <h1 style="text-align:center;">Sign up for our newsletter</h1>

        <div class="form-row" style="margin-top:2%">

            <div class="col">
                <asp:TextBox ID="FirstName" class="form-control" placeholder="First Name" runat="server"></asp:TextBox>

            </div>

              <div class="col">
                <asp:TextBox ID="LastName" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="form-row" style="margin-top:2%">
        
               <div class="col">
                <asp:TextBox ID="Street" class="form-control" placeholder="Street" runat="server"></asp:TextBox>

            </div>
            

                <div class="col">
                <asp:TextBox ID="City" class="form-control" placeholder="City" runat="server"></asp:TextBox>

            </div>
            </div>

           <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:TextBox ID="TextBox1" placeholder="City" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:DropDownList ID="State" CssClass="form-control" runat="server">
                    <asp:ListItem>AL</asp:ListItem>
                    <asp:ListItem>AK</asp:ListItem>
                    <asp:ListItem>AZ</asp:ListItem>
                    <asp:ListItem>AR</asp:ListItem>
                    <asp:ListItem>CA</asp:ListItem>
                    <asp:ListItem>CO</asp:ListItem>
                    <asp:ListItem>CT</asp:ListItem>
                    <asp:ListItem>DE</asp:ListItem>
                    <asp:ListItem>FL</asp:ListItem>
                    <asp:ListItem>GA</asp:ListItem>
                    <asp:ListItem>HI</asp:ListItem>
                    <asp:ListItem>ID</asp:ListItem>
                    <asp:ListItem>IL</asp:ListItem>
                    <asp:ListItem>IN</asp:ListItem>
                    <asp:ListItem>IA</asp:ListItem>
                    <asp:ListItem>KS</asp:ListItem>
                    <asp:ListItem>KY</asp:ListItem>
                    <asp:ListItem>LA</asp:ListItem>
                    <asp:ListItem>ME</asp:ListItem>
                    <asp:ListItem>MD</asp:ListItem>
                    <asp:ListItem>MA</asp:ListItem>
                    <asp:ListItem>MI</asp:ListItem>
                    <asp:ListItem>MN</asp:ListItem>
                    <asp:ListItem>MS</asp:ListItem>
                    <asp:ListItem>MO</asp:ListItem>
                    <asp:ListItem>MT</asp:ListItem>
                    <asp:ListItem>NE</asp:ListItem>
                    <asp:ListItem>NV</asp:ListItem>
                    <asp:ListItem>NH</asp:ListItem>
                    <asp:ListItem>NJ</asp:ListItem>
                    <asp:ListItem>NM</asp:ListItem>
                    <asp:ListItem>NY</asp:ListItem>
                    <asp:ListItem>NC</asp:ListItem>
                    <asp:ListItem>ND</asp:ListItem>
                    <asp:ListItem>OH</asp:ListItem>
                    <asp:ListItem>OK</asp:ListItem>
                    <asp:ListItem>OR</asp:ListItem>
                    <asp:ListItem>PA</asp:ListItem>
                    <asp:ListItem>RI</asp:ListItem>
                    <asp:ListItem>SC</asp:ListItem>
                    <asp:ListItem>SD</asp:ListItem>
                    <asp:ListItem>TN</asp:ListItem>
                    <asp:ListItem>TX</asp:ListItem>
                    <asp:ListItem>UT</asp:ListItem>
                    <asp:ListItem>VT</asp:ListItem>
                    <asp:ListItem>VA</asp:ListItem>
                    <asp:ListItem>WA</asp:ListItem>
                    <asp:ListItem>WV</asp:ListItem>
                    <asp:ListItem>WI</asp:ListItem>
                    <asp:ListItem>WY</asp:ListItem>
                </asp:DropDownList>
            </div>

                <div class="col">
                <asp:TextBox ID="ZipCode" class="form-control" placeholder="Zip Code" runat="server"></asp:TextBox>

            </div>
              </div>
           <div class="form-row" style="margin-top:2%">
                <div class="col">
                <asp:TextBox ID="Email" class="form-control" placeholder="Email" runat="server"></asp:TextBox>

            </div>

                <div class="col">
                <asp:TextBox ID="PhoneNumber" class="form-control" placeholder="Phone Number" runat="server"></asp:TextBox>

             </div>
        </div>

           <div class="form-row" style="margin-top: 2%;">
            <div class="col">

              <asp:Button ID="Clear"  class="btn btn-danger" runat="server" Text="Clear" OnClick="Clear_Click" />
       
              <asp:Button ID="Submit" class="btn btn-success" runat="server" Text="Submit" OnClick="Submit_Click" />

               </div>
                    </div>

         <div class="form-row"> 
          
             <asp:Label ID="Output" runat="server" Text=""></asp:Label>



             </div>
    </div>







</asp:Content>
