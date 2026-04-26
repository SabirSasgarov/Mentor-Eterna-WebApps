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
		public DbSet<Client> Clients { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Review> Reviews { get; set; }
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
		
			modelBuilder.Entity<Client>().HasData(
				new Client
				{
					Id = 1,
					ImageUrl = "clients-1.webp"
				},
				new Client
				{
					Id = 2,
					ImageUrl = "clients-2.webp"
				},
				new Client
				{
					Id = 3,
					ImageUrl = "clients-3.webp"
				},
				new Client
				{
					Id = 4,
					ImageUrl = "clients-4.webp"
				},
				new Client
				{
					Id = 5,
					ImageUrl = "clients-5.webp"
				},
				new Client
				{
					Id = 6,
					ImageUrl = "clients-6.webp"
				},
				new Client
				{
					Id = 7,
					ImageUrl = "clients-7.webp"
				},
				new Client
				{
					Id = 8,
					ImageUrl = "clients-8.webp"
				}
			);

			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = 1,
					FullName = "Walter White",
					ImageUrl = "person-f-5.webp",
					Position = "Chief Executive Officer"
				},
				new User
				{
					Id = 2,
					FullName = "Sarah Johnson",
					ImageUrl = "person-f-12.webp",
					Position = "Product Manager"
				},
				new User
				{
					Id = 3,
					FullName = "William Anderson",
					ImageUrl = "person-m-9.webp",
					Position = "CTO"
				},
				new User
				{
					Id = 4,
					FullName = "Amanda Jepson",
					ImageUrl = "person-f-4.webp",
					Position = "Lead Designer"
				},
				new User
				{
					Id = 5,
					FullName = "Saul Goodman",
					ImageUrl = "person-m-6.webp",
					Position = "Legal Advisor"
				},
				new User
				{
					Id = 6,
					FullName = "Jenna Karlis",
					ImageUrl = "person-f-8.webp",
					Position = "Store Owner"
				}
			);

			modelBuilder.Entity<Review>().HasData(
				new Review
				{
					Id = 1,
					StarCount = 5,
					Comment = "Excellent service and very professional team.",
					UserId = 1
				},
				new Review
				{
					Id = 2,
					StarCount = 4.5m,
					Comment = "Great communication and timely delivery.",
					UserId = 2
				},
				new Review
				{
					Id = 3,
					StarCount = 5,
					Comment = "Highly recommended for modern web solutions.",
					UserId = 3
				},
				new Review
				{
					Id = 4,
					StarCount = 4.5m,
					Comment = "Creative team with strong attention to detail.",
					UserId = 4
				},
				new Review
				{
					Id = 5,
					StarCount = 5,
					Comment = "Professional, reliable, and easy to work with.",
					UserId = 5
				},
				new Review
				{
					Id = 6,
					StarCount = 4,
					Comment = "Very satisfied with the final result and support.",
					UserId = 6
				}
			);
		}
	}
}
