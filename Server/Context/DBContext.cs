using LCPCollection.Server.Extensions;
using LCPCollection.Shared.Classes;
using Microsoft.EntityFrameworkCore;

namespace LCPCollection.Server.Context
{
    public class DBContext : DbContext
    {
        private IConfiguration _configuration;
        private IHostEnvironment _environment;
        public DbSet<Games> Games { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<TVSeries> TVSeries { get; set; }
        public DbSet<Animes> Animes { get; set; }
        public DbSet<FileData> FilesData { get; set; }
        public DbSet<Softwares> Softwares { get; set; }
        public DbSet<Websites> Websites { get; set; }

        public DBContext(IConfiguration configuration, IHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_environment.IsDevelopment())
            {
                optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:SQLServer"])
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
            else
            {
                optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:SQLServer"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyUtcDateTimeConverter();
            modelBuilder.Entity<Animes>().HasData(new Animes { Id = 1, Title = "Dragon Ball", Description = "Dragon Ball", Companies = "Toei Animation", Publishers = "Toei Animation", ReleaseDate = new DateTime(1986, 2, 26, 0, 0, 0).ToLocalTime(), CoverUrl = "covers/db.jpg", ImageUrl = "images/db.jpg", Platforms = "TV", TrailerUrl = "https://www.youtube.com/watch?v=gqIEgmqljM8", Rating = 9, Genre = "Animation" });
        }
    }
}
