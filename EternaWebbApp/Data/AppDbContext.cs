using EternaWebbApp.Models;
using EternaWebbApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaWebbApp.Data
{
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
	{
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Service> Services { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Slider>().HasData(
				new Slider
				{
					Id = 1,
					Name = "Welcome to Eterna",
					SubTitle = "Modern and clean design",
					ButtonText = "Read More",
					ButtonLink = "#",
					ImageUrl = "hero-carousel-1.jpg"
				},
				new Slider
				{
					Id = 2,
					Name = "Build Better Websites",
					SubTitle = "Fast, responsive and elegant",
					ButtonText = "Get Started",
					ButtonLink = "#",
					ImageUrl = "hero-carousel-2.jpg"
				},
				new Slider
				{
					Id = 3,
					Name = "Grow Your Business",
					SubTitle = "Solutions for your success",
					ButtonText = "Learn More",
					ButtonLink = "#",
					ImageUrl = "hero-carousel-3.jpg"
				}
			);

			modelBuilder.Entity<Feature>().HasData(
				new Feature
				{
					Id = 1,
					Icon = "bi bi-briefcase",
					Title = "Professional Service",
					Description = "We provide high-quality web solutions tailored to your business goals."
				},
				new Feature
				{
					Id = 2,
					Icon = "bi bi-gem",
					Title = "Modern Design",
					Description = "Clean, responsive, and user-friendly interfaces for all devices."
				},
				new Feature
				{
					Id = 3,
					Icon = "bi bi-speedometer2",
					Title = "Fast Performance",
					Description = "Optimized architecture and code to ensure speed and reliability."
				}
			);

			modelBuilder.Entity<Service>().HasData(
				new Service
				{
					Id = 1,
					Icon = "bi bi-activity",
					Title = "Web Development",
					Description = "Custom web applications built with modern, scalable technologies."
				},
				new Service
				{
					Id = 2,
					Icon = "bi bi-broadcast",
					Title = "Digital Marketing",
					Description = "Result-driven strategies to increase your online visibility and growth."
				},
				new Service
				{
					Id = 3,
					Icon = "bi bi-easel",
					Title = "UI/UX Design",
					Description = "Intuitive and engaging user experiences designed for your audience."
				},
				new Service
				{
					Id = 4,
					Icon = "bi bi-bounding-box-circles",
					Title = "Brand Identity",
					Description = "Strong and consistent branding to make your business stand out."
				},
				new Service
				{
					Id = 5,
					Icon = "bi bi-calendar4-week",
					Title = "Project Planning",
					Description = "Structured planning and execution to keep projects on time and budget."
				},
				new Service
				{
					Id = 6,
					Icon = "bi bi-chat-square-text",
					Title = "Consulting",
					Description = "Expert advice to help you choose the right technical direction."
				}
			);
		}
	}
}
