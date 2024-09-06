using System.Security.Cryptography.X509Certificates;

namespace WebApplication2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
        public GenderList Gender { get; set; }

    }




    public enum GenderList
    {
        Male,
        Female
    }


}