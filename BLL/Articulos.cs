using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Articulos
    {
        public int Articulo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public float Precio { get; set; }

        public Articulos()
        {
            this.Articulo = 0;
            this.Descripcion = "";
            this.Existencia = 0;
            this.Precio = 0f;
        }

      
    }

}
