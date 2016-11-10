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
    }
}