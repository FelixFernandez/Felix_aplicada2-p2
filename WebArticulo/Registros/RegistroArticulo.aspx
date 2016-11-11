<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroArticulo.aspx.cs" Inherits="WebArticulo.Registros.RegistroArticulo" %>



<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset class="panel-primary">
        <center><legend> <h1> Registro De Articulos</h1></legend></center>
       
         <div style="margin-left: 500px">
            
                ArticuloId: <asp:TextBox  ID="ArticuloIdTextBox" runat="server" TextMode="Number" Width="150px"></asp:TextBox>
                <asp:Button ID="BuscarButton" runat="server" Text="Buscar" BackColor="Gray" BorderStyle="None" ForeColor="White" OnClick="BuscarButton_Click" />
            
        </div>
        
        <label></label>

        <div style="margin-left: 483px">
            
                Descripcion: <asp:TextBox ID="DescripcionTextBox" runat="server" Width="150px"></asp:TextBox>
            
        </div>

        <label></label>

        <div style="margin-left: 493px">
            
            Existencia: <asp:TextBox ID="ExistenciaTextBox" runat="server" Width="150px" ></asp:TextBox>
            
        </div>

        <label></label>

        <div style="margin-left: 515px">
            Precio: <asp:TextBox ID="PrecioTextBox" runat="server" Width="150px"></asp:TextBox>
        </div>
      
        <label></label>

        
        <div style="margin-left: 535px" >
            <asp:Button ID="GuardarButton" runat="server" Text="Guardar"  CssClass="btn-primary" BorderStyle="None" OnClick="GuardarButton_Click"  />
            &nbsp;&nbsp;
            <asp:Button ID="NuevoButton" runat="server" Text="Nuevo"  CssClass="btn-success" BorderStyle="None" OnClick="NuevoButton_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="EliminarButton" runat="server" Text="Eliminar"  CssClass="btn-danger" BorderStyle="None" OnClick="EliminarButton_Click" />
        </div>
           
     </fieldset>
        

</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            margin-top: 0;
            margin-bottom: 0;
            font-size: xx-large;
            color: inherit;
        }
    </style>
</asp:Content>
