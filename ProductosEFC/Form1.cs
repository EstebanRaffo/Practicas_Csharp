using ProductosEFC.database;
using System.Linq;

namespace ProductosEFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new DBContext();

            var clientes = db.Clientes
                .OrderBy(b => b.Id)
                .ToList();
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = clientes;
        }
    }
}
