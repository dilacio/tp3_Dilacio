
<%@ Page Title="Voucher" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"  CodeBehind="Index.aspx.cs" Inherits="TP3_Dilacio.Index" %>

<asp:Content ID="voucher" ContentPlaceHolderID="cuerpo" runat="server">
<div>
</div>
<div>
    <hr />
    <h4 align="center"  class="alert-heading">Ingresa el codigo de tu voucher!</h4> 
    <br />
    <div style="text-align:center;" > <asp:TextBox runat="server" align="center" ID="txbIngresoVoucher" width="550px" placeholder="XXXXXXXXXXXXXXXXXXXXXXXX"></asp:TextBox></div>
    <br />
    
    <div style="text-align:center;">  
        <asp:Button ID="BtnSiguiente" CssClass="btn alert-primary" runat="server" BorderStyle="Groove" Text="Siguiente" OnClick="Btn_Siguiente" />

    </div>
</div>
</asp:Content>