<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroVentas.aspx.cs" Inherits="WebArticulo.Registros.RegistroVentas" %>

<asp:Content ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <p>
    <asp:Panel runat="server" class="panel-heading" CssClass="panel-heading" BackColor="#3399FF"><h1><stronge>Registro de Venta</stronge></h1></asp:Panel>
            </p>
    <div>
        <p>
            
            VentaId: <asp:TextBox ID="VentaIdTextBox" runat="server" TextMode="Number"></asp:TextBox>
            <asp:Button ID="BuscarButton" runat="server" Text="Buscar" />
        </p>
        <p>
            Fecha: 
            <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date"></asp:TextBox>
        </p>
    </div>

        <div>
            <p>
            Descripcion:
            <asp:TextBox ID="DescripcionTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
            </p>
        </div>

        <div>
            <p>
            Existencia:
            <asp:TextBox ID="ExistenciaTextBox" runat="server"></asp:TextBox>
            </p>
        </div>

    <div>
        <p>
           
        Precio: <asp:TextBox ID="PrecioTextBox" runat="server"></asp:TextBox>
        Cantidad:<asp:TextBox ID="CantidadTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
        </p>
    </div>

        <div>
            <p>
            Monto:<asp:TextBox ID="MontoTextBox" runat="server" ></asp:TextBox>
                </p>
        </div>

    <div>

        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click1" CssClass="btn-primary"  />
        &nbsp;&nbsp;
        <asp:Button ID="ModificarButton" runat="server" Text="Modificar" OnClick="ModificarButton_Click1" CssClass="btn-success" />
        &nbsp;&nbsp;
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click1" CssClass="btn-danger" />

    </div>
        
        <div>
            <p>
            <asp:GridView ID="VentasDetalleGridView" runat="server">
            </asp:GridView>
                </p>
        </div>
        </center>
</asp:Content>