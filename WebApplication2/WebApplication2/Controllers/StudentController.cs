using MessagePack.Formatters;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {

        IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModelToView()
        {
            ViewBag.City = "Jaipur";
            ViewData["Center"] = "NET-COM CDAC-ATC";

            var student = new Student();
            student.StudentId = 11;
            student.Gender = GenderList.Male;
            student.Branch = "PG-DAC";
            student.Name = "Suresh";
            student.Section = "A";
            return View(student);
        }

        public IActionResult ViewModelToView()
        {
            var studentviewmodel = new StudentViewModel();
            studentviewmodel.CenterName = "NET-COM CDAC";
            studentviewmodel.City = "Jaipur";
            studentviewmodel.StudentObj = new Student();

            studentviewmodel.StudentObj.StudentId = 11;
            studentviewmodel.StudentObj.Gender = GenderList.Male;
            studentviewmodel.StudentObj.Branch = "PG-DAC";
            studentviewmodel.StudentObj.Name = "Suresh";
            studentviewmodel.StudentObj.Section = "A";
            return View("StudentViewModel", studentviewmodel);
        }

        public IActionResult GetStudent(int Id)
        {
            //  TestStudentRepository repository = new TestStudentRepository();
            Student studentDetails = _studentRepository.GetStudentById(Id);
            return View(studentDetails);
        }

        public IActionResult GetAllStudentDetails()
        {
            //  TestStudentRepository repository = new TestStudentRepository();
            List<Student> Stulist = _studentRepository.GetAllStudetns();

            return View(Stulist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Student student)
        {

            _studentRepository.Addstudent(student);
            return RedirectToAction("GetStudent", new { Id = student.StudentId });
        }









        public IActionResult Update(Student student)
        {

            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = GenderList.Male
            };

            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };

            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };

            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }
    }
}