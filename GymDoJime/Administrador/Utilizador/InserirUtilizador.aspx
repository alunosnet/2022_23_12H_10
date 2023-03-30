<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="InserirUtilizador.aspx.cs" Inherits="GymDoJime.Administrador.Utilizador.InserirUtilizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvUtilizadores" runat="server" CsSClass="table"/>
    <h1>Registo</h1>
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
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbDataNascimento">Data Nascimento:</label>
            <asp:TextBox CssClass="form-control" ID="tbNascimento" AutoPostBack="true"  OnTextChanged="tbNascimento_TextChanged" runat="server" placeholder="Data de  Nascimento" TextMode="Date" /><br />
        </div>
         <div class="form-group" id="dIdade" runat="server">
            <label for="ContentPlaceHolder1_tbIdade">Idade:</label>
            <asp:TextBox CssClass="form-control"  ID="tbIdade" runat="server" ReadOnly="true" placeholder="Idade" /><br />
        </div>
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbEmail">Telefone:</label>
            <asp:TextBox CssClass="form-control" ID="tbtelefone" runat="server" placeholder="Telefone" /><br />
        </div>

        
        <div class="form-group">

            <label for="ContentPlaceHolder1_dpPerfil">nacionalidade:</label>
            <asp:DropDownList CssClass="form-select" ID="ddnacionalidade" runat="server">
            <asp:ListItem Text="" Value="0" />
            <asp:ListItem Text="Portuguesa" Value="1" />
            <asp:ListItem Text="Francesa" Value="2"/>
            <asp:ListItem Text="Ugandense" Value="3" />
            <asp:ListItem Text="Venezuelano" Value="4"/>
            <asp:ListItem Text="Zimbabuano" Value="5" />
            <asp:ListItem Text="Trinitino" Value="6"/>
            <asp:ListItem Text="Russo" Value="7" />
            <asp:ListItem Text="Inglês" Value="8"/>
            <asp:ListItem Text="Dominicano" Value="9" />
            <asp:ListItem Text="Paquistanês" Value="10"/>
            <asp:ListItem Text="Norueguês" Value="11" />
            <asp:ListItem Text="Nigeriano" Value="12"/>
            <asp:ListItem Text="Mexicano" Value="13" />
            <asp:ListItem Text="Luxemburguês" Value="14"/>
            <asp:ListItem Text="Libanês" Value="15" />
            <asp:ListItem Text="Italiano" Value="16"/>
            <asp:ListItem Text="Jamaicano" Value="17" />
            <asp:ListItem Text="Mauriciano" Value="18"/>
            <asp:ListItem Text="Húngaro" Value="19" />
            <asp:ListItem Text="Salomônico" Value="20"/>
        
             </asp:DropDownList><br />
        </div>
             <div class="form-group">

            <label for="ContentPlaceHolder1_dpGenero">Genero:</label>
            <asp:DropDownList CssClass="form-select" ID="dpGenero" runat="server">
            <asp:ListItem Text="" Value="" />
        
            <asp:ListItem Text="Masculino" Value="1"/>
            <asp:ListItem Text="Femenino" Value="2" />
        
             </asp:DropDownList><br />
        </div>
        
    <div class="form-group">

        <label for="ContentPlaceHolder1_dpPerfil">Perfil:</label>
        <asp:DropDownList CssClass="form-select" ID="dpPerfil" runat="server">
        <asp:ListItem Text="" Value="" />
        
        <asp:ListItem Text="Utilizador" Value="1"/>
        <asp:ListItem Text="Treinador" Value="2" />
        
         </asp:DropDownList><br />
    </div>
       
        <asp:Label runat="server" ID="lbErro"></asp:Label>
       <asp:Button runat="server" ID="btRegistar"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Registar" OnClick="btRegistar_Click"/>
                    
        <asp:Button runat="server" ID="btRecuperarPassword"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Recuperar Password"  OnClick="btRecuperarPassword_Click"/>
                    
    </div>
</asp:Content>
