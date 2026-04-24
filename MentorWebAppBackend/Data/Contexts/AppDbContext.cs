using MentorWebAppBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorWebAppBackend.Data.Contexts
{
	public class AppDbContext : DbContext
	{
		public DbSet<Feature> Features { get; set; }

		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.\\MSSQLSERVER01;Database=app.db;Integrated Security=True;Trust Server Certificate=True;");
		}
	}
}
