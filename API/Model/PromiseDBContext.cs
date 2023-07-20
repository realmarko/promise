using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class PromiseDBContext : DbContext
    {
        public DbSet<Property> Property { get; set; }
        public DbSet<House> House { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;DataBase=realestate;uid=admin;pwd=password");
        }
    }
}