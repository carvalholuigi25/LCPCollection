using LCPCollection.Server.Extensions;
using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Files;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;

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
        public DbSet<Users> Users { get; set; }

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
            modelBuilder.Entity<Users>().HasData(new Users
            {
                Id = 1,
                Username = "admin",
                Password = BC.HashPassword("admin2024", BC.GenerateSalt(12), false, BCrypt.Net.HashType.SHA256),
                RoleName = RolesNamesEnum.Administrator.ToString(),
                DateAccountCreated = DateTime.UtcNow,
                CurrentToken = null,
                RefreshToken = null,
                RefreshTokenExpiryTime = DateTime.UtcNow
            });

            modelBuilder.Entity<Animes>().HasData(new Animes
            { 
                Id = 1, 
                Title = "Dragon Ball", 
                Description = "Dragon Ball", 
                Companies = "Toei Animation", 
                Publishers = "Toei Animation", 
                CoverUrl = "covers/db.jpg", 
                ImageUrl = "images/db.jpg", 
                Platforms = "TV", 
                TrailerUrl = "https://www.youtube.com/embed/gqIEgmqljM8", 
                Genre = "Animation",
                ReleaseDate = new DateTime(1986, 2, 26, 0, 0, 0).ToLocalTime(),
                Rating = 9
            });
        }
    }
}
