namespace MoviesApp
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnTitle = new DataGridViewTextBoxColumn();
            ColumnLenguages = new DataGridViewTextBoxColumn();
            ColumnBudget = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Window;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(794, 94);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 82);
            btnSave.TabIndex = 0;
            btnSave.Text = "Agregar";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Window;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(794, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 82);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(794, 211);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 82);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Modificar";
            btnUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnTitle, ColumnLenguages, ColumnBudget });
            dataGridView1.Location = new Point(40, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(713, 314);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 8;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 150;
            // 
            // ColumnTitle
            // 
            ColumnTitle.HeaderText = "Titulo";
            ColumnTitle.MinimumWidth = 8;
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.Width = 150;
            // 
            // ColumnLenguages
            // 
            ColumnLenguages.HeaderText = "Idioma Original";
            ColumnLenguages.MinimumWidth = 8;
            ColumnLenguages.Name = "ColumnLenguages";
            ColumnLenguages.ReadOnly = true;
            ColumnLenguages.Width = 170;
            // 
            // ColumnBudget
            // 
            ColumnBudget.HeaderText = "Presupesto";
            ColumnBudget.MinimumWidth = 8;
            ColumnBudget.Name = "ColumnBudget";
            ColumnBudget.ReadOnly = true;
            ColumnBudget.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 4;
            label1.Text = "Tabla de peliculas";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(974, 486);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Name = "Principal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnLenguages;
        private DataGridViewTextBoxColumn ColumnBudget;
        private Label label1;
    }
}
