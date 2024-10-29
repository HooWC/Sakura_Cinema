using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace Insfrastructure
{
	public class AppDbContext : DbContext
	{

		public AppDbContext()
		{

		}

		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Admin> Admins { get; set; } = null!;
		public DbSet<Hall> Halls { get; set; } = null!;
		public DbSet<Movie> Movies { get; set; } = null!;
		public DbSet<Payment> Payments { get; set; } = null!;
		public DbSet<Reservation> Reservations { get; set; } = null!;
		public DbSet<SeatReservation> SeatReservations { get; set; } = null!;
		public DbSet<Show> Shows { get; set; } = null!;
		public DbSet<User> Users { get; set; } = null!;
		public DbSet<Actor> Actors { get; set; } = null!;
		public DbSet<Director> Directors { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=LAPTOP-75SCS0RS\\SQLEXPRESS;Database=Cinema_New;Trusted_Connection=True;TrustServerCertificate=true");
			}
		}

	}
}
