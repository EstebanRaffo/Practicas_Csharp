using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductosABM.Database;
using ProductosABM.Models;

namespace ProductosABM
{
    public partial class FormABM : Form
    {
        public FormABM()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formGestion.idProducto = 0;
            Program.formGestion.Show();
        }

        private void FormABM_Load(object sender, EventArgs e)
        {
            int idProducto = Program.formGestion.idProducto;
            if (idProducto > 0)
            {
                GestorBaseDeDatos gestor = new GestorBaseDeDatos();
                var producto = gestor.GetProductById(idProducto);

                textId.Text = producto.Id.ToString();
                textBox1.Text = producto.Descripcion.ToString();
                textBox2.Text = producto.Costo.ToString();
                textBox3.Text = producto.Precio.ToString();
                textBox4.Text = producto.Stock.ToString();
            }
            else
            {
                Limpiar();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string id = textId.Text;
            GestorBaseDeDatos gestor = new GestorBaseDeDatos();
            gestor.DeleteProduct(int.Parse(id));
            MessageBox.Show("Producto eliminado");
            Limpiar();
            Program.formGestion.idProducto = 0;
            this.Close();
            Program.formGestion.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = textBox1.Text;
            string costo = textBox2.Text;
            string precio = textBox3.Text;
            string stock = textBox4.Text;
        
            int idProducto = Program.formGestion.idProducto;

            Producto nuevoProducto = new Producto(descripcion, double.Parse(costo), double.Parse(precio), int.Parse(stock), 1);

            GestorBaseDeDatos gestor = new GestorBaseDeDatos();
            
            if (idProducto > 0)
            {
                gestor.UpdateProduct(idProducto, nuevoProducto);
                MessageBox.Show("Producto actualizado");
            }
            else
            {
                gestor.CreateProduct(nuevoProducto);
                MessageBox.Show("Producto creado");
            }
            Limpiar();
            this.Close();
            Program.formGestion.idProducto = 0;
            Program.formGestion.Show();
        }
    }
}
