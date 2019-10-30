<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="week2JR.Contacts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="width:40%; margin-left:30%; margin-top:2%;">
        <h1 style="text-align:center;">Apply now</h1>

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

          <div class="form-row" style="margin-top:2%">

                <div class="col">
                <asp:TextBox ID="State" class="form-control" placeholder="State" runat="server"></asp:TextBox>

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
      
         <div class="form-row" style="margin-top:2%">
          <div class="col">
              <asp:Button ID="Button1" class="btn btn-danger" runat="server" Text="Clear" OnClick="Button1_Click" />
              <asp:Button ID="Submit" class="btn btn-success" runat="server" Text="Submit" OnClick="Submit_Click" />

               </div>
          </div>

         <div class="form-row"> 
          
             <asp:Label ID="Output" runat="server" Text=""></asp:Label>



             </div>
 

</asp:Content>
