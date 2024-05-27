using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
