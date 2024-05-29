using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductosABM.Models;
using System.Data.SqlClient;

namespace ProductosABM.Database
{
    internal class GestorBaseDeDatos
    {
        private string connectionString;

        public GestorBaseDeDatos()
        {
            connectionString = @"Server=localhost\MSSQLSERVERC#;Database=SistemaGestion_c10;Trusted_Connection=True;";
        }

        public bool DeleteProduct(int id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool CreateProduct(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@nombre, @costo, @precio, @stock, @idUsuario)";
                SqlCommand command = new SqlCommand(query, conn);
                
                command.Parameters.AddWithValue("nombre", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precio", producto.Precio);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                conn.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public Producto GetProductById(int id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Producto WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("id", id);
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int prodId = Convert.ToInt32(reader[0]);
                    string descripcion = reader.GetString(1);
                    double costo = Convert.ToDouble(reader[2]);
                    double precio = Convert.ToDouble(reader[3]);
                    int stock = Convert.ToInt32(reader[4]);
                    int idUsuario = Convert.ToInt32(reader[5]);
                    return new Producto(prodId, descripcion, costo, precio, stock, idUsuario);
                }
                throw new Exception("Id no encontrado");
            }
        }

        public bool UpdateProduct(int prodId, Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Producto SET Descripcion = @descripcion, Costo = @costo, PrecioVenta = @precio, Stock = @stock, IdUsuario = @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                
                command.Parameters.AddWithValue("descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precio", producto.Precio);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                command.Parameters.AddWithValue("id", prodId);
                
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<Producto> GetProducts()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Producto";
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                { 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto(); 
                            producto.Id = Convert.ToInt32(reader["Id"]);
                            producto.Descripcion = reader["Descripciones"].ToString();
                            producto.Costo = Convert.ToDouble(reader["Costo"]);
                            producto.Precio = Convert.ToDouble(reader["PrecioVenta"]);
                            producto.Stock = Convert.ToInt32(reader["Stock"]);
                            producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            productos.Add(producto);
                        }
                    }
                }
            }
            return productos;
        }
    }
}
