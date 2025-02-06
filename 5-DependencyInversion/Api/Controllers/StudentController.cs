using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    IStudentRepository studentRepository;
    ILogBook logbook;

    public StudentController(IStudentRepository student, ILogBook log)
    {
        IStudentRepository = student;
        ILogBook = log;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
