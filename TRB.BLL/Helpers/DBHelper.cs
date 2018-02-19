using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TRB.BLL.Helpers
{
    public static class DBHelper
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TheRoyalBookDB"].ConnectionString;
            }
        }

        public static DataTable ExecuteScalar(string query, CommandType type = CommandType.Text, List<SqlParameter> parameters = null)
        {
            var dt = new DataTable();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandType = type;
                    command.CommandText = query;

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
