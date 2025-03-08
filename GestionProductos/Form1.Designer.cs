namespace GestionProductos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarOferta = new System.Windows.Forms.Button();
            this.btnMostrarAgotados = new System.Windows.Forms.Button();
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.btnModificarPrecio = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(68, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(68, 92);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 22);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(68, 132);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(248, 12);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(618, 292);
            this.lstProductos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(68, 172);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarOferta
            // 
            this.btnMostrarOferta.Location = new System.Drawing.Point(716, 310);
            this.btnMostrarOferta.Name = "btnMostrarOferta";
            this.btnMostrarOferta.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarOferta.TabIndex = 6;
            this.btnMostrarOferta.Text = "En Oferta (<10)";
            this.btnMostrarOferta.UseVisualStyleBackColor = true;
            this.btnMostrarOferta.Click += new System.EventHandler(this.btnMostrarOferta_Click);
            // 
            // btnMostrarAgotados
            // 
            this.btnMostrarAgotados.Location = new System.Drawing.Point(560, 310);
            this.btnMostrarAgotados.Name = "btnMostrarAgotados";
            this.btnMostrarAgotados.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarAgotados.TabIndex = 7;
            this.btnMostrarAgotados.Text = "Agotados";
            this.btnMostrarAgotados.UseVisualStyleBackColor = true;
            this.btnMostrarAgotados.Click += new System.EventHandler(this.btnMostrarAgotados_Click);
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Location = new System.Drawing.Point(404, 310);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarStock.TabIndex = 8;
            this.btnMostrarStock.Text = "En Stock";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            this.btnMostrarStock.Click += new System.EventHandler(this.btnMostrarStock_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(248, 310);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Location = new System.Drawing.Point(68, 332);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(150, 30);
            this.btnModificarCantidad.TabIndex = 10;
            this.btnModificarCantidad.Text = "Modificar Cantidad";
            this.btnModificarCantidad.UseVisualStyleBackColor = true;
            this.btnModificarCantidad.Click += new System.EventHandler(this.btnModificarCantidad_Click);
            // 
            // btnModificarPrecio
            // 
            this.btnModificarPrecio.Location = new System.Drawing.Point(68, 292);
            this.btnModificarPrecio.Name = "btnModificarPrecio";
            this.btnModificarPrecio.Size = new System.Drawing.Size(150, 30);
            this.btnModificarPrecio.TabIndex = 11;
            this.btnModificarPrecio.Text = "Modificar Precio";
            this.btnModificarPrecio.UseVisualStyleBackColor = true;
            this.btnModificarPrecio.Click += new System.EventHandler(this.btnModificarPrecio_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(68, 252);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 30);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar Producto";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(68, 212);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 30);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(1, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificarPrecio);
            this.Controls.Add(this.btnModificarCantidad);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnMostrarStock);
            this.Controls.Add(this.btnMostrarAgotados);
            this.Controls.Add(this.btnMostrarOferta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarOferta;
        private System.Windows.Forms.Button btnMostrarAgotados;
        private System.Windows.Forms.Button btnMostrarStock;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnModificarCantidad;
        private System.Windows.Forms.Button btnModificarPrecio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}