using Microsoft.EntityFrameworkCore;

namespace LCPCollection.Server.Context
{
    public class DBContextSQLite : DBContext
    {
        private IConfiguration _configuration;
        private IHostEnvironment _environment;

        public DBContextSQLite(IConfiguration configuration, IHostEnvironment environment) : base(configuration, environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_environment.IsDevelopment()) 
            {
                optionsBuilder.UseSqlite(_configuration["ConnectionStrings:SQLite"])
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            } 
            else
            {
                optionsBuilder.UseSqlite(_configuration["ConnectionStrings:SQLite"]);
            }
        }
    }
}
