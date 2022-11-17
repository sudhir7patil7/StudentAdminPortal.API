using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.DataModels
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options ):base (options)
        {

        }
        public DbSet<Student>  student { get; set; }
        public DbSet<Gender>  gender { get; set; }
        public DbSet<Address>  address { get; set; }
    }
}
