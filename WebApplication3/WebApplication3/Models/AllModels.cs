using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }
    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        public string RoleName { get; set; }

        // Foreign key   
        [Display(Name = "Department")]
        public virtual int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Departments { get; set; }
    }


  




}




