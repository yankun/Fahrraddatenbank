using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using de.strewi.database.Models;

namespace de.strewi.database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		public async Task<int> SaveChangesAsync(ApplicationUser currentUser, CancellationToken cancellationToken = default(CancellationToken))
		{
			var selectedEntities = ChangeTracker.Entries()
									.Where(x => x.Entity is BaseModel &&
									(x.State == EntityState.Added || x.State == EntityState.Modified));

			var currentDate = DateTime.UtcNow;

			foreach(var entity in selectedEntities) {
                var model = (BaseModel)entity.Entity;
                model.Id = Guid.NewGuid();
                if (entity.State == EntityState.Added)
                {
                    model.CreatedAt = currentDate;
                    model.CreatedBy = currentUser;
                }
                else
                {
                    model.ModifiedAt = currentDate;
                    model.ModifiedBy = currentUser;
                }
			}

			return await base.SaveChangesAsync(cancellationToken);
		}

		public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
		{
			return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}

		protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(b => { b.Property(u => u.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<Role>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<Manufacturer>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<HeadBadge>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<CrankAxle>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<BearingShell>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<ValueChange>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<ModerationItem>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
            builder.Entity<Framenumber>(b => { b.Property(r => r.Id).ForSqlServerHasDefaultValueSql("newsequentialid()"); });
        }


		public DbSet<Manufacturer> Manufactures { get; set; }
		public DbSet<HeadBadge> Headbadges { get; set; }
		public DbSet<CrankAxle> CrankAxles { get; set; }
		public DbSet<BearingShell> BearingShells { get; }
        public DbSet<ValueChange> ValueChanges { get; }
        public DbSet<ModerationItem> ModerationQueue { get; }
        public DbSet<Framenumber> Framenumbers { get; set; }
    }
}
