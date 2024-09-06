namespace WebApplication2.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);

        Student Addstudent(Student student);
        Student Updatestudent(Student student);
        Student DeleteStudent(Student student);
        List<Student> GetAllStudetns();
    }
}