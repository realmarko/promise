using Microsoft.EntityFrameworkCore;
using Core.Entities;
namespace Model
{
    public class PromiseDBContext : DbContext
    {
        public DbSet<Property> Property { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<Image> Image{ get; set; }
        public DbSet<User> User{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;DataBase=realestate;uid=admin;pwd=password");
        }
    }
}