<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="TrainadorUser.aspx.cs" Inherits="GymDoJime.Treinadores.TrainadorUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvAulasMarcadas" runat="server" CsSClass="table"/>
    
    <asp:Button runat="server" ID="btMarcar"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Marcar Aula" OnClick="btMarcar_Click"/>

    <asp:Button runat="server" ID="btnPresenca"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Folha de presenças" OnClick="btnPresenca_Click"/>


        
</asp:Content>
