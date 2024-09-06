namespace EndTOEnd.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace WebApplication3.Models
    {
        public class Department
        {
            [Key]
            public int DepartmentId { get; set; }

            [Required]
            public string DepartmentName { get; set; }
            public string DepartmentHead { get; set; }
        }

        public class Employee
        {
            [Key]
            public int EmployeeId { get; set; }

            [Required]
            public string EmployeeName { get; set; }

            // Foreign key   
            [Display(Name = "Department")]
            public virtual int DepartmentId { get; set; }

            [ForeignKey("DepartmentId")]
            public virtual Department Departments { get; set; }
           
            public string Adress { get; set; }
        }
    }
}
