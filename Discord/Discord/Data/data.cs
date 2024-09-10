using Microsoft.EntityFrameworkCore;
using Discord.models;

namespace Discord.Data
{
    public class data : DbContext
    {
        public data() { } // Add parameterless constructor

        public data(DbContextOptions<data> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // You can either specify the connection string here or pass it from the constructor
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-M9LJK3Q\SQLEXPRESS03;Initial Catalog=dcs;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

            }
        }
    }
}
