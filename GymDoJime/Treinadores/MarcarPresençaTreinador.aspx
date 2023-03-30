<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="MarcarPresençaTreinador.aspx.cs" Inherits="GymDoJime.Treinadores.MarcarPresençaTreinador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvAulasPresenças" runat="server" CsSClass="table"/>
    <h2>Marcar Presença</h2>
    <div class="form-group">

           
        AUlas: <asp:DropDownList runat="server" ID="dpAulas"></asp:DropDownList>
    </div>

    <div class="form-group">

           Utilizadores: <asp:DropDownList runat="server" ID="dputilizadores"></asp:DropDownList>
    </div>

    <div class="form-group">
        <asp:CheckBox runat="server" ID="chPresença" Text ="Presente" />

    </div>

    <asp:Button runat="server" ID="btMarcar"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Marcar" OnClick="btMarcar_Click" />


    <asp:Label runat="server" ID="lbErro"></asp:Label>

</asp:Content>
