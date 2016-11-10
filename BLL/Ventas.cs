using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Ventas : ClaseMaestra
    {
        public int VentaId { get; set; }
        public string Fecha { get; set; }
        public float Monto { get; set; }
        
        public Ventas()
        {
            this.VentaId = 0;
            this.Fecha = "";
            this.Monto = 0f;
        }


        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            retorno = conexion.Ejecutar(string.Format("insert into Ventas(VentaId, Fecha, Monto) Values('"+this.VentaId+"','"+this.Fecha+"','"+this.Monto+ "')Select @@Identity"));
            return retorno;
            
        }


    
        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            retorno = conexion.Ejecutar(string.Format("update Ventas set VentaId, Fecha, Monto) Values('" + this.VentaId + "','" + this.Fecha + "','" + this.Monto + "where VentaId =" +this.VentaId));
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            retorno = conexion.Ejecutar(string.Format("Delete from Ventas where VentaId ="+this.VentaId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();

            try
            {
                dt = conexion.ObtenerDatos("select * from Ventas where VentaId = " + this.VentaId);
                if (dt.Rows.Count > 0)
                {
                    VentaId = (int)dt.Rows[0]["VentaId"];
                    Fecha = dt.Rows[0]["Fecha"].ToString();
                    Monto = (float)dt.Rows[0]["Monto"];

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
            return conexion.ObtenerDatos("Select " + Campos + " From Ventas Where " + Condicion + Orden);
        }
    }
}

