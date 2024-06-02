namespace ProductosABM
{
    partial class FormGestion
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
            buttonAgregar = new Button();
            buttonActualizar = new Button();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // label1.Click += label1_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Lime;
            buttonAgregar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(555, 12);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(99, 39);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.DodgerBlue;
            buttonActualizar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActualizar.ForeColor = SystemColors.ActiveCaptionText;
            buttonActualizar.Location = new Point(662, 12);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(126, 39);
            buttonActualizar.TabIndex = 2;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(41, 80);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(730, 329);
            dgvProductos.TabIndex = 3;
            // 
            // FormGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonAgregar);
            Controls.Add(label1);
            Name = "FormGestion";
            Text = "Gestión de Productos";
            Load += FormGestion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAgregar;
        private Button buttonActualizar;
        private DataGridView dgvProductos;
    }
}
