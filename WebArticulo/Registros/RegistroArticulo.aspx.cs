using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebArticulo.Registros
{
    public partial class RegistroArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LLenarCampos(Articulos articulos )
        {
            articulos.ArticuloId = int.Parse(ArticuloIdTextBox.Text);
            articulos.Descripcion = DescripcionTextBox.Text;
            articulos.Existencia = int.Parse(ExistenciaTextBox.Text);
            articulos.Precio = float.Parse(PrecioTextBox.Text);
        }

        public void Limpiar()
        {
            ArticuloIdTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            ExistenciaTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
        }

        private void MostrarCampos(Articulos articulos)
        {
            ArticuloIdTextBox.Text = articulos.ArticuloId.ToString();
            DescripcionTextBox.Text = articulos.Descripcion.ToString();
            ExistenciaTextBox.Text = articulos.Existencia.ToString();
            PrecioTextBox.Text = articulos.Precio.ToString();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.ArticuloId = int.Parse(ArticuloIdTextBox.Text);
            LLenarCampos(articulos);

            if (articulos.ArticuloId > 0)
            {
                articulos.Insertar();
                Response.Write("guardo");
                Limpiar();
            }
            else
            {
                Response.Write("no guardo");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.ArticuloId = int.Parse(ArticuloIdTextBox.Text);
          

            if (articulos.ArticuloId > 0)
            {
                articulos.Eliminar();
                Response.Write("se elimino");
                Limpiar();
            }
            else
            {
                Response.Write("no se elimino");
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.ArticuloId = int.Parse(ArticuloIdTextBox.Text);
           

            if (articulos.ArticuloId > 0)
            {
                articulos.Buscar(articulos.ArticuloId);
                MostrarCampos(articulos);
                Response.Write("Id  encontrado");
            }
            else
            {
                Response.Write("Id no encontrado");
                Limpiar();
            }
        }
    }
}