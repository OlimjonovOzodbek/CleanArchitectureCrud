using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Application.Services.StudentServices
{
    public interface IStudentService
    {
        public Task<string> CreateStudent(StudentDTO st);
        public Task<string> UpdateStudent(int id, StudentDTO st);
        public Task<string> DeleteStudent(int id);
        public Task<Student> GetStudent(int id);
        public Task<IEnumerable<Student>> GetAllStudents();
    }
}
