using System;
using System.Data.SqlClient;

namespace CRUD
{
    public static class DataAccess
    {
        public static void UpdateStudent(string connStr, string id, string name, string dept, string division, string district, string gender, double cgpa)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "UPDATE Students SET Name=@Name, Dept=@Dept, Division=@Division, District=@District, Gender=@Gender, Cgpa=@Cgpa WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Dept", dept);
                cmd.Parameters.AddWithValue("@Division", division ?? string.Empty);
                cmd.Parameters.AddWithValue("@District", district ?? string.Empty);
                cmd.Parameters.AddWithValue("@Gender", gender ?? string.Empty);
                cmd.Parameters.AddWithValue("@Cgpa", cgpa);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteStudent(string connStr, string id)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "DELETE FROM Students WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
