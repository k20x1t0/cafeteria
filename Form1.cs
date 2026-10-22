using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace cafeteria

{
    public partial class Form1 : Form
    {
        private BindingList<Producto> productos;
        private BindingList<Pedido> pedidos;
        public Form1()
        {
            InitializeComponent();
            inicializarProductos();
            pedidos = new BindingList<Pedido>();
            dataGridViewPedidos.DataSource = pedidos;
            dataGridViewPedidos.Columns["Producto"].HeaderText = "Producto";
            dataGridViewPedidos.Columns["Cantidad"].HeaderText = "Cantidad";
            dataGridViewPedidos.Columns["Llevar"].HeaderText = "Para llevar";
            dataGridViewPedidos.Columns["Subtotal"].HeaderText = "Subtotal";

        }

        private void inicializarProductos()
        {
            productos = new BindingList<Producto>
            {
                new Producto("Café", 30.00m),
                new Producto("Té", 25.00m),
                new Producto("Sandwich", 55.00m),
                new Producto("Galletas", 20.00m)
             };
            cmbProducto.DataSource = productos;

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var productoSeleccionado = (Producto)cmbProducto.SelectedItem;
            txtPrecio.Text = productoSeleccionado.PrecioUnitario.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (Producto)cmbProducto.SelectedItem;
            int cantidad = (int)numCantidad.Value;
            bool llevar = cbLlevar.Checked;

            var nuevoPedido = new Pedido(productoSeleccionado, cantidad, llevar);
            pedidos.Add(nuevoPedido);
            actualizarTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewPedidos.SelectedRows)
                {
                    pedidos.Remove((Pedido)row.DataBoundItem);
                }
                actualizarTotal();
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea vaciar todos los pedidos?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                pedidos.Clear();
                actualizarTotal();
            }
        }

        private void actualizarTotal()
        {
            decimal total = pedidos.Sum(p => p.Subtotal);
            lblTotal.Text = $"Total: {total:C}";
        }

        
    }
}
