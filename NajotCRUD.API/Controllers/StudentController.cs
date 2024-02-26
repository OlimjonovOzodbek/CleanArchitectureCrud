using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajotCRUD.Application.Services.StudentServices;
using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;

namespace NajotCRUD.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudentService _st;
        public StudentController(IStudentService st)
        {
            _st = st;
        }

        [HttpPost]
        public async Task<string> CreateStudent([FromForm] StudentDTO st)
        {
            return await _st.CreateStudent(st);
        }
        [HttpGet]
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _st.GetAllStudents();
        }
        [HttpGet]
        public async Task<Student> GetStudentById(int id)
        {
            return await _st.GetStudent(id);
        }
        [HttpDelete]
        public async Task<string> DeleteStudent(int id)
        {
            return await _st.DeleteStudent(id);
        }
        [HttpPut]
        public async Task<string> UpdateStudent(int id, [FromForm] StudentDTO st)
        {
            return await _st.UpdateStudent(id, st);
        }
    }
}
