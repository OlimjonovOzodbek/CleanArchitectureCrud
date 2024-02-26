using Microsoft.EntityFrameworkCore;
using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;
using NajotCRUD.Infrastruct.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Application.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        public ApplicationDbContext _context;
        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateStudent(StudentDTO st)
        {
            try
            {
                var model = new Student()
                {
                    Cash = st.Cash,
                    FirstName = st.FirstName,
                    LastName = st.LastName,
                    GroupId = st.GroupId,

                };
                await _context.Students.AddAsync(model);
                await _context.SaveChangesAsync();
                return "Successfully";
            }
            catch
            {
                return "Bad Request";
            }
        }

        public async Task<string> DeleteStudent(int id)
        {
            try
            {
                var model = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    _context.Students.Remove(model);
                    await _context.SaveChangesAsync();
                    return "Successfully";
                }
                else
                {
                    return "Not found";
                }
            }
            catch
            {
                return "Error";
            }
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            try
            {
                var models = await _context.Students.ToListAsync();
                if (models is not null)
                {
                    return models;
                }
                else
                {
                    return Enumerable.Empty<Student>();
                }
            }
            catch
            {
                return Enumerable.Empty<Student>();
            }
        }

        public async Task<Student> GetStudent(int id)
        {
            try
            {

                var model = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    return model;
                }
                else
                {
                    return new Student();
                }
            }
            catch
            {
                return new Student();
            }
        }

        public async Task<string> UpdateStudent(int id, StudentDTO st)
        {
            try
            {
                var model = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    model.FirstName = st.FirstName;
                    model.LastName = st.LastName;
                    model.GroupId = st.GroupId;
                    model.Cash = st.Cash;

                    await _context.SaveChangesAsync();
                    return "Succesfully update";
                }
                else
                {
                    return "Not found";
                }
            }
            catch
            {
                return "Error";
            }
        }
    }
}
