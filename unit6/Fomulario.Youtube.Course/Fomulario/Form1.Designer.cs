namespace Fomulario
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
            lblNombre = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            grillaDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grillaDatos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(37, 82);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(56, 25);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(332, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(139, 79);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(129, 31);
            txtEdad.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(559, 41);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 49);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(770, 41);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 49);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grillaDatos
            // 
            grillaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaDatos.Location = new Point(103, 164);
            grillaDatos.Name = "grillaDatos";
            grillaDatos.RowHeadersWidth = 62;
            grillaDatos.Size = new Size(622, 341);
            grillaDatos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 576);
            Controls.Add(grillaDatos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grillaDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridView grillaDatos;
    }
}
