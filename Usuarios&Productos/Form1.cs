using System.Data.SqlClient;

namespace Usuarios_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\MSSQLSERVERC#;Database=SistemaGestion_c9;Trusted_Connection=True;";
            string queryProductos = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock from Producto";
            string queryUsuarios = "SELECT Id, Nombre, Apellido, NombreUsuario, Mail from Usuario";
            List<Producto> productos = new List<Producto>();
            List<Usuario> usuarios = new List<Usuario>();
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
                    connection.Close();
                }
            }
            dgvListaProductos.DataSource = productos;
            dgvListaProductos.AutoGenerateColumns = true;
            dgvListaUsuarios.DataSource = usuarios;
            dgvListaUsuarios.AutoGenerateColumns = true;
        }
    }
}
