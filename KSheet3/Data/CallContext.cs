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

		public DbSet<Call> Calls { get; set; }
	}
}
