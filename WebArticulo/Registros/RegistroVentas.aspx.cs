using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace WebArticulo.Registros
{
    public partial class RegistroVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LLenarCampos(Ventas ventas)
        {
            ventas.VentaId = int.Parse(VentaIdTextBox.Text);
            ventas.Fecha = FechaTextBox.Text;
            ventas.Monto = float.Parse(MontoTextBox.Text);
        }

        public void Limpiar()
        {
            VentaIdTextBox.Text = string.Empty;
            FechaTextBox.Text = string.Empty;
            MontoTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
        }

        private void MostrarCampos(Ventas ventas)
        {
            VentaIdTextBox.Text = ventas.VentaId.ToString();
            FechaTextBox.Text = ventas.Fecha;
            MontoTextBox.Text = ventas.Monto.ToString();
        }

        protected void GuardarButton_Click1(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.VentaId = int.Parse(VentaIdTextBox.Text);
            LLenarCampos(ventas);

            if (ventas.VentaId > 0)
            {
                ventas.Insertar();
                Response.Write("guardo");
                Limpiar();
            }
            else
            {
                Response.Write("no guardo");
            }
        }

     

        protected void EliminarButton_Click1(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.VentaId = int.Parse(VentaIdTextBox.Text);


            if (ventas.VentaId > 0)
            {
                ventas.Eliminar();
                Response.Write("se elimino");
                Limpiar();
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

              VentasDetalle ventasdetalle = new VentasDetalle();
            
              ventasdetalle.Cantidad = int.Parse(CantidadTextBox.Text);
              ventasdetalle.Precio = float.Parse(PrecioTextBox.Text);

              ventas.AgregarVentasDetalle(ventasdetalle.Cantidad, ventasdetalle.Precio);

              Session["Ventas"] = ventas;

              VentasDetalleGridView.DataSource = ventas.Tipo;
              VentasDetalleGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();


            ventas.VentaId = int.Parse(VentaIdTextBox.Text);

                if (ventas.VentaId > 0)
                {
                    ventas.Buscar(ventas.VentaId);
                    MostrarCampos(ventas);
                    Response.Write("Id  encontrado");
            }
                else
                {
                    Response.Write("Id no encontrado");
                    Limpiar();
                }
            }

        protected void NuevorButton_Click1(object sender, EventArgs e)
        {
            Limpiar();
        }
    }

}