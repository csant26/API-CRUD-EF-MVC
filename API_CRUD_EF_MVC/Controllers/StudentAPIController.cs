using API_CRUD_EF_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_EF_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly StudentDbContext context;

        public StudentAPIController(StudentDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await context.Students.ToListAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var data = await context.Students.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateStudent(int id, Student student)
        {
            if(id != student.Id)
            {
                return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var data = await context.Students.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            context.Students.Remove(data);
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
