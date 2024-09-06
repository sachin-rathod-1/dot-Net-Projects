using Microsoft.AspNetCore.Mvc;
using Learn_MVC_WebApplication1.Models;
using Learn_MVC_WebApplication1.ViewModel;
using Microsoft.Extensions.Logging;


namespace Learn_MVC_WebApplication1.Controllers
{
    
    public class StudentController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository, ILogger<HomeController> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }
        public JsonResult GetStudentDetails(int id)
        {
            Student studentDetails = _studentRepository.GetStudentById(id);
            return Json(studentDetails);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Studentdata()
        {
            var student = new Student();
            student.Name = "Sachin";
            student.Id = 40;
            student.Gender = "Male";
            student.Section = "A";
            student.Branch = "CDAC";
            return View(student);
        }
        public IActionResult StudentViewModel()
        {
            var studentViewModel = new StudentViewModel();
            studentViewModel.studentobj = new Student();
            studentViewModel.studentobj.Name = "Sachin";
            studentViewModel.studentobj.Id = 40;
            studentViewModel.studentobj.Gender = "Male";
            studentViewModel.studentobj.Section = "A";
            studentViewModel.studentobj.Branch = "CDAC";
            studentViewModel.Center = "NETCOME";
            studentViewModel.City = "Jaipur";
            return View("StudentView", studentViewModel);
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
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                Id = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };

            //Student Address
            Address address = new Address()
            {
                Id = 101,
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

        public IActionResult Me()
        {
            return View();
        }
        public IActionResult PassDataFromConToView()
        {
            ViewData["key1"]="I am Passing data from cont to view";
            ViewBag.Firstname = "Sachin";
            return View();
        }
    }
}
