namespace Learn_MVC_WebApplication1.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int Id);
        List<Student> GetAllStudetns();
    }
}
