using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Paxi.GraphQL.Demo.Fund.Api.Model;

namespace Paxi.GraphQL.Demo.Fund.Api.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.ClientId);

            builder.HasMany(e => e.FixedIncomeFunds).WithOne(o => o.Wallet).HasForeignKey(f => f.WalletId);

            builder.HasMany(e => e.MultimarketFunds).WithOne(o => o.Wallet).HasForeignKey(f => f.WalletId);
        }
    }
}
