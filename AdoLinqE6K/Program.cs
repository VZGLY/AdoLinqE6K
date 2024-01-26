using AdoLinqE6K.Entities;
using Microsoft.Data.SqlClient;

string connectionString = "Server=localhost;Database=DBSlideTest;Trusted_Connection=True;TrustServerCertificate=True;";

List<Student> students = new List<Student>();

using(SqlConnection connection = new SqlConnection(connectionString))
{
    
    using (SqlCommand command = connection.CreateCommand())
    {
        connection.Open();

        command.CommandText = "SELECT * FROM Student";

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Student student = new Student()
            {
                StudentId = Convert.ToInt32(reader["Student_id"]),
                Firstname = reader["first_name"].ToString(),
                Lastname = reader["last_name"].ToString(),
                Login = reader["login"].ToString(),
                Birthdate = reader["birth_date"] != DBNull.Value ? Convert.ToDateTime(reader["birth_date"]) : null,
                YearResult = reader["year_result"] != DBNull.Value ? Convert.ToInt32(reader["year_result"]) : null,
                CourseId = reader["course_id"] != DBNull.Value ? reader["course_id"].ToString() : null,
                SectionId = reader["section_id"] != DBNull.Value ? Convert.ToInt32(reader["section_id"]) : null
            };

            students.Add(student);
            
        }

        connection.Close();
    }
}

foreach (var stud in students)
{
    Console.WriteLine(stud.Login);
}
