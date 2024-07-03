<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="loginregister_container">
        <br />
          <table border="0" align="center" class="LRfont">
          <tr>
                    <td colspan="2"> <asp:Image ID="maleandfemaleuser" CssClass="imgusers"  runat="server" ImageUrl="~/Reka/manwomeniconlp.png" Height="65px" Width="88px" /> </td>
          </tr>
          <tr>
                    <td colspan="2"><h1 class="lrcotarot">Sign up for free!</h1></td>
          </tr>   
          <tr>
                     <td>Email:</td>
                     <td><asp:TextBox ID="Email"  runat="server" placeholder="Enter Email"></asp:TextBox> </td>
          </tr>
          <tr>
                     <td>First Name: </td>
                     <td> <asp:TextBox ID="FirstName" runat="server" placeholder="Enter FirstName"></asp:TextBox> </td>
          </tr>
          <tr>
                     <td>Last Name: </td>
                     <td> <asp:TextBox ID="LastName" runat="server" placeholder="Enter LastName"></asp:TextBox> </td>
          </tr>
            
          <tr>
                     <td>Username:</td>
                     <td> <asp:TextBox ID="Username" runat="server" placeholder="Enter Username"></asp:TextBox></td>
          </tr>
          <tr>
                     <td>Password:</td>
                     <td> <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Enter Password"></asp:TextBox></td>
          </tr>
             
        </table>
        <br />
        <asp:Button ID="Registerbutton" CssClass="LRButtons" runat="server" Text="Register" OnClick="Registerbutton_Click" />
        <br />
        <br />
          <div class="MSG">
            <asp:Label ID="lblMsage" runat="server" Text="" ></asp:Label>
        </div>
        <p>Already have an BestOfSport account? <a href="Login.aspx">Sign In</a> </p>
        
    </div>
</asp:Content>

