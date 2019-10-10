<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorDNI.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP3_Dilacio.ErrorDNI" %>

<asp:Content ID="ErrorDNI" ContentPlaceHolderID="cuerpo" runat="server">

    <br /> <br /> <br />
    <div style="text-align:center;"> <h3>El Ingreso del DNi es obligatorio, por favor volver a ingresarlo</h3> </div>
    <div style="text-align:center;">  <asp:Button ID="BtnSiguiente" CssClass="btn alert-primary" runat="server" BorderStyle="Groove" Text="Volver" OnClick="Btn_VolverAlta" /></div>
    <br />

</asp:Content>
