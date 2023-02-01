using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Account;
using WhosNext_Infra.Builders;
using WhosNext_Infra.Seeds;

namespace WhosNext_Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        #region DbSet
        public virtual DbSet<AccountDomain> Accounts { get; set; }
        #endregion

        #region Consturctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
            Database.Migrate();
        }

        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDomain>(new AccountConfiguration().Configure);

            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
        #endregion
    }
}
