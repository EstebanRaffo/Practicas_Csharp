using ProductosABM.Database;

namespace ProductosABM
{
    public partial class FormGestion : Form
    {
        public FormGestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormABM formAbm = new FormABM();
            Program.formGestion.Hide();
            formAbm.Show();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Refresh();
            GestorBaseDeDatos gestor = new GestorBaseDeDatos();
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = gestor.GetProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
