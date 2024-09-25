using Microsoft.EntityFrameworkCore;
using Student_Usinge_Entity.Models;

namespace Student_Usinge_Entity.Data
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options) { }

        DbSet<Employee> employees { get; set; }
    }
}
