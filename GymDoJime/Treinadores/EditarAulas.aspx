<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="EditarAulas.aspx.cs" Inherits="GymDoJime.Treinadores.EditarAulas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server" class="form-group" id="divLogin">
        <h1>Marcar Aula</h1>
        <div class="form-group">
            <label for="ContentPlaceHolder1_tbDataHora">DataHora:</label>
            <asp:TextBox CssClass="form-control" ID="tbData" runat="server" placeholder="Email" TextMode="Date" /><br />
        </div>
    
        <div class="form-group">

            <label for="ContentPlaceHolder1_dpSala">Sala:</label>
            <asp:DropDownList CssClass="form-select" ID="dpSala" runat="server">
            <asp:ListItem Text="" Value="0" />
            <asp:ListItem Text="Sala 1" Value="1" />
            <asp:ListItem Text="Sala 2" Value="2"/>
            <asp:ListItem Text="Sala 3" Value="3" />
            <asp:ListItem Text="Sala 4" Value="4"/>
            <asp:ListItem Text="Sala 5" Value="5" />
            <asp:ListItem Text="Sala 6" Value="6"/>
            <asp:ListItem Text="Sala 7" Value="7" />
            <asp:ListItem Text="Sala 8" Value="8"/>
            <asp:ListItem Text="Sala 9" Value="9" />
           
        
             </asp:DropDownList><br />
        </div>
        <div class="form-group">

            <label for="ContentPlaceHolder1_dpTreino">Tipo de Treino:</label>
            <asp:DropDownList CssClass="form-select" ID="dpTreino" runat="server">
            <asp:ListItem Text="" Value="0" />
            <asp:ListItem Text="Musculação" Value="1" />
            <asp:ListItem Text="Dança" Value="2"/>
             </asp:DropDownList><br />
        </div>

        <div class="form-group">

            <label for="ContentPlaceHolder1_dpAula">Aula:</label>
            <asp:DropDownList CssClass="form-select" ID="dpAula" runat="server">
            <asp:ListItem Text="" Value="0" />
            <asp:ListItem Text="Privada" Value="1" />
            <asp:ListItem Text="Publica" Value="2"/>
             </asp:DropDownList><br />
        </div>

        <div>
            <label for="ContentPlaceHolder1_dpNomeTreinador">ID Treinador</label>
            <asp:TextBox CssClass="form-control" ID="tbIDTreinador" runat="server" ReadOnly="true" ></asp:TextBox>

        </div>

        <asp:Label runat="server" ID="lbErro"></asp:Label>
         <asp:Button runat="server" ID="btMarcar"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Atualizar Aula" OnClick="btMarcar_Click"/>
                    
        <asp:Button runat="server" ID="btVoltar"
                        CssClass="btn btn-outline-primary float-right"
                        Text="Voltar"  OnClick="btVoltar_Click"/>
    </div>
</asp:Content>
