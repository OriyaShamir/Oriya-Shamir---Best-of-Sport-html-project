<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminPanel.aspx.cs" Inherits="AdminPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" align="center" class="font" id="admintable">
       <tr>
            <td>
                 <h1 class="Adminpage">Website Users Table</h1>
                <asp:Label ID="UserTable" runat="server" Text="Label"></asp:Label> 
            </td>
    </table>
    <div></div>
</asp:Content>

