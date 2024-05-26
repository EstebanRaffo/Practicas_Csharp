namespace Usuarios_Productos
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
            label1 = new Label();
            label2 = new Label();
            dgvListaUsuarios = new DataGridView();
            dgvListaProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(510, 44);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 44);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 1;
            label2.Text = "Usuarios";
            label2.Click += label2_Click;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Location = new Point(12, 114);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.RowTemplate.Height = 25;
            dgvListaUsuarios.Size = new Size(363, 196);
            dgvListaUsuarios.TabIndex = 2;
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProductos.Location = new Point(406, 114);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.RowTemplate.Height = 25;
            dgvListaProductos.Size = new Size(382, 196);
            dgvListaProductos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaProductos);
            Controls.Add(dgvListaUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvListaUsuarios;
        private DataGridView dgvListaProductos;
    }
}
