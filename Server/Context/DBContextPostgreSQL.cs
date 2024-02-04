using Microsoft.EntityFrameworkCore;

namespace LCPCollection.Server.Context
{
    public class DBContextPostgreSQL : DBContext
    {
        private IConfiguration _configuration;
        private IHostEnvironment _environment;

        public DBContextPostgreSQL(IConfiguration configuration, IHostEnvironment environment) : base(configuration, environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_environment.IsDevelopment())
            {
                optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:PostgreSQL"])
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
            else
            {
                optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:PostgreSQL"]);
            }
        }
    }
}
