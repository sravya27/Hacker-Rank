<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="YourPlace.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Login for More Options</h3><p>
    Username&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

<br />
        <br />


    Password &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
    <p>

    <asp:Button ID="Button1" runat="server" Text="Login" />
</p>
    <h3>New User ? Register Here&nbsp;</h3>
    Email &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <br />
    Re-type Password&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Register" />
    <br />
</asp:Content>
