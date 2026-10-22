using System;
using System.Collections.Generic;
using System.Text;

namespace cafeteria
{
    public class Pedido 
    {
        public Producto Producto { get; set; }
        public int Cantidad {  get; set; }
        public bool Llevar {  get; set;}
        public decimal Subtotal 
        {
            get
            {
                decimal Subtotal = Producto.PrecioUnitario * Cantidad;
                if (Llevar)
                    Subtotal += 5;
                return Subtotal;
            }
            set;
        }

 
        public Pedido (Producto producto, int cantidad,  bool llevar) 
        {
            Producto = producto;
            Cantidad = cantidad;
            Llevar = llevar;
        }
        
    }
}
