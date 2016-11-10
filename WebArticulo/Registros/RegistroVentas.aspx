<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroVentas.aspx.cs" Inherits="WebArticulo.Registros.RegistroVentas" %>

<asp:Content ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <h1>Registro de Ventas</h1>
    <div>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            VentaId: <asp:TextBox ID="VentaIdTextBox" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;<asp:Button ID="BuscarButton" runat="server" Text="Buscar" />
        </p>
        <p>
            Fecha:&nbsp;&nbsp; 
            <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date"></asp:TextBox>
        </p>
    </div>

    <div>
        <p>
            &nbsp;&nbsp;
            Monto:&nbsp;&nbsp; <asp:TextBox ID="MontoTextBox" runat="server" ></asp:TextBox>
        </p>
    </div>

    <div>

        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click1" CssClass="btn-primary"  />
        &nbsp;&nbsp;
        <asp:Button ID="ModificarButton" runat="server" Text="Modificar" OnClick="ModificarButton_Click1" CssClass="btn-success" />
        &nbsp;&nbsp;
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click1" CssClass="btn-danger" />

    </div>
        </center>
</asp:Content>