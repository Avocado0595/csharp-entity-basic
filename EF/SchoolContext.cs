using demo04.Models;
using Microsoft.EntityFrameworkCore;

namespace demo04.EF
{
    public class SchoolContext : DbContext //kế thừa từ Dbcontext, ctr + . auto gợi ý using
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolDB;Trusted_Connection=True;User ID=guest;Password=12345678;");
            //connect sql qua connectrion string: 
        }
    }
}