namespace WebApplication3.Controllers
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class UserModel<TContext> : DbContext where TContext : DbContext
	{

		static UserModel()
		{
			Database.SetInitializer<TContext>(null);
		}

		public UserModel()
			: base("name=User")
		{
		}

		public virtual DbSet<User> Users { get; set; }
		//public DbSet<usp_addUser> usp_addUser { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.Property(e => e.emailAddress)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.photo)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.firstName)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.lastName)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.passwordHash)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.passwordSalt)
				.IsUnicode(false);
		}
	}
}
