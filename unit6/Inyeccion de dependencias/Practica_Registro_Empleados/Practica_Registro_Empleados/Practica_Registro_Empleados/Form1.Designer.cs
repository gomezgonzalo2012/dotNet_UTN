namespace Practica_Registro_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBoxAgregar = new PictureBox();
            picBoxModificar = new PictureBox();
            picBoxEliminar = new PictureBox();
            dataGridView1 = new DataGridView();
            ColumnaID = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnApellido1 = new DataGridViewTextBoxColumn();
            ColumnaApellido2 = new DataGridViewTextBoxColumn();
            ColumnaEdad = new DataGridViewTextBoxColumn();
            ColumnaMail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)picBoxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxModificar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // picBoxAgregar
            // 
            picBoxAgregar.Image = (Image)resources.GetObject("picBoxAgregar.Image");
            picBoxAgregar.Location = new Point(1055, 61);
            picBoxAgregar.Name = "picBoxAgregar";
            picBoxAgregar.Size = new Size(61, 62);
            picBoxAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAgregar.TabIndex = 0;
            picBoxAgregar.TabStop = false;
            picBoxAgregar.Click += picBoxAgregar_Click;
            // 
            // picBoxModificar
            // 
            picBoxModificar.Image = (Image)resources.GetObject("picBoxModificar.Image");
            picBoxModificar.Location = new Point(1055, 177);
            picBoxModificar.Name = "picBoxModificar";
            picBoxModificar.Size = new Size(61, 62);
            picBoxModificar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxModificar.TabIndex = 1;
            picBoxModificar.TabStop = false;
            picBoxModificar.Click += picBoxModificar_Click;
            // 
            // picBoxEliminar
            // 
            picBoxEliminar.Image = (Image)resources.GetObject("picBoxEliminar.Image");
            picBoxEliminar.Location = new Point(1055, 296);
            picBoxEliminar.Name = "picBoxEliminar";
            picBoxEliminar.Size = new Size(61, 62);
            picBoxEliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxEliminar.TabIndex = 2;
            picBoxEliminar.TabStop = false;
            picBoxEliminar.Click += picBoxEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaID, ColumnaNombre, ColumnApellido1, ColumnaApellido2, ColumnaEdad, ColumnaMail });
            dataGridView1.Location = new Point(43, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(960, 368);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnaID
            // 
            ColumnaID.HeaderText = "ID";
            ColumnaID.MinimumWidth = 8;
            ColumnaID.Name = "ColumnaID";
            ColumnaID.ReadOnly = true;
            ColumnaID.Width = 150;
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.HeaderText = "Nombre";
            ColumnaNombre.MinimumWidth = 8;
            ColumnaNombre.Name = "ColumnaNombre";
            ColumnaNombre.ReadOnly = true;
            ColumnaNombre.Width = 150;
            // 
            // ColumnApellido1
            // 
            ColumnApellido1.HeaderText = "Apellido 1";
            ColumnApellido1.MinimumWidth = 8;
            ColumnApellido1.Name = "ColumnApellido1";
            ColumnApellido1.ReadOnly = true;
            ColumnApellido1.Width = 150;
            // 
            // ColumnaApellido2
            // 
            ColumnaApellido2.HeaderText = "Apellido 2";
            ColumnaApellido2.MinimumWidth = 8;
            ColumnaApellido2.Name = "ColumnaApellido2";
            ColumnaApellido2.ReadOnly = true;
            ColumnaApellido2.Width = 150;
            // 
            // ColumnaEdad
            // 
            ColumnaEdad.HeaderText = "Edad";
            ColumnaEdad.MinimumWidth = 8;
            ColumnaEdad.Name = "ColumnaEdad";
            ColumnaEdad.ReadOnly = true;
            ColumnaEdad.Width = 150;
            // 
            // ColumnaMail
            // 
            ColumnaMail.HeaderText = "E - mail";
            ColumnaMail.MinimumWidth = 8;
            ColumnaMail.Name = "ColumnaMail";
            ColumnaMail.ReadOnly = true;
            ColumnaMail.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 579);
            Controls.Add(dataGridView1);
            Controls.Add(picBoxEliminar);
            Controls.Add(picBoxModificar);
            Controls.Add(picBoxAgregar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBoxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxModificar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxAgregar;
        private PictureBox picBoxModificar;
        private PictureBox picBoxEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaID;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnApellido1;
        private DataGridViewTextBoxColumn ColumnaApellido2;
        private DataGridViewTextBoxColumn ColumnaEdad;
        private DataGridViewTextBoxColumn ColumnaMail;
    }
}
