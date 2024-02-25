using Microsoft.EntityFrameworkCore;

namespace KSheet3.Data
{
	public class CallContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public CallContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(Configuration.GetConnectionString("CallsDB"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Call>()
				.ToTable("Calls");

			modelBuilder.Entity<Call>()
				.HasData(
	new Call { Id = 1, Position = 146, Address = "7956 Summerview Alley", PdSignal = "28", FdSignal = "30", Notes = "Multi-layered full-range hub" },
	new Call { Id = 994, Position = 151, Address = "7 Spohn Trail", PdSignal = "16", FdSignal = "12", Notes = "Fundamental neutral model" },
	new Call { Id = 995, Position = 141, Address = "47133 Mendota Hill", PdSignal = "22", FdSignal = "2", Notes = "Organized object-oriented interface" },
	new Call { Id = 996, Position = 146, Address = "06 Basil Lane", PdSignal = "21", FdSignal = "24", Notes = "Expanded context-sensitive infrastructure" },
	new Call { Id = 997, Position = 150, Address = "8 Vidon Street", PdSignal = "18", FdSignal = "14", Notes = "User-centric impactful matrix" },
	new Call { Id = 998, Position = 141, Address = "5797 Eastlawn Circle", PdSignal = "33", FdSignal = "28", Notes = "Switchable client-driven paradigm" },
	new Call { Id = 999, Position = 131, Address = "8056 Westend Plaza", PdSignal = "48", FdSignal = "13", Notes = "Optional encompassing artificial intelligence" },
	new Call { Id = 1000, Position = 137, Address = "29 Hansons Way", PdSignal = "27", FdSignal = "25", Notes = "Centralized regional ability" }

				);
		}

		public DbSet<Call> Calls { get; set; }

	}
}
