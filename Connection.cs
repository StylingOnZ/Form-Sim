using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Sim
{
    public class DatabaseConnection
    {
        private readonly string connectionString = "Server=ADMIN-PC\\SQLEXPRESS;Database=SimThe;Integrated Security=True;";

        public DataTable GetSimData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Sim ORDER BY NgayKichHoat ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
