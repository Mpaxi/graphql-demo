using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Paxi.GraphQL.Demo.Fund.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Fund.Api.Configuration
{
    public class FixedIncomeFundConfiguration : IEntityTypeConfiguration<FixedIncomeFund>
    {
        public void Configure(EntityTypeBuilder<FixedIncomeFund> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Price);
            builder.Property(p => p.Cota);

            builder.HasOne(e => e.Wallet).WithMany(o => o.FixedIncomeFunds).HasForeignKey(f => f.WalletId);
        }
    }
}
