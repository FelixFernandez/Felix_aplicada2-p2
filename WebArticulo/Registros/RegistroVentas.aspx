<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroVentas.aspx.cs" Inherits="WebArticulo.Registros.RegistroVentas" %>

<asp:Content ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
        }
    </style>

</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset class="panel-primary">

      <center> <legend> <h1> Registro De Ventas</h1></legend></center>
       
         <div style="margin-left: 500px">
            
                VentaId: <asp:TextBox  ID="VentaIdTextBox" runat="server" TextMode="Number" Width="150px"></asp:TextBox>
                <asp:Button ID="BuscarButton" runat="server" Text="Buscar" BackColor="Gray" BorderStyle="None" ForeColor="White" OnClick="BuscarButton_Click" />
            
        </div>
        
        <label></label>

        <div style="margin-left: 509px">
            
                Fecha: <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date" Width="150px"></asp:TextBox>
            
        </div>

        <label></label>


        <div style="margin-left: 509px">
            Precio: <asp:TextBox ID="PrecioTextBox" runat="server" Width="150px"></asp:TextBox>
            &nbsp;Cantidad:<asp:TextBox ID="CantidadTextBox" runat="server" Width="150px"></asp:TextBox>
            <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" BackColor="#999999" BorderStyle="None" ForeColor="White" />
            
        </div>

        <label></label>

        <div style="margin-left: 509px">
            
            Monto: <asp:TextBox ID="MontoTextBox" runat="server" Width="372px" ></asp:TextBox>
            
        </div>

        <label></label>

        
        <div style="margin-left: 579px" >
            <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click1" CssClass="btn-primary" BorderStyle="None"  />
            &nbsp;&nbsp;
            <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevorButton_Click1" CssClass="btn-success" BorderStyle="None" />
            &nbsp;&nbsp;
            <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click1" CssClass="btn-danger" BorderStyle="None" />
        </div>
          

        <label></label>

        <div style="margin-left: 592px">
            
            <asp:GridView ID="VentasDetalleGridView" runat="server">
            </asp:GridView>
           
        </div>
        </fieldset>
</asp:Content>