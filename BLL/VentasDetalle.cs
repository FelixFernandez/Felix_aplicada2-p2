﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class VentasDetalle
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public VentasDetalle()
        {
            this.Id = 0;
            this.VentaId = 0;
            this.ArticuloId = 0;
            this.Cantidad = 0;
            this.Precio = 0f;
        }

        public VentasDetalle( int cantidad, float precio)
        {       
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
