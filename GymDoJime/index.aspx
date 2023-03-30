<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GymDoJime.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
    <div runat="server" class="form-group" id="divLogin">
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbEmail">Email:</label>
            <asp:TextBox CssClass="form-control" ID="tbEmail" runat="server" placeholder="Email" TextMode="Email" /><br />
        </div>
    
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbNome">Password:</label>
            <asp:TextBox CssClass="form-control" ID="tbpassword" runat="server"  placeholder="Password" /><br />
        </div>
        <asp:Label runat="server" ID="lbErro"></asp:Label>
        <asp:Button runat="server" ID="btLogin" Text="Login" OnClick="btLogin_Click"/>
        <asp:Button runat="server" ID="btRecuperar" Text="Recuperar Password" OnClick="btRecuperar_Click" /> 
        Não tem conta<asp:Button runat="server" class="form-control" id="btnRegistar" Text="Registar" OnClick="btnRegistar_Click"></asp:Button>
        
    </div>
    




</asp:Content>
