namespace ProductosABM
{
    partial class FormABM
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonCancelar = new Button();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 42);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 120);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Costo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(73, 198);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(73, 275);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(386, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 299);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(386, 23);
            textBox4.TabIndex = 7;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Red;
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(76, 361);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(97, 30);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.DeepSkyBlue;
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(214, 361);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(83, 30);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.LimeGreen;
            buttonGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(343, 361);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(79, 30);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += button1_Click;
            // 
            // FormABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormABM";
            Text = "Administrar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonCancelar;
        private Button buttonEliminar;
        private Button buttonGuardar;
    }
}