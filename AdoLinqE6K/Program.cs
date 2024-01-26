using AdoLinqE6K.Entities;
using Microsoft.Data.SqlClient;

string connectionString = "Server=localhost;Database=DBSlideTest;Trusted_Connection=True;TrustServerCertificate=True;";

//List<Student> students = new List<Student>();

Student student = new Student()
{
    StudentId = 32,
    Firstname = "Test",
    Lastname = "Test",
    Birthdate = DateTime.Now,
    CourseId = "Test",
    Login = "TTest",
    SectionId = 1010,
    YearResult = 20
};

using(SqlConnection connection = new SqlConnection(connectionString))
{
    
    using (SqlCommand command = connection.CreateCommand())
    {
        // ☣️☣️☣️☣️☣️☣️☣️☣️☣️☣️ YAMAAAAAAAAIS FAIRE CAAAAAAAAAAAAAAA !!!!! ⛔⛔⛔⛔⛔⛔⛔⛔⛔🚫🚫🚫🚫🚫🚫🚫
        // Voir => Injection SQL
        //command.CommandText = $"INSERT INTO Student VALUES ({student.firstname}, {student.lastname}, {student.birthdate}, {student.login}, {student.section}, {student.result}, {student.course})";

        command.CommandText = "INSERT INTO Student VALUES (@id, @firstname, @lastname, @birthdate, @login, @section, @result, @course)";

        command.Parameters.AddWithValue("id", student.StudentId);
        command.Parameters.AddWithValue("firstname", student.Firstname);
        command.Parameters.AddWithValue("lastname", student.Lastname);
        command.Parameters.AddWithValue("birthdate", student.Birthdate);
        command.Parameters.AddWithValue("login", student.Login);
        command.Parameters.AddWithValue("section", student.SectionId);
        command.Parameters.AddWithValue("result", student.YearResult);
        command.Parameters.AddWithValue("course", student.CourseId);

        connection.Open();

        int rowAffected = command.ExecuteNonQuery();

        connection.Close();

        Console.WriteLine(rowAffected != 0);



        //connection.Open();

        //command.CommandText = "SELECT * FROM Student";

        //SqlDataReader reader = command.ExecuteReader();

        //while (reader.Read())
        //{
        //    Student student = new Student()
        //    {
        //        StudentId = Convert.ToInt32(reader["Student_id"]),
        //        Firstname = reader["first_name"].ToString(),
        //        Lastname = reader["last_name"].ToString(),
        //        Login = reader["login"].ToString(),
        //        Birthdate = reader["birth_date"] != DBNull.Value ? Convert.ToDateTime(reader["birth_date"]) : null,
        //        YearResult = reader["year_result"] != DBNull.Value ? Convert.ToInt32(reader["year_result"]) : null,
        //        CourseId = reader["course_id"] != DBNull.Value ? reader["course_id"].ToString() : null,
        //        SectionId = reader["section_id"] != DBNull.Value ? Convert.ToInt32(reader["section_id"]) : null
        //    };

        //    students.Add(student);

        //}

        //connection.Close();
    }
}

