<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 341px;
            height: 174px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="cotarot">How sports affects our mood?</h1>
    <div class="move">
    <table border="0"  class="font">
        <tr>
            <td> <asp:Label ID="Label8" runat="server" CssClass="para" Text=""></asp:Label> </td>
        </tr>
        <tr>
            <td> <asp:Label ID="Label9" runat="server" CssClass="para" Text=""></asp:Label> </td>

        </tr>
         <tr>
            <td><img src="Reka/SportMood.jpg" class="auto-style1" /> </td>              
        </tr>
        <tr>
            <td><h2 class="cotarot">Improve Your Outlook</h2></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label10" runat="server" CssClass="para" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><h2 class="cotarot">Improve Your Anxiety</h2></td>
        </tr>
        <tr>
            <td> <asp:Label ID="Label11" runat="server" CssClass="para" Text=""></asp:Label></td>   
        </tr>
        <tr>
            <td><h2 class="cotarot">Improve Your Self-Perception</h2></td>
        </tr>
        <tr>
            <td> <asp:Label ID="Label12" runat="server" Text=""></asp:Label> </td>         
        </tr>
        <tr>
            <td><h2 class="cotarot">Improve Your Confidence</h2></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label13" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
        </div>
</asp:Content>
 