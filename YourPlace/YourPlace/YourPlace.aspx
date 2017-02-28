<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="YourPlace.aspx.cs" Inherits="YourPlace.YourPlace1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Search for the right place !!</h2>

    <p>
        Category&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>
        Location&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;&nbsp; </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click"  />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:GridView ID="GridView1" runat="server" >
    </asp:GridView>
</asp:Content>
