<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorVoucher.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP3_Dilacio.ErrorVoucher" %>

<asp:Content ID="ErrorVoucher" ContentPlaceHolderID="cuerpo" runat="server">

<div>
    <hr /><hr />
    <div style="text-align:center;"><h3>Usted Ingreso un voucher no valido por favor vuelva a ingresar Codigo Correcto</h3> </div>
    <hr />
    <div style="text-align:center;"><img  height="700" width="700" id="Img_Error" src="<% = "https://www.elegantthemes.com/blog/wp-content/uploads/2016/03/500-internal-server-error-featured-image-1.png"%>" class="img-fluid" alt="..."></div>
    <hr /><hr />
    <div style="text-align:center;">  <asp:Button ID="BtnNext" CssClass="btn alert-primary" runat="server" BorderStyle="Groove" Text="Siguiente" OnClick="Boton_Siguiente" /></div>
</div>
    
</asp:Content>

