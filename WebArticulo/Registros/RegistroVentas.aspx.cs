using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebArticulo.Registros
{
    public partial class RegistroVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void GuardarButton_Click1(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.VentaId =int.Parse(VentaIdTextBox.Text);
            ventas.Fecha = FechaTextBox.Text;
            ventas.Monto = float.Parse(MontoTextBox.Text);

            if (ventas.VentaId > 0)
            {
                ventas.Insertar();
                Response.Write("guardo");
            }
            else
            {
                Response.Write("no guardo");
            }
        }

        protected void ModificarButton_Click1(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.VentaId = Convert.ToInt32(VentaIdTextBox.Text);
            

            if (ventas.VentaId > 0)
            {
                ventas.Editar();
                Response.Write("se modifico");
            }
            else
            {
                Response.Write("no se modifico");
            }
        }

        protected void EliminarButton_Click1(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.VentaId = Convert.ToInt32(VentaIdTextBox.Text);


            if (ventas.VentaId > 0)
            {
                ventas.Eliminar();
                Response.Write("se elimino");
            }
            else
            {
                Response.Write("no se elimino");
            }
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            Ventas ventas;

            if (Session["Ventas"] == null)
                Session["Ventas"] = new Ventas();
            ventas = (Ventas)Session["Ventas"];

            VentasDetalle ventasdestalle = new VentasDetalle();

            ventasdestalle.VentaId = int.Parse(VentaIdTextBox.Text);
            ventasdestalle.Cantidad = int.Parse(CantidadTextBox.Text);
            ventasdestalle.Precio = float.Parse(PrecioTextBox.Text);

            ventas.AgregarVentasDetalle(ventasdestalle.Id, ventasdestalle.VentaId, ventasdestalle.ArticuloId, ventasdestalle.Cantidad, ventasdestalle.Precio);

            Session["Ventas"] = ventas;

            VentasDetalleGridView.DataSource = ventas.Tipo;
            VentasDetalleGridView.DataBind();
        }
    }
}