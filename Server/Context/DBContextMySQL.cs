using Microsoft.EntityFrameworkCore;

namespace LCPCollection.Server.Context
{
    public class DBContextMySQL : DBContext
    {
        private IConfiguration _configuration;
        private IHostEnvironment _environment;

        public DBContextMySQL(IConfiguration configuration, IHostEnvironment environment) : base(configuration, environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_environment.IsDevelopment())
            {
                optionsBuilder.UseMySql(_configuration["ConnectionStrings:MySQL"], ServerVersion.AutoDetect(_configuration["ConnectionStrings:MySQL"]))
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
            else
            {
                optionsBuilder.UseMySql(_configuration["ConnectionStrings:MySQL"], ServerVersion.AutoDetect(_configuration["ConnectionStrings:MySQL"]));
            }
        }
    }
}
