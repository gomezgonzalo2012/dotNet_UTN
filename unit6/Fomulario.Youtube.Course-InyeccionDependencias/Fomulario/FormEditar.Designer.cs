namespace Fomulario
{
    partial class FormEditar
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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            txtIdCliente = new TextBox();
            txtId = new TextBox();
            lblIdCliente = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblMarca = new Label();
            lblId = new Label();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(320, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 31);
            txtNombre.TabIndex = 19;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(320, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(214, 31);
            txtPrecio.TabIndex = 18;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(320, 182);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(214, 31);
            txtMarca.TabIndex = 17;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(320, 225);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(214, 31);
            txtIdCliente.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(320, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 31);
            txtId.TabIndex = 15;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(214, 228);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(88, 25);
            lblIdCliente.TabIndex = 14;
            lblIdCliente.Text = "ID Cliente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(214, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(214, 142);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(214, 185);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 25);
            lblMarca.TabIndex = 11;
            lblMarca.Text = "Marca";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(214, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 10;
            lblId.Text = "ID";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(248, 300);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(182, 34);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(457, 300);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
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
            Name = "FormEditar";
            Text = "FormEditar";
            Load += FormEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private TextBox txtIdCliente;
        private TextBox txtId;
        private Label lblIdCliente;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblMarca;
        private Label lblId;
        private Button btnGuardar;
        private Button btnVolver;
    }
}