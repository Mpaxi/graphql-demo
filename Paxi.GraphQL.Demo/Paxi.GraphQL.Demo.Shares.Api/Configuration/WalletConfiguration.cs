using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Paxi.GraphQL.Demo.Shares.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paxi.GraphQL.Demo.Shares.Api.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.ClientId);

            builder.HasMany(e => e.Shares).WithOne(o => o.Wallet).HasForeignKey(f => f.WalletId);
        }
    }
}
