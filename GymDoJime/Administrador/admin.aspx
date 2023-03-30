<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestra.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="GymDoJime.Administrador.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(document).ready(function () {
            $("#btnlista").on('click', function (e) {
                //alert("btn lista");
                e.preventDefault();
                $.ajax({
                    type: "POST",
                    url: "Servicos.asmx/ListaUtilizadores",
                    contentType: "application/json; charset=utf-8",
                    success: OnSuccess,
                    error: OnError
                });
                function OnError(response) {
                    alert("Alguma coisa errada correu mal");
                }
                function OnSuccess(response) {
                    alert(response.d);
                    var listaLivros = JSON.parse(response.d);
                    for (var i = 0; i < listaLivros.length; i++) {
                        $("#divLista").append(listaLivros[i].nome + "<br/>");
                    }
                }
            });
 
            $("#btnCriaGrafico").on('click', function (e) {
                //alert("btn gráfico");
                var pData = [];
                /*pData[0] = $("#ddlyear").val();*/
                var jsonData = JSON.stringify({ pData: pData });
 
                $.ajax({
                    type: "POST",
                    url: "Servicos.asmx/DadosUtilizadores",
                    data: jsonData,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: OnSuccess_,
                    error: OnErrorCall_
                });
                function OnSuccess_(response) {
                    var aData = response.d;
                    var arrLabels = [], arrSeries = [];
                    $.map(aData, function (item, index) {
                        arrLabels.push(item.perfil);
                        arrSeries.push(item.contagem);
                    });
                    var data = {
                        labels: arrLabels,
                        series: arrSeries
                    }
                    // This is themain part, where we set data and create PIE CHART
                    new Chartist.Pie('.ct-chart', data);
                }
 
                function OnErrorCall_(response) {
                    alert("Whoops something went wrong!");
                    console.log(response);
                }
                e.preventDefault();
            });
        });
    </script>
</asp:Content>
