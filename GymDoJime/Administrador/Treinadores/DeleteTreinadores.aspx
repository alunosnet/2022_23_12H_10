<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="DeleteTreinadores.aspx.cs" Inherits="GymDoJime.Administrador.Treinadores.DeleteTreinadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Editar</h1>
    <div runat="server" class="form-group" id="divLogin">
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbEmail">Email:</label>
            <asp:TextBox CssClass="form-control" ID="tbEmail" runat="server" placeholder="Email" TextMode="Email" /><br />
        </div>
    
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbNome">Password:</label>
            <asp:TextBox CssClass="form-control" ID="tbpassword" runat="server"  placeholder="Password" /><br />
        </div>
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbCC">CC:</label>
            <asp:TextBox CssClass="form-control" ID="tbCC" runat="server" placeholder="Cartão de Cidadão" /><br />
        </div>
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbNome">Nome:</label>
            <asp:TextBox CssClass="form-control" ID="tbnome" runat="server" placeholder="Nome" /><br />
        </div>
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbnif">nif:</label>
            <asp:TextBox CssClass="form-control" ID="tbnif" runat="server" placeholder="Numero de Identificação Fiscal"  /><br />
        </div>
        
       
        <asp:Label runat="server" ID="lbErro"></asp:Label>
      <asp:Button CssClass="btn btn-lg btn-danger" runat="server" ID="btRemover" Text="Remover" OnClick="btRemover_Click"/>
    <asp:Button CssClass="btn btn-lg btn-info" runat="server" ID="btVoltar" Text="Voltar" OnClick="btVoltar_Click"/>
        
                    
    </div>
</asp:Content>
