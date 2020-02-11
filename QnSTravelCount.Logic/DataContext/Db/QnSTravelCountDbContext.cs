//@CustomizeCode
//MdStart
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using QnSTravelCount.Logic.Entities.Persistence.App;

namespace QnSTravelCount.Logic.DataContext.Db
{
    partial class QnSTravelCountDbContext
    {
        static QnSTravelCountDbContext()
        {
            if (Configuration.Configurator.Contains(CommonBase.StaticLiterals.ConnectionStringKey))
            {
                ConnectionString = Configuration.Configurator.Get(CommonBase.StaticLiterals.ConnectionStringKey);
            }
        }

#if DEBUG
        //static LoggerFactory object
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)
                .AddDebug();
        });
#endif
//        private static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDb;Database=QnSTravelCountDb;Integrated Security=True;";
        private static string ConnectionString { get; set; } = "Data Source=127.0.0.1;Database=QnSTravelCountDb;User Id=sa;Password=Gerhard123!";

        #region Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            BeforeConfiguring(optionsBuilder);
            optionsBuilder
#if DEBUG        
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(loggerFactory)
#endif
                .UseSqlServer(ConnectionString);
            AfterConfiguring(optionsBuilder);
        }
        partial void BeforeConfiguring(DbContextOptionsBuilder optionsBuilder);
        partial void AfterConfiguring(DbContextOptionsBuilder optionsBuilder);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            BeforeModelCreating(modelBuilder);
            DoModelCreating(modelBuilder);
            AfterModelCreating(modelBuilder);
        }
        partial void BeforeModelCreating(ModelBuilder modelBuilder);
        partial void DoModelCreating(ModelBuilder modelBuilder);
        partial void AfterModelCreating(ModelBuilder modelBuilder);

//MdStartConfig
        partial void ConfigureEntityType(EntityTypeBuilder<Travel> entityTypeBuilder)
        {
            entityTypeBuilder
                .HasIndex(p => p.Designation)
                .IsUnique();
            entityTypeBuilder
                .Property(p => p.Designation)
                .IsRequired()
                .HasMaxLength(256);
            entityTypeBuilder
                .Property(p => p.Description)
                .HasMaxLength(256);
            entityTypeBuilder
                .Property(p => p.Currency)
                .IsRequired()
                .HasMaxLength(10);
            entityTypeBuilder
                .Property(p => p.Friends)
                .IsRequired()
                .HasMaxLength(1024);
            entityTypeBuilder
                .Property(p => p.Category)
                .IsRequired()
                .HasMaxLength(64);
        }
        partial void ConfigureEntityType(EntityTypeBuilder<Expense> entityTypeBuilder)
        {
            entityTypeBuilder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(128);
            entityTypeBuilder
                .Property(p => p.Friend)
                .IsRequired()
                .HasMaxLength(25);
        }
//MdEndConfig
        #endregion Configuration
    }
}
//MdEnd
