<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 300px;
            width: 150px;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="cotarot">How sport affects the human body health?</h1>
    <div class="move">
    <table border="0" class="font">
      <tr>
          <td>  <asp:Label ID="Label1" runat="server" CssClass="para" Text=""></asp:Label> </td>
              
      </tr>
      <tr>
         <td><img src="Reka/menrunning.png" class="auto-style1" /></td>
      </tr>
      <tr>
          <td><h2 class="cotarot">Weight Maintenance</h2></td>     
      </tr>
      <tr>
          <td><asp:Label ID="Label2" runat="server" CssClass="para" Text=""></asp:Label> </td>
      </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" CssClass="para" Text=""></asp:Label></td>
        </tr>
      <tr>
          <td><h2 class="cotarot">Cardiorespiratory Health</h2></td>
      </tr>
      <tr>
          <td> <asp:Label ID="Label4" runat="server" CssClass="para" Text=""></asp:Label> </td>
      </tr>
        <tr>
            <td>  <asp:Label ID="Label5" runat="server" CssClass="para" Text=""></asp:Label></td>
        </tr>
      <tr>
          <td><h2 class="cotarot">Muscle and Bone Health</h2></td>
      </tr>
      <tr>
          <td><asp:Label ID="Label6" runat="server" CssClass="para" Text=""></asp:Label></td>
      </tr>
      <tr>
          <td><h2 class="cotarot">Psychological Health</h2></td>
      </tr>
      <tr>
          <td><asp:Label ID="Label7" runat="server" CssClass="para" Text=""></asp:Label></td>
      </tr>
  </table>
        </div>
</asp:Content>

