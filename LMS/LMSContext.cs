using Microsoft.EntityFrameworkCore;

namespace LMS
{
    public class LMSContext : DbContext
    {

            public DbSet<Score>? Scores { get; set; }
            public DbSet<Course>? Courses { get; set; }

            public DbSet<User>? Users { get; set; }

        public LMSContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(s => s.Username);
            modelBuilder.Entity<Course>().HasKey(s => s.CourseID);
            modelBuilder.Entity<Score>().HasNoKey();
        }

        public const string ConnectString = @"Data Source=PHLONG0502\SQLEXPRESS;Initial Catalog=LMSDB;User ID=sa;Password=123456";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectString);
            optionsBuilder.UseLoggerFactory(GetLoggerFactory());
        }
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                    builder.AddConsole()
                           .AddFilter(DbLoggerCategory.Database.Command.Name,
                                    LogLevel.Information));
            return serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();
        }
    }
}


