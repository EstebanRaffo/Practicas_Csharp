using System.Data.SqlClient;

namespace Usuarios_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Producto> GetProductos()
        {
            string connectionString = @"Server=localhost\MSSQLSERVERC#;Database=SistemaGestion_c9;Trusted_Connection=True;";
            string queryProductos = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock from Producto";
            List<Producto> productos = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryProductos, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(reader["Id"]);
                                producto.Descripcion = reader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(reader["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(reader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(reader["Stock"]);
                                productos.Add(producto);
                            }
                        }
                    }
                }
                connection.Close();
            }
            return productos;
        }

        private List<Usuario> GetUsuarios()
        {
            string connectionString = @"Server=localhost\MSSQLSERVERC#;Database=SistemaGestion_c9;Trusted_Connection=True;";
            string queryUsuarios = "SELECT Id, Nombre, Apellido, NombreUsuario, Mail from Usuario";
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryUsuarios, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(reader["Id"]);
                                usuario.Nombre = reader["Nombre"].ToString();
                                usuario.Apellido = reader["Apellido"].ToString();
                                usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.Email = reader["Mail"].ToString();
                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
                connection.Close();
            }
            return usuarios;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = GetProductos();
            dgvListaProductos.AutoGenerateColumns = true;
            dgvListaUsuarios.DataSource = GetUsuarios();
            dgvListaUsuarios.AutoGenerateColumns = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
