namespace WebApplication2.Models
{
    public class TestStudentRepository : IStudentRepository
    {

        private List<Student> repolist;
        public List<Student> DataSource()
        {


            repolist = new List<Student>()
            {
                new Student() { StudentId = 101,
                    Name = "James", Branch = "CSE", Section = "A", Gender =GenderList.Male },
                new Student() { StudentId = 102,
                    Name = "Smith", Branch = "ETC", Section = "B", Gender = GenderList.Male},
                new Student() { StudentId = 103,
                    Name = "David", Branch = "CSE", Section = "A", Gender = GenderList.Male },
                new Student() { StudentId = 104,
                    Name = "Sara", Branch = "CSE", Section = "A", Gender = GenderList.Female },
                new Student() { StudentId = 105,
                    Name = "Shraddha", Branch = "ETC", Section = "B", Gender = GenderList.Female }
            };

            return repolist;
        }
        public Student GetStudentById(int StudentId)
        {
            return repolist.FirstOrDefault(e => e.StudentId == StudentId);
        }


        public List<Student> GetAllStudetns()
        {
            return DataSource().ToList();
        }

        public Student Addstudent(Student student)
        {
            Student s = repolist.LastOrDefault();
            student.StudentId = s.StudentId + 1;
            repolist.Add(student);
            return student;
        }

        public Student Updatestudent(Student student)
        {
            return student;
        }
        

        public Student Deletestudent(Student student)
        {
            repolist.Find(Predicate<Student> student.StudentId)

            return student;
        }

    }
}