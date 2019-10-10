<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoDatos.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="TP3_Dilacio.IngresoDatos" %>

<asp:Content ID="IngresoDatos" ContentPlaceHolderID="cuerpo" runat="server">

    <script language="javascript" type="text/javascript">
        function ValidNum() {
            if (event.keyCode < 48 || event.keyCode > 57) {
                event.returnValue = false;
            }
        }

    </script>
    <br />
    <hr />
    <br />
    <div style="margin-left: 180px">
        <h3>Ingrese Datos</h3>
        <br />
        <h5 style="color: gray">DNI</h5>
    </div>
    <div style="margin-left: 180px">
        <asp:TextBox runat="server" Width="200px" placeholder="12333444" ID="txbDNI"></asp:TextBox>
        <asp:Button ID="BtnBuscar" CssClass="btn alert-primary" runat="server" BorderStyle="Groove" Text="Buscar" OnClick="Btn_BuscaDNI" />
        <br />

    </div>
    <div style="margin-left: 180px">
        <table>
            <tr>
                <td width="300px">
                    <h5 style="color: gray">Nombre</h5>
                    <asp:TextBox runat="server" align="center" ID="txbNombre" Width="250px" placeholder="Juancito"></asp:TextBox>
                </td>
                <td width="300px">
                    <h5 style="color: gray">Apellido</h5>
                    <asp:TextBox runat="server" align="center" ID="TxbApellido" Width="250px" placeholder="Perez"></asp:TextBox>
                </td>
                <td width="300px">
                    <h5 style="color: gray">Email</h5>
                    <div>
                        <asp:TextBox runat="server" align="center" ID="txbEmail"  Width="250px" placeholder="email@email.com"></asp:TextBox>
                    </div>
                </td>
            </tr>
            <tr>
                <td width="300px">
                    <h5 style="color: gray">Direccion</h5>
                    <asp:TextBox BorderStyle="Inset" runat="server" align="center" ID="txbDireccion" Width="250px" placeholder="Calle 123"></asp:TextBox></td>
                <td width="300px">
                    <h5 style="color: gray">Ciudad</h5>
                    <asp:TextBox runat="server" align="center" ID="txbCiudad" Width="250px" placeholder="Mi Ciudad"></asp:TextBox></td>
                <td width="300px">
                    <h5 style="color: gray">CP</h5>
                    <asp:TextBox runat="server" align="center" ID="txbCP" Width="250px" placeholder="XXXX"></asp:TextBox></td>
            </tr>
        </table>
    </div>
    <br />
    <div class="form-check" style="margin-left: 180px">
        <asp:CheckBox ID="checkTerminos" runat="server" class="form-check-label" for="gridCheck" />
        <label class="form-check-label" for="gridCheck">Acepto los términos y condiciones</label>
    </div>

    <br />
    <asp:Button class="btn btn-primary" ID="btnParticipar" runat="server" Text="Participar!" OnClick="Participar" Style="margin-left: 300px" />

</asp:Content>
