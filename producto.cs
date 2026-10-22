using System;
using System.Collections.Generic;
using System.Text;

namespace cafeteria
{
    public class Producto 
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario {  get; set; }

        public Producto (string nombre, decimal precioUnitario) 
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
