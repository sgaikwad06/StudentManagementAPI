using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentMangementAPI.Data;
using StudentMangementAPI.Models;

namespace StudentMangementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {

            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult ActionResult(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
           
            
            return Ok("Student Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = _context.Students.Find(id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            student.Name = updatedStudent.Name;
            student.Email = updatedStudent.Email;
            student.Age = updatedStudent.Age;
            student.Course = updatedStudent.Course;

            _context.SaveChanges();

            return Ok("Student Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            _context.Students.Remove(student);

            _context.SaveChanges();

            return Ok("Student Deleted Successfully");
        }
    }
}
