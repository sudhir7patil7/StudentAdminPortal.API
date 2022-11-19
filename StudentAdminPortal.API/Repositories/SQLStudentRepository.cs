using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.Repositories
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly AppDBContext Context;

        public SQLStudentRepository(AppDBContext Context)
        {
            this.Context = Context;
        }
        public List<Student> GetStudents()
        {
            return Context.student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
        }
    }
}
