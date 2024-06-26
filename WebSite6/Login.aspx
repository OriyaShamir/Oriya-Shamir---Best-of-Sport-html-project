<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="loginregister_container">
    <table border="0" align="center" class="LoginPosition" >
        <tr>
                <td colspan="2"> <asp:Image ID="maleandfemaleuser" CssClass="imgusers"  runat="server" ImageUrl="~/Reka/manwomeniconlp.png" Height="65px" Width="88px" /> </td>
        </tr>
          <tr>
                <td colspan="2" ><h1 class="lrcotarot">Sign In</h1></td>
          </tr>       
          <tr>
                <td>Username:</td>
                <td><asp:TextBox ID="TextUsername" runat="server" placeholder="Enter Username or Email"></asp:TextBox>       </td>
           
         </tr>
          <tr>
                <td>Password:</td>
                <td>     <asp:TextBox ID="TextPassword" runat="server" TextMode="Password" placeholder="Enter Password"></asp:TextBox>        </td>     
         </tr>  
        </table>
        <br />

        <asp:Button ID="LoginClick" CssClass="LRButtons" runat="server" Text="Sign In" OnClick="LoginClick_Click" />
         <div class="MSG">
            <asp:Label ID="lblMsage2" runat="server" Text="" ></asp:Label>
        </div>
         <p>Dont have an BestOfSport account? <a href="Register.aspx">Sign Up</a> </p>
        <br />
        <br />
        </div>
</asp:Content>

