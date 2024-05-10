namespace MoviesApp
{
    partial class FormMovies
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            txtID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtTitle = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            comboBoxLanguage = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            txtBudget = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(74, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(603, 176);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 31);
            panel1.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(119, -6);
            txtID.Name = "txtID";
            txtID.Size = new Size(415, 31);
            txtID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Movie ID: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 31);
            panel2.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(119, 0);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(412, 31);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Titulo:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBoxLanguage);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 31);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 3;
            label5.Text = "Traducciones:";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(119, -2);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(415, 33);
            comboBoxLanguage.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtBudget);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 114);
            panel4.Name = "panel4";
            panel4.Size = new Size(534, 31);
            panel4.TabIndex = 3;
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(119, 0);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(412, 31);
            txtBudget.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 2;
            label4.Text = "Presupuesto:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(264, 236);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(247, 41);
            btnSave.TabIndex = 1;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormMovies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 331);
            Controls.Add(btnSave);
            Controls.Add(flowLayoutPanel1);
            Name = "FormMovies";
            Text = "FormMovies";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox txtID;
        private Label label1;
        private Panel panel2;
        private TextBox txtTitle;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private TextBox txtBudget;
        private Label label4;
        private ComboBox comboBoxLanguage;
        private Label label5;
        private Button btnSave;
    }
}