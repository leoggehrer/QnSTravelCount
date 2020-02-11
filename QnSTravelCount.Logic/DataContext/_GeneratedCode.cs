namespace QnSTravelCount.Logic.DataContext.Db
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	partial class QnSTravelCountDbContext : GenericDbContext
	{
		protected DbSet<Entities.Persistence.App.Expense> ExpenseSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.App.Travel> TravelSet
		{
			get;
			set;
		}
		public override DbSet<E> Set<I, E>()
		{
			DbSet<E> result = null;
			if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.App.IExpense))
			{
				result = ExpenseSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.App.ITravel))
			{
				result = TravelSet as DbSet<E>;
			}
			return result;
		}
		partial void DoModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Entities.Persistence.App.Expense>().ToTable(nameof(Entities.Persistence.App.Expense), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Expense.Id));
			modelBuilder.Entity<Entities.Persistence.App.Expense>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Expense>());
			modelBuilder.Entity<Entities.Persistence.App.Travel>().ToTable(nameof(Entities.Persistence.App.Travel), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Travel.Id));
			modelBuilder.Entity<Entities.Persistence.App.Travel>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Travel>());
		}
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Expense> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Travel> entityTypeBuilder);
	}
}
