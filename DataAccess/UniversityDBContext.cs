using Microsoft.EntityFrameworkCore;
using myFirstBackend.Models.DataModels;

namespace myFirstBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext>options): base(options) 
        { 

        }
        //agregar base de DB sets (tablas de tu base de datos)

        public DbSet<User>? Users { get; set; }
    }
}
