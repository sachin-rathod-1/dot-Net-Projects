namespace Learn_MVC_WebApplication1.Models
{
    public class TestStudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 101, Name = "Seeta", Branch = "CSE", Gender = "Female", Section = "A"
                },
                new Student()
                {
                    Id = 102, Name = "Sachin", Branch = "CDAC", Gender = "Male", Section = "A"
                },
                new Student()
                {
                    Id = 103, Name = "Vipul", Branch = "CDAC", Gender = "Male", Section = "A"
                },
                new Student()
                {
                    Id = 103, Name = "geeta", Branch = "CDAC", Gender = "Female", Section = "A"
                },
            };
        }
        public Student GetStudentById(int Id)
        {
            return DataSource().FirstOrDefault(e => Id == Id);
        }
        public List<Student> GetAllStudetns()
        {
            return DataSource().ToList();
        }
    }
}
