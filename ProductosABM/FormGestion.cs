using ProductosABM.Database;

namespace ProductosABM
{
    public partial class FormGestion : Form
    {
        public int idProducto;
        public FormGestion()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            FormABM formAbm = new FormABM();
            Program.formGestion.Hide();
            formAbm.Show();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Refresh();
            GestorBaseDeDatos gestor = new GestorBaseDeDatos();
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = gestor.GetProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idProducto = 0;
            GestorBaseDeDatos gestor = new GestorBaseDeDatos();
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = gestor.GetProducts();
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idProducto = int.Parse(dgvProductos[0, filaSeleccionada].Value.ToString());
            }
            FormABM formAbm = new FormABM();
            Program.formGestion.Hide();
            formAbm.Show();
        }
    }
}
