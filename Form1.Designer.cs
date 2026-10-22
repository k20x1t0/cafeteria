namespace cafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnVaciar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            cbLlevar = new CheckBox();
            numCantidad = new NumericUpDown();
            label3 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            cmbProducto = new ComboBox();
            label1 = new Label();
            dataGridViewPedidos = new DataGridView();
            label4 = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVaciar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cbLlevar);
            panel1.Controls.Add(numCantidad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbProducto);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 212);
            panel1.TabIndex = 0;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(200, 177);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(75, 23);
            btnVaciar.TabIndex = 9;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(103, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(9, 177);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbLlevar
            // 
            cbLlevar.AutoSize = true;
            cbLlevar.Location = new Point(9, 132);
            cbLlevar.Name = "cbLlevar";
            cbLlevar.Size = new Size(166, 19);
            cbLlevar.TabIndex = 6;
            cbLlevar.Text = "Para llevar (+5 por pedido)";
            cbLlevar.UseVisualStyleBackColor = true;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(111, 86);
            numCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(58, 23);
            numCantidad.TabIndex = 5;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 50);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(58, 23);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio unitario";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(111, 12);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 1;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.AllowUserToAddRows = false;
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(12, 257);
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPedidos.Size = new Size(445, 124);
            dataGridViewPedidos.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 239);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 2;
            label4.Text = "Pedidos registrados";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(166, 400);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "TOTAL:       ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 473);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(dataGridViewPedidos);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txtPrecio;
        private Label label2;
        private ComboBox cmbProducto;
        private Label label1;
        private Button btnVaciar;
        private Button btnEliminar;
        private Button btnAgregar;
        private CheckBox cbLlevar;
        private NumericUpDown numCantidad;
        private DataGridView dataGridViewPedidos;
        private Label label4;
        private Label lblTotal;
    }
}
