using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Articulos : ClaseMaestra
    {
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Precio { get; set; }

        public Articulos()
        {
            this.ArticuloId = 0;
            this.Descripcion = "";
            this.Existencia = 0;
            this.Precio = 0f;
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                conexion.ObtenerDatos(string.Format("insert into Articulos(ArticuloId, Descripcion, Existencia, Precio) Values('" + this.ArticuloId + "','" + this.Descripcion + "','" + this.Existencia + "','"+this.Precio+ "')Select @@Identity"));
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;

        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;

            try
            {
                retorno = conexion.Ejecutar(string.Format("update Articulos set Descripcion'{0}', Existencia={1}, Precio={3}) where ArticuloId={2}", this.Descripcion, this.Existencia, this.Precio, this.ArticuloId));
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            retorno = conexion.Ejecutar(string.Format("Delete from Articulos where ArticuloId =" + this.ArticuloId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();

            try
            {
                dt = conexion.ObtenerDatos("select * from Articulos where ArticuloId = " + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    ArticuloId = (int)dt.Rows[0]["VentaId"];
                    Descripcion = dt.Rows[0]["Fecha"].ToString();
                    Existencia = (int)dt.Rows[0]["Existencia"];
                    Precio = (float)dt.Rows[0]["Monto"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();

            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;
            return conexion.ObtenerDatos("Select " + Campos + " From Articulos Where " + Condicion + Orden);
        }
    }

}
