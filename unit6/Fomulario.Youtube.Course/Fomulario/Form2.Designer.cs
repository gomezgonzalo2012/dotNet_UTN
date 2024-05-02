namespace Fomulario
{
    partial class Form2
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
            lblId = new Label();
            lblMarca = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblIdCliente = new Label();
            txtId = new TextBox();
            txtIdCliente = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            btnLimpiar = new Button();
            btnConfirmar = new Button();
            GridProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridProductos).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(47, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(47, 162);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(47, 119);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(47, 205);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(88, 25);
            lblIdCliente.TabIndex = 4;
            lblIdCliente.Text = "ID Cliente";
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 31);
            txtId.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(153, 202);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(214, 31);
            txtIdCliente.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(153, 159);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(214, 31);
            txtMarca.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(153, 116);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(214, 31);
            txtPrecio.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 31);
            txtNombre.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(657, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(483, 200);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // GridProductos
            // 
            GridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProductos.Location = new Point(47, 268);
            GridProductos.Name = "GridProductos";
            GridProductos.RowHeadersWidth = 62;
            GridProductos.Size = new Size(787, 311);
            GridProductos.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 607);
            Controls.Add(GridProductos);
            Controls.Add(btnConfirmar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtIdCliente);
            Controls.Add(txtId);
            Controls.Add(lblIdCliente);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblMarca);
            Controls.Add(lblId);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)GridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblMarca;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblIdCliente;
        private TextBox txtId;
        private TextBox txtIdCliente;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Button btnLimpiar;
        private Button btnConfirmar;
        private DataGridView GridProductos;
    }
}