<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Lab2JR.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="width: 80%; margin-left: 10%; margin-top: 2%;">
        <h1 style="text-align: center;">Sign up for our newsletter</h1>

        <div class="form-row" style="margin-top: 2%">

            <div class="col">
                <asp:RequiredFieldValidator ID="RequiredFielFname" runat="server" ControlToValidate="FirstName" SetFucusOnError="true" ErrorMessage="First Name Required"></asp:RequiredFieldValidator>
                <asp:TextBox ID="FirstName" class="form-control" placeholder="First Name" runat="server"></asp:TextBox>

            </div>

            <div class="col">
                <asp:RequiredFieldValidator ID="RequiredFielLname" runat="server" ControlToValidate="FirstName" SetFucusOnError="true" ErrorMessage="Last Name Required"></asp:RequiredFieldValidator>
                <asp:TextBox ID="LastName" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="form-row" style="margin-top: 2%">

            <div class="col">
                <asp:RequiredFieldValidator ID="RequiredFieldStreet1" runat="server" ControlToValidate="Street1" SetFucusOnError="true" ErrorMessage="Street1 Required"></asp:RequiredFieldValidator>
                <asp:TextBox ID="Street1" class="form-control" placeholder="Street1" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="form-row" style="margin-top: 2%">

            <div class="col">
                <asp:TextBox ID="Street2" class="form-control" placeholder="Street2" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:RequiredFieldValidator ID="RequiredFieldCity" runat="server" ControlToValidate="City" SetFucusOnError="true" ErrorMessage="City Required"></asp:RequiredFieldValidator>
                <asp:TextBox ID="City" class="form-control" placeholder="City" runat="server"></asp:TextBox>

            </div>



            <div class="col">
                <asp:RequiredFieldValidator ID="RequiredFieldState" runat="server" ControlToValidate="State" SetFucusOnError="true" ErrorMessage="State Required"></asp:RequiredFieldValidator>
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
                <asp:RequiredFieldValidator ID="RequiredFieldZip" runat="server" ControlToValidate="Zipcode" SetFucusOnError="true" ErrorMessage="Zip code Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionZip" runat="server" ErrorMessage="Enter valid zip code" ControlToValidate="ZipCode" ValidationExpression="^\d{5}$"></asp:RegularExpressionValidator>
                <asp:TextBox ID="ZipCode" class="form-control" placeholder="Zip Code" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="form-row" style="margin-top: 2%">
            <div class="col">
                <asp:RequiredFieldValidator ID="rfvEmial" runat="server" ControlToValidate="Email" SetFucusOnError="true" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ErrorMessage="Invalid Email Format"></asp:RegularExpressionValidator>
                <asp:TextBox ID="Email" class="form-control" placeholder="Email" runat="server"></asp:TextBox>

            </div>

            <div class="col">
                <asp:RequiredFieldValidator ID="RequiredFieldPhone" runat="server" ControlToValidate="PhoneNumber" SetFucusOnError="true" ErrorMessage="City Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid Phone number" ControlToValidate="PhoneNumber" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"></asp:RegularExpressionValidator>
                <asp:TextBox ID="PhoneNumber" class="form-control" placeholder="Phone Number" runat="server"></asp:TextBox>

            </div>
        </div>

        <div class="form-row" style="margin-top: 2%;">
            <div class="col">

                <asp:Button ID="Clear" class="btn btn-danger" runat="server" Text="Clear" OnClick="Clear_Click" />

                <asp:Button ID="Submit" class="btn btn-success" runat="server" Text="Submit" OnClick="Submit_Click" />

            </div>
        </div>

        <div class="form-row">

            <asp:Label ID="Output" runat="server" Text=""></asp:Label>



        </div>
    </div>







</asp:Content>
