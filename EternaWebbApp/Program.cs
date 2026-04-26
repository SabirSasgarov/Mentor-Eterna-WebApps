using EternaWebbApp.Data;
using EternaWebbApp.Data;
using Microsoft.EntityFrameworkCore;

namespace EternaWebbApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(context =>
				context.UseSqlServer("Server=.\\MSSQLSERVER01;Database=EternaDB;Trusted_Connection=True;Trust Server Certificate=True;")
			);


			var app = builder.Build();

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
