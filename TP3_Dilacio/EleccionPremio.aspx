﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP3_Dilacio.EleccionPremio" %>

<asp:Content ID="Premio" ContentPlaceHolderID="cuerpo" runat="server">
    <br />
    <div class="form-group">
        <h1 align="center">Elegí tu premio</h1>
    </div>

    <div class="card-columns" style="margin-left: 300px; margin-right: 300px;">

        <% foreach (var item in ListaProductos)
            { %>

        <div class="card">
            <img src="<% = item.URLImagen%>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.Titulo %></h5>
                <p class="card-text"><% = item.Descripcion %></p>
                <a href="IngresoDatos.aspx?ValorProducto=<%=item.ID.ToString()%>" class="btn btn-danger" >Seleccionar</a>
            </div>
            <%--<div style="text-align:center;">  <asp:Button ID="BtnNext" CssClass="btn alert-primary" runat="server" Text="Siguiente" OnClick="Btn_Siguiente" /></div>--%>
        </div>
        <% } %>
    </div>

</asp:Content>
