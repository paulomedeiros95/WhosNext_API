using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Account;

namespace WhosNext_Infra.Builders
{
    public class AccountConfiguration : IEntityTypeConfiguration<AccountDomain>
    {
        public void Configure(EntityTypeBuilder<AccountDomain> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name)
              .IsRequired();
            builder.Property(p => p.ExternalCode)
              .IsRequired();
            builder.HasMany(x => x.Lowers);
        }
    }
}
